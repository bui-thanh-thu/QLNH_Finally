namespace DXApplication1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.itemDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.itemDangNhapLai = new DevExpress.XtraBars.BarButtonItem();
            this.itemThoatCT = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navHoaDon = new DevExpress.XtraNavBar.NavBarGroup();
            this.navOrder = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBaoCao = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBieuDo = new DevExpress.XtraNavBar.NavBarGroup();
            this.navMenu = new DevExpress.XtraNavBar.NavBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageOrder = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pgaeBaoCao = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageMenu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageBan = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageNhapKho = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageNhanVien = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.BackColor = System.Drawing.Color.White;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.skinRibbonGalleryBarItem,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.itemDoiMatKhau,
            this.itemDangNhapLai,
            this.itemThoatCT});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 49;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 158);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl.Click += new System.EventHandler(this.ribbonControl_Click);
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Employees";
            this.employeesBarButtonItem.Id = 44;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            this.employeesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Customers";
            this.customersBarButtonItem.Id = 45;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            this.customersBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // itemDoiMatKhau
            // 
            this.itemDoiMatKhau.Caption = "Đổi mật khẩu";
            this.itemDoiMatKhau.Id = 46;
            this.itemDoiMatKhau.ImageOptions.LargeImage = global::DXApplication1.Properties.Resources.Re_Enter_Pincode_48px;
            this.itemDoiMatKhau.Name = "itemDoiMatKhau";
            this.itemDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemDoiMatKhau_ItemClick);
            // 
            // itemDangNhapLai
            // 
            this.itemDangNhapLai.Caption = "Đăng xuất";
            this.itemDangNhapLai.Id = 47;
            this.itemDangNhapLai.ImageOptions.LargeImage = global::DXApplication1.Properties.Resources.Change_User_Male_48px;
            this.itemDangNhapLai.Name = "itemDangNhapLai";
            this.itemDangNhapLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemDangNhapLai_ItemClick);
            // 
            // itemThoatCT
            // 
            this.itemThoatCT.Caption = "Thoát chương trình";
            this.itemThoatCT.Id = 48;
            this.itemThoatCT.ImageOptions.LargeImage = global::DXApplication1.Properties.Resources.Cancel_48px;
            this.itemThoatCT.Name = "itemThoatCT";
            this.itemThoatCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemThoatCT_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNavigation});
            this.ribbonPage.Name = "ribbonPage";
            // 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.itemDoiMatKhau);
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.itemDangNhapLai);
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.itemThoatCT);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Hệ thống";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navHoaDon;
            this.navBarControl.Appearance.Background.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.Background.Options.UseFont = true;
            this.navBarControl.Appearance.Button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.Button.Options.UseFont = true;
            this.navBarControl.Appearance.GroupHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl.Appearance.GroupHeaderActive.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.GroupHeaderActive.Options.UseFont = true;
            this.navBarControl.Appearance.NavigationPaneHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.NavigationPaneHeader.Options.UseFont = true;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navHoaDon,
            this.navOrder,
            this.navBaoCao,
            this.navBieuDo,
            this.navMenu});
            this.navBarControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.navBarControl.Location = new System.Drawing.Point(0, 158);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 228;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(228, 512);
            this.navBarControl.TabIndex = 0;
            this.navBarControl.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("VS2010");
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // navHoaDon
            // 
            this.navHoaDon.Caption = "HÓA ĐƠN";
            this.navHoaDon.Expanded = true;
            this.navHoaDon.ImageOptions.LargeImage = global::DXApplication1.Properties.Resources.Waiter_48px;
            this.navHoaDon.ImageOptions.SmallImage = global::DXApplication1.Properties.Resources.Report_Card_48px;
            this.navHoaDon.Name = "navHoaDon";
            // 
            // navOrder
            // 
            this.navOrder.Caption = "ORDER";
            this.navOrder.ImageOptions.LargeImage = global::DXApplication1.Properties.Resources.Shopping_Basket_48px;
            this.navOrder.Name = "navOrder";
            // 
            // navBaoCao
            // 
            this.navBaoCao.Caption = "BÁO CÁO CHI TIẾT";
            this.navBaoCao.ImageOptions.LargeImage = global::DXApplication1.Properties.Resources.Report_Card_48px;
            this.navBaoCao.ImageOptions.SmallImage = global::DXApplication1.Properties.Resources.Top_Menu_48px;
            this.navBaoCao.Name = "navBaoCao";
            // 
            // navBieuDo
            // 
            this.navBieuDo.Caption = " DOANH THU";
            this.navBieuDo.ImageOptions.LargeImage = global::DXApplication1.Properties.Resources.Combo_Chart_48px;
            this.navBieuDo.Name = "navBieuDo";
            // 
            // navMenu
            // 
            this.navMenu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navMenu.Appearance.Options.UseFont = true;
            this.navMenu.Caption = "MENU";
            this.navMenu.ImageOptions.LargeImage = global::DXApplication1.Properties.Resources.Top_Menu_48px;
            this.navMenu.Name = "navMenu";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.pageOrder);
            this.navigationFrame.Controls.Add(this.pgaeBaoCao);
            this.navigationFrame.Controls.Add(this.pageMenu);
            this.navigationFrame.Controls.Add(this.pageBan);
            this.navigationFrame.Controls.Add(this.pageNhapKho);
            this.navigationFrame.Controls.Add(this.pageNhanVien);
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(228, 158);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageOrder,
            this.pgaeBaoCao,
            this.pageMenu,
            this.pageBan,
            this.pageNhapKho,
            this.pageNhanVien,
            this.navigationPage1});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.Size = new System.Drawing.Size(562, 512);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // pageOrder
            // 
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Size = new System.Drawing.Size(562, 512);
            // 
            // pgaeBaoCao
            // 
            this.pgaeBaoCao.Name = "pgaeBaoCao";
            this.pgaeBaoCao.Size = new System.Drawing.Size(562, 512);
            // 
            // pageMenu
            // 
            this.pageMenu.Name = "pageMenu";
            this.pageMenu.Size = new System.Drawing.Size(562, 512);
            // 
            // pageBan
            // 
            this.pageBan.Name = "pageBan";
            this.pageBan.Size = new System.Drawing.Size(562, 512);
            // 
            // pageNhapKho
            // 
            this.pageNhapKho.Name = "pageNhapKho";
            this.pageNhapKho.Size = new System.Drawing.Size(562, 512);
            // 
            // pageNhanVien
            // 
            this.pageNhanVien.Name = "pageNhanVien";
            this.pageNhanVien.Size = new System.Drawing.Size(562, 512);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(562, 512);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 670);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.Text = "PHẦN MỀM QUẢN LÝ NHÀ HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navMenu;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem itemDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem itemDangNhapLai;
        private DevExpress.XtraBars.BarButtonItem itemThoatCT;
        private DevExpress.XtraNavBar.NavBarGroup navOrder;
        private DevExpress.XtraNavBar.NavBarGroup navBaoCao;
        private DevExpress.XtraNavBar.NavBarGroup navHoaDon;
        private DevExpress.XtraBars.Navigation.NavigationPage pageOrder;
        private DevExpress.XtraBars.Navigation.NavigationPage pgaeBaoCao;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMenu;
        private DevExpress.XtraBars.Navigation.NavigationPage pageBan;
        private DevExpress.XtraBars.Navigation.NavigationPage pageNhapKho;
        private DevExpress.XtraNavBar.NavBarGroup navBieuDo;
        private DevExpress.XtraBars.Navigation.NavigationPage pageNhanVien;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
    }
}