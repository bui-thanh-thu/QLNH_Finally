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
    public partial class frmLogin : DevExpress.XtraBars.TabForm
    {
        public frmLogin()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SkinName = "";
        }
        bool IsDN = false;
        MasterDataContext db = new MasterDataContext();
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsDN)
                UserLookAndFeel.Default.SkinName = Properties.Settings.Default.SkinName;
            else
                Application.Exit();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.IsSave == true)
                {
                    txtTaiKhoan.Text = Properties.Settings.Default.UserName;
                    txtMatKhau.Text = Properties.Settings.Default.Password;
                    ckSave.Checked = true;
                }
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var objDN = db.TaiKhoans.SingleOrDefault(p => p.UserName.ToLower() == txtTaiKhoan.Text.ToLower() && p.Pass == txtMatKhau.Text.ToLower());
                if (objDN != null)
                {
                    if (ckSave.Checked)
                    {
                        Properties.Settings.Default.Password = txtMatKhau.Text;
                        Properties.Settings.Default.UserName = txtTaiKhoan.Text;
                        Properties.Settings.Default.IsSave = true;
                    }
                    else
                    {
                        Properties.Settings.Default.IsSave = false;
                    }
                    //if (ckKhoiDong.IsChecked.GetValueOrDefault())
                    //{
                    //    RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    //    rkApp.SetValue("WpfApplication1.exe", Assembly.GetEntryAssembly().Location);
                    //}
                    //else
                    //{
                    //    RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    //    rkApp.SetValue("WpfApplication1.exe", "");
                    //}
                    //if (cbmLanguage.SelectedIndex == 0)
                    //    Properties.Settings.Default.IsTranslate = false;
                    //else
                    //    Properties.Settings.Default.IsTranslate = true;
                    //Properties.Settings.Default.IsDN = true;
                    Properties.Settings.Default.MaNV = objDN.ID;
                    Properties.Settings.Default.Save();
                    IsDN = true;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Tài khoản không chính xác.Vui lòng kiểm tra lại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var result = XtraInputBox.Show("Thiết lập server", "Nhập chuỗi kết nối", Properties.Settings.Default.QuanLyQuanCafeConnectionString);
                if (string.IsNullOrEmpty(result)) return;
                Properties.Settings.Default.QuanLyQuanCafeConnectionString = result;
                Properties.Settings.Default.Save();
                XtraMessageBox.Show("Đã thiết lập server thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {

                
            }
        }
    }
}
