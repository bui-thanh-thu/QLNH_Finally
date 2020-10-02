using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmMenuEdit : DevExpress.XtraBars.TabForm
    {
        public frmMenuEdit()
        {
            InitializeComponent();
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle("");
        }
        MasterDataContext db = new MasterDataContext();
        public int? ID { get; set; }
        public clsMenu objMN_Select;
        MENU objMN;
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                lookLoai.Properties.DataSource = db.LOAIs;
                if (ID == null)
                {
                    objMN = new MENU();
                }
                else
                {
                    objMN = db.MENUs.SingleOrDefault(p => p.ID == ID);
                    txtName.Text = objMN.Name;
                    lookLoai.EditValue = objMN.LoaiID;
                    spinSoTien.EditValue = objMN.GiaBan.GetValueOrDefault();
                    picAnh.Image = Image.FromStream(new MemoryStream(objMN.HinhAnh.ToArray()));
                }
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Tên món].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lookLoai.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn [Loại].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (spinSoTien.Value <= 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Giá bán].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                objMN.Name = txtName.Text;
                objMN.GiaBan = spinSoTien.Value;
                objMN.LoaiID = (int?)lookLoai.EditValue;
                MemoryStream st = new MemoryStream();
                picAnh.Image.Save(st, ImageFormat.Png);
                objMN.HinhAnh = st.ToArray();
                if (ID == null)
                    db.MENUs.InsertOnSubmit(objMN);
                else
                {
                    objMN_Select.Name = txtName.Text;
                    objMN_Select.GiaBan = spinSoTien.Value;
                    objMN_Select.LoaiID = (int)lookLoai.EditValue;
                    objMN_Select.HinhAnh = picAnh.Image;
                }
                db.SubmitChanges();
                XtraMessageBox.Show("Đã lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog f =new OpenFileDialog())
                {
                    f.ShowDialog();
                    if (string.IsNullOrEmpty(f.FileName))
                        return;
                    picAnh.Image = Image.FromFile(f.FileName);
                    btnChonAnh.Text = f.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
