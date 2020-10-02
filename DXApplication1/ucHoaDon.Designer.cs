namespace DXApplication1
{
    partial class ucHoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHoaDon));
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLNHDataSet = new DXApplication1.DB_QLNHDataSet();
            this.hOADONTableAdapter = new DXApplication1.DB_QLNHDataSetTableAdapters.HOADONTableAdapter();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lsvCTHD = new System.Windows.Forms.ListView();
            this.MenuID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLNHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.dB_QLNHDataSet;
            // 
            // dB_QLNHDataSet
            // 
            this.dB_QLNHDataSet.DataSetName = "DB_QLNHDataSet";
            this.dB_QLNHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NgayHD,
            this.Username});
            this.lsvHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(312, 544);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.SelectedIndexChanged += new System.EventHandler(this.lsvHoaDon_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NgayHD
            // 
            this.NgayHD.Text = "Ngày";
            this.NgayHD.Width = 150;
            // 
            // Username
            // 
            this.Username.Text = "Người tạo";
            this.Username.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTongtien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lsvCTHD);
            this.panel1.Controls.Add(this.lbMaHD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(391, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 544);
            this.panel1.TabIndex = 1;
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.ForeColor = System.Drawing.Color.Red;
            this.lbMaHD.Location = new System.Drawing.Point(204, 37);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(62, 20);
            this.lbMaHD.TabIndex = 0;
            this.lbMaHD.Text = "Mã HĐ";
            // 
            // lsvCTHD
            // 
            this.lsvCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MenuID,
            this.SoLuong,
            this.DonGia,
            this.columnHeader1});
            this.lsvCTHD.HideSelection = false;
            this.lsvCTHD.Location = new System.Drawing.Point(-1, 109);
            this.lsvCTHD.Name = "lsvCTHD";
            this.lsvCTHD.Size = new System.Drawing.Size(481, 151);
            this.lsvCTHD.TabIndex = 1;
            this.lsvCTHD.UseCompatibleStateImageBehavior = false;
            // 
            // MenuID
            // 
            this.MenuID.Text = "Tên món";
            this.MenuID.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.Width = 100;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 100;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(318, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(78, 36);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Refresh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(244, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền:";
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.BackColor = System.Drawing.Color.Salmon;
            this.lbTongtien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.Color.Black;
            this.lbTongtien.Location = new System.Drawing.Point(342, 306);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(0, 19);
            this.lbTongtien.TabIndex = 3;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Thành tiền";
            this.columnHeader1.Width = 120;
            // 
            // ucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvHoaDon);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(872, 544);
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLNHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private DB_QLNHDataSet dB_QLNHDataSet;
        private DB_QLNHDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NgayHD;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvCTHD;
        private System.Windows.Forms.ColumnHeader MenuID;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.Label lbMaHD;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
