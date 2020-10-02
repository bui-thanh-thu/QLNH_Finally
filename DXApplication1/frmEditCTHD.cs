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
    public partial class frmEditCTHD : DevExpress.XtraBars.TabForm
    {
        public frmEditCTHD()
        {
            InitializeComponent();
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle("");
        }
        MasterDataContext db = new MasterDataContext();
        public int? ID { get; set; }
        CHITIETHOADON objNK;
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
                objNK = db.CHITIETHOADONs.SingleOrDefault(p => p.ID == ID);
                txtKhu.Text = objNK.GhiChu;
                spinSoBan.EditValue = objNK.SoLuong;
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
                if (spinSoBan.Value <= 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Số lượng].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                objNK.GhiChu = txtKhu.Text;
                objNK.SoLuong = (int)spinSoBan.Value;
                db.SubmitChanges();
                XtraMessageBox.Show("Đã lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
