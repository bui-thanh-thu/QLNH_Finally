﻿namespace DXApplication1
{
    partial class frmOrder
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan4 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan5 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.columnRead = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.lookLoai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.columnSender = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.columnSubject = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.columnText = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.columnDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colImage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gcMenu = new DevExpress.XtraGrid.GridControl();
            this.gvMenu = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiChu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnRead
            // 
            this.columnRead.Caption = "columnRead";
            this.columnRead.ColumnEdit = this.lookLoai;
            this.columnRead.FieldName = "LoaiID";
            this.columnRead.Name = "columnRead";
            this.columnRead.Visible = true;
            this.columnRead.VisibleIndex = 0;
            // 
            // lookLoai
            // 
            this.lookLoai.AutoHeight = false;
            this.lookLoai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookLoai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name1")});
            this.lookLoai.DisplayMember = "Name";
            this.lookLoai.Name = "lookLoai";
            this.lookLoai.NullText = "";
            this.lookLoai.ValueMember = "ID";
            // 
            // columnSender
            // 
            this.columnSender.Caption = "columnSender";
            this.columnSender.FieldName = "Sender";
            this.columnSender.Name = "columnSender";
            // 
            // columnSubject
            // 
            this.columnSubject.Caption = "columnSubject";
            this.columnSubject.FieldName = "Name";
            this.columnSubject.Name = "columnSubject";
            this.columnSubject.Visible = true;
            this.columnSubject.VisibleIndex = 1;
            // 
            // columnText
            // 
            this.columnText.Caption = "columnText";
            this.columnText.FieldName = "Text";
            this.columnText.Name = "columnText";
            // 
            // columnDate
            // 
            this.columnDate.Caption = "columnDate";
            this.columnDate.ColumnEdit = this.repositoryItemSpinEdit1;
            this.columnDate.DisplayFormat.FormatString = "{0:n0}";
            this.columnDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.columnDate.FieldName = "GiaBan";
            this.columnDate.Name = "columnDate";
            this.columnDate.Visible = true;
            this.columnDate.VisibleIndex = 2;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "{0:n0} VNĐ";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colImage
            // 
            this.colImage.ColumnEdit = this.repositoryItemPictureEdit2;
            this.colImage.FieldName = "HinhAnh";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 3;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.ZoomAccelerationFactor = 1D;
            // 
            // colSoLuong
            // 
            this.colSoLuong.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colSoLuong.DisplayFormat.FormatString = "Số lượng: {0:n0}";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.DisplayFormat.FormatString = "Số lượng: {0:n0}";
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatString = "Số lượng: {0:n0}";
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 5;
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
            this.tabFormControl1.Size = new System.Drawing.Size(1103, 50);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage1.Text = "Order";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.gcMenu);
            this.tabFormContentContainer1.Controls.Add(this.btnThoat);
            this.tabFormContentContainer1.Controls.Add(this.btnGhiChu);
            this.tabFormContentContainer1.Controls.Add(this.btnDangNhap);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 50);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1103, 545);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // gcMenu
            // 
            this.gcMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMenu.Location = new System.Drawing.Point(0, 0);
            this.gcMenu.MainView = this.gvMenu;
            this.gcMenu.Name = "gcMenu";
            this.gcMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.lookLoai,
            this.repositoryItemPictureEdit2,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.gcMenu.Size = new System.Drawing.Size(1103, 504);
            this.gcMenu.TabIndex = 6;
            this.gcMenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMenu});
            // 
            // gvMenu
            // 
            this.gvMenu.Appearance.GroupText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMenu.Appearance.GroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(124)))), ((int)(((byte)(50)))));
            this.gvMenu.Appearance.GroupText.Options.UseFont = true;
            this.gvMenu.Appearance.GroupText.Options.UseForeColor = true;
            this.gvMenu.Appearance.ItemFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.gvMenu.Appearance.ItemFocused.Options.UseBackColor = true;
            this.gvMenu.Appearance.ItemHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(248)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.gvMenu.Appearance.ItemHovered.Options.UseBackColor = true;
            this.gvMenu.Appearance.ItemNormal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMenu.Appearance.ItemNormal.Options.UseFont = true;
            this.gvMenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnRead,
            this.columnSender,
            this.columnSubject,
            this.columnText,
            this.columnDate,
            this.colImage,
            this.colSoLuong,
            this.colGhiChu});
            this.gvMenu.ColumnSet.CheckedColumn = this.colSoLuong;
            this.gvMenu.ColumnSet.GroupColumn = this.columnRead;
            this.gvMenu.FocusBorderColor = System.Drawing.Color.Transparent;
            this.gvMenu.GridControl = this.gcMenu;
            this.gvMenu.Name = "gvMenu";
            this.gvMenu.OptionsBehavior.AllowSmoothScrolling = true;
            this.gvMenu.OptionsTiles.AllowItemHover = true;
            this.gvMenu.OptionsTiles.AllowPressAnimation = false;
            this.gvMenu.OptionsTiles.GroupTextOffset = 25;
            this.gvMenu.OptionsTiles.GroupTextToItemsIndent = 10;
            this.gvMenu.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            this.gvMenu.OptionsTiles.ItemSize = new System.Drawing.Size(306, 120);
            this.gvMenu.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.gvMenu.OptionsTiles.Padding = new System.Windows.Forms.Padding(7);
            this.gvMenu.OptionsTiles.RowCount = 0;
            this.gvMenu.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar;
            this.gvMenu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.columnRead, DevExpress.Data.ColumnSortOrder.Ascending)});
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition1.Length.Value = 12D;
            tableColumnDefinition2.Length.Value = 94D;
            tableColumnDefinition2.PaddingRight = 5;
            tableColumnDefinition3.Length.Value = 97D;
            tableColumnDefinition3.PaddingLeft = 5;
            tableColumnDefinition4.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition4.Length.Value = 45D;
            this.gvMenu.TileColumns.Add(tableColumnDefinition1);
            this.gvMenu.TileColumns.Add(tableColumnDefinition2);
            this.gvMenu.TileColumns.Add(tableColumnDefinition3);
            this.gvMenu.TileColumns.Add(tableColumnDefinition4);
            tableRowDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableRowDefinition1.Length.Value = 38D;
            tableRowDefinition2.Length.Value = 26D;
            tableRowDefinition3.Length.Value = 56D;
            this.gvMenu.TileRows.Add(tableRowDefinition1);
            this.gvMenu.TileRows.Add(tableRowDefinition2);
            this.gvMenu.TileRows.Add(tableRowDefinition3);
            tableSpan1.ColumnIndex = 3;
            tableSpan1.ColumnSpan = 2;
            tableSpan1.RowIndex = 1;
            tableSpan2.ColumnIndex = 2;
            tableSpan2.ColumnSpan = 2;
            tableSpan3.ColumnIndex = 2;
            tableSpan3.ColumnSpan = 2;
            tableSpan3.RowIndex = 2;
            tableSpan4.RowSpan = 3;
            tableSpan5.ColumnIndex = 1;
            tableSpan5.RowSpan = 3;
            this.gvMenu.TileSpans.Add(tableSpan1);
            this.gvMenu.TileSpans.Add(tableSpan2);
            this.gvMenu.TileSpans.Add(tableSpan3);
            this.gvMenu.TileSpans.Add(tableSpan4);
            this.gvMenu.TileSpans.Add(tableSpan5);
            tileViewItemElement1.Column = this.columnRead;
            tileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Name = "readElement";
            tileViewItemElement1.StretchVertical = true;
            tileViewItemElement1.Text = "columnRead";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement1.TextVisible = false;
            tileViewItemElement1.Width = 3;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement2.Column = this.columnSender;
            tileViewItemElement2.ColumnIndex = 2;
            tileViewItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "columnSender";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement3.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement3.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement3.Column = this.columnSubject;
            tileViewItemElement3.ColumnIndex = 2;
            tileViewItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.Text = "columnSubject";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement4.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement4.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement4.Column = this.columnText;
            tileViewItemElement4.ColumnIndex = 2;
            tileViewItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "columnText";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement5.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement5.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement5.Column = this.columnDate;
            tileViewItemElement5.ColumnIndex = 2;
            tileViewItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 1;
            tileViewItemElement5.Text = "columnDate";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement6.Column = this.colImage;
            tileViewItemElement6.ColumnIndex = 1;
            tileViewItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.StretchHorizontal = true;
            tileViewItemElement6.StretchVertical = true;
            tileViewItemElement6.Text = "colImage";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement7.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement7.Column = this.colSoLuong;
            tileViewItemElement7.ColumnIndex = 2;
            tileViewItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.Name = "colSoLuong";
            tileViewItemElement7.RowIndex = 2;
            tileViewItemElement7.Text = "colSoLuong";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement8.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            tileViewItemElement8.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement8.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement8.Column = this.colGhiChu;
            tileViewItemElement8.ColumnIndex = 2;
            tileViewItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement8.RowIndex = 2;
            tileViewItemElement8.Text = "colGhiChu";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.gvMenu.TileTemplate.Add(tileViewItemElement1);
            this.gvMenu.TileTemplate.Add(tileViewItemElement2);
            this.gvMenu.TileTemplate.Add(tileViewItemElement3);
            this.gvMenu.TileTemplate.Add(tileViewItemElement4);
            this.gvMenu.TileTemplate.Add(tileViewItemElement5);
            this.gvMenu.TileTemplate.Add(tileViewItemElement6);
            this.gvMenu.TileTemplate.Add(tileViewItemElement7);
            this.gvMenu.TileTemplate.Add(tileViewItemElement8);
            this.gvMenu.ItemCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(this.gvMenu_ItemCustomize);
            this.gvMenu.DoubleClick += new System.EventHandler(this.gvMenu_DoubleClick);
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Custom;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ImageOptions.Image = global::DXApplication1.Properties.Resources.Cancel;
            this.btnThoat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThoat.Location = new System.Drawing.Point(1022, 515);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhiChu
            // 
            this.btnGhiChu.ImageOptions.Image = global::DXApplication1.Properties.Resources.Edit_Property;
            this.btnGhiChu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGhiChu.Location = new System.Drawing.Point(836, 515);
            this.btnGhiChu.Name = "btnGhiChu";
            this.btnGhiChu.Size = new System.Drawing.Size(87, 23);
            this.btnGhiChu.TabIndex = 4;
            this.btnGhiChu.Text = "Ghi chú";
            this.btnGhiChu.Click += new System.EventHandler(this.btnGhiChu_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ImageOptions.Image = global::DXApplication1.Properties.Resources.Save;
            this.btnDangNhap.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDangNhap.Location = new System.Drawing.Point(929, 515);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(87, 23);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Lưu";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmOrder
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1103, 595);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.MaximumSize = new System.Drawing.Size(1113, 600);
            this.MinimumSize = new System.Drawing.Size(1113, 600);
            this.Name = "frmOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraGrid.GridControl gcMenu;
        private DevExpress.XtraGrid.Views.Tile.TileView gvMenu;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnRead;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookLoai;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnSender;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnSubject;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnText;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.SimpleButton btnGhiChu;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGhiChu;
    }
}