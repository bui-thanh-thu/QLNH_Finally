namespace DXApplication1
{
    partial class frmNhanVien
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
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.cbmCachTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.spinMucLuong = new DevExpress.XtraEditors.SpinEdit();
            this.spinTuoi = new DevExpress.XtraEditors.SpinEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.MemoEdit();
            this.dateNgayVaoLam = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbmCachTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMucLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayVaoLam.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayVaoLam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabCloseButtons = false;
            this.tabFormControl1.Size = new System.Drawing.Size(423, 50);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage1.Text = "Nhân viên";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.cbmCachTinh);
            this.tabFormContentContainer1.Controls.Add(this.txtSDT);
            this.tabFormContentContainer1.Controls.Add(this.txtHoTen);
            this.tabFormContentContainer1.Controls.Add(this.spinMucLuong);
            this.tabFormContentContainer1.Controls.Add(this.spinTuoi);
            this.tabFormContentContainer1.Controls.Add(this.txtDiaChi);
            this.tabFormContentContainer1.Controls.Add(this.dateNgayVaoLam);
            this.tabFormContentContainer1.Controls.Add(this.labelControl7);
            this.tabFormContentContainer1.Controls.Add(this.btnThoat);
            this.tabFormContentContainer1.Controls.Add(this.labelControl5);
            this.tabFormContentContainer1.Controls.Add(this.btnDangNhap);
            this.tabFormContentContainer1.Controls.Add(this.labelControl3);
            this.tabFormContentContainer1.Controls.Add(this.labelControl6);
            this.tabFormContentContainer1.Controls.Add(this.labelControl2);
            this.tabFormContentContainer1.Controls.Add(this.labelControl4);
            this.tabFormContentContainer1.Controls.Add(this.labelControl1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 50);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(423, 240);
            this.tabFormContentContainer1.TabIndex = 1;
            this.tabFormContentContainer1.Click += new System.EventHandler(this.tabFormContentContainer1_Click);
            // 
            // cbmCachTinh
            // 
            this.cbmCachTinh.EditValue = "Theo giờ";
            this.cbmCachTinh.Location = new System.Drawing.Point(127, 126);
            this.cbmCachTinh.Name = "cbmCachTinh";
            this.cbmCachTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbmCachTinh.Properties.Items.AddRange(new object[] {
            "Theo giờ",
            "Theo ngày",
            "Theo tháng"});
            this.cbmCachTinh.Size = new System.Drawing.Size(262, 20);
            this.cbmCachTinh.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(269, 44);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Mask.EditMask = "\\d{1,11}";
            this.txtSDT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSDT.Size = new System.Drawing.Size(120, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(127, 18);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(262, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // spinMucLuong
            // 
            this.spinMucLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMucLuong.Location = new System.Drawing.Point(127, 152);
            this.spinMucLuong.Name = "spinMucLuong";
            this.spinMucLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMucLuong.Properties.DisplayFormat.FormatString = "n0";
            this.spinMucLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMucLuong.Properties.EditFormat.FormatString = "n0";
            this.spinMucLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinMucLuong.Size = new System.Drawing.Size(262, 20);
            this.spinMucLuong.TabIndex = 5;
            // 
            // spinTuoi
            // 
            this.spinTuoi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTuoi.Location = new System.Drawing.Point(127, 44);
            this.spinTuoi.Name = "spinTuoi";
            this.spinTuoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTuoi.Properties.DisplayFormat.FormatString = "n0";
            this.spinTuoi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTuoi.Properties.EditFormat.FormatString = "n0";
            this.spinTuoi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinTuoi.Size = new System.Drawing.Size(78, 20);
            this.spinTuoi.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(127, 73);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(262, 47);
            this.txtDiaChi.TabIndex = 3;
            // 
            // dateNgayVaoLam
            // 
            this.dateNgayVaoLam.EditValue = null;
            this.dateNgayVaoLam.Location = new System.Drawing.Point(127, 178);
            this.dateNgayVaoLam.Name = "dateNgayVaoLam";
            this.dateNgayVaoLam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayVaoLam.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayVaoLam.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayVaoLam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayVaoLam.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayVaoLam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayVaoLam.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayVaoLam.Size = new System.Drawing.Size(262, 20);
            this.dateNgayVaoLam.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(43, 155);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Mức lương:";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ImageOptions.Image = global::DXApplication1.Properties.Resources.Cancel;
            this.btnThoat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThoat.Location = new System.Drawing.Point(320, 204);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(43, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Tuổi:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ImageOptions.Image = global::DXApplication1.Properties.Resources.Unlock_1;
            this.btnDangNhap.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDangNhap.Location = new System.Drawing.Point(227, 204);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(87, 23);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Xác nhận";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Cách tính lương:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(210, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Điện thoại:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Địa chỉ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 21);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Họ tên:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 181);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngày vào làm:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // frmNhanVien
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(423, 290);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.MaximumSize = new System.Drawing.Size(433, 295);
            this.MinimumSize = new System.Drawing.Size(433, 295);
            this.Name = "frmNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            this.tabFormContentContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbmCachTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMucLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayVaoLam.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayVaoLam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtDiaChi;
        private DevExpress.XtraEditors.DateEdit dateNgayVaoLam;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.SpinEdit spinTuoi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbmCachTinh;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.SpinEdit spinMucLuong;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}