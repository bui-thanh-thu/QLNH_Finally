using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmNhapKho : DevExpress.XtraBars.TabForm
    {
        public frmNhapKho()
        {
            InitializeComponent();
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle("");
        }
        MasterDataContext db = new MasterDataContext();
        public int? ID { get; set; }
        public NhapKho_SelectResult objNK_Select;
        NHAPKHO objNK;
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
                if (ID == null)
                {
                    dateNgayNhap.EditValue = DateTime.Now;
                    objNK = new NHAPKHO();
                    objNK.UserID = Properties.Settings.Default.MaNV;
                }
                else
                {
                    objNK = db.NHAPKHOs.SingleOrDefault(p => p.ID == ID);
                    dateNgayNhap.EditValue = objNK.NgayNhap.GetValueOrDefault();
                    txtHangNhap.Text = objNK.Name;
                    spinSoTien.EditValue = objNK.TienNhap.GetValueOrDefault();
                }
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Reset()
        {
            dateNgayNhap.EditValue = DateTime.Now;
            txtHangNhap.Text = "";
            spinSoTien.EditValue = 0;
            objNK = new NHAPKHO();
            objNK.UserID = Properties.Settings.Default.MaNV;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHangNhap.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Hàng nhập].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (spinSoTien.Value <= 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Số tiền].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                objNK.Name = txtHangNhap.Text;
                objNK.NgayNhap = dateNgayNhap.DateTime;
                objNK.TienNhap = spinSoTien.Value;
                if (ID == null)
                    db.NHAPKHOs.InsertOnSubmit(objNK);
                else
                {
                    objNK_Select.Name = txtHangNhap.Text;
                    objNK_Select.NgayNhap = dateNgayNhap.DateTime;
                    objNK_Select.TienNhap = spinSoTien.Value;
                }
                db.SubmitChanges();
                XtraMessageBox.Show("Đã lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ID == null) Reset(); else this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
