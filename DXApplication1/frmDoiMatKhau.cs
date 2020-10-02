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
    public partial class frmDoiMatKhau : DevExpress.XtraBars.TabForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SkinName = "";
        }
        MasterDataContext db = new MasterDataContext();
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserLookAndFeel.Default.SkinName = Properties.Settings.Default.SkinName;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtTaiKhoan.Text = Properties.Settings.Default.UserName;
                txtMatKhau.Text = Properties.Settings.Default.Password;
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
                if (txtMatKhauMoi.Text == "" || txtNhapLaiMKM.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Mật khẩu mới].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtMatKhauMoi.Text != txtNhapLaiMKM.Text)
                {
                    XtraMessageBox.Show("[Ô nhập lại mật khẩu mới] chưa khớp với [Ô mật khẩu mới].Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var objNV = db.TaiKhoans.SingleOrDefault(p => p.UserName == Properties.Settings.Default.UserName);
                objNV.Pass = txtMatKhauMoi.Text;
                db.SubmitChanges();
                XtraMessageBox.Show("Đã thay đổi [Mật khẩu] thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
