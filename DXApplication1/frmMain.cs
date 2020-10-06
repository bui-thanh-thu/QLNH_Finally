using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace DXApplication1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<int> lt = new List<int>();
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
            if (!lt.Contains(navigationFrame.SelectedPageIndex))
            {
                lt.Add(navigationFrame.SelectedPageIndex);
                switch (navigationFrame.SelectedPageIndex)
                {
                    case 0:
                        navigationFrame.Pages[navigationFrame.SelectedPageIndex].Controls.Add(new ucHoaDon() { Dock = DockStyle.Fill });
                        break;
                    case 1:
                        navigationFrame.Pages[navigationFrame.SelectedPageIndex].Controls.Add(new uscOrder() { Dock = DockStyle.Fill });
                        break;
                    case 2:
                        navigationFrame.Pages[navigationFrame.SelectedPageIndex].Controls.Add(new uscBaoCao() { Dock = DockStyle.Fill });
                        break;
                    case 3:
                        navigationFrame.Pages[navigationFrame.SelectedPageIndex].Controls.Add(new uscBaoCaoContent() { Dock = DockStyle.Fill });
                        break;
                    
                    case 4 :
                        navigationFrame.Pages[navigationFrame.SelectedPageIndex].Controls.Add(new uscMenu2() { Dock = DockStyle.Fill });
                        break;
                    
                    default:
                        break;
                }
            }

        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            //navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void itemThoatCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SkinName = UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            navBarControl.ActiveGroup = navBarControl.Groups[4];
        }

        private void itemDangNhapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void itemDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void navigationFrame_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }
    }
}