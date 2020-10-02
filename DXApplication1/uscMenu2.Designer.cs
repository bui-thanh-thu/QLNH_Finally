namespace DXApplication1
{
    partial class uscMenu2
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
            this.columnRead = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.lookLoai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.columnSender = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.columnSubject = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.columnText = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.columnDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colImage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gcMenu = new DevExpress.XtraGrid.GridControl();
            this.gvMenu = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.itemRefesh = new DevExpress.XtraBars.BarButtonItem();
            this.itemThem = new DevExpress.XtraBars.BarButtonItem();
            this.itemSua = new DevExpress.XtraBars.BarButtonItem();
            this.itemXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Custom;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // gcMenu
            // 
            this.gcMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMenu.Location = new System.Drawing.Point(0, 0);
            this.gcMenu.MainView = this.gvMenu;
            this.gcMenu.Name = "gcMenu";
            this.gcMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.lookLoai,
            this.repositoryItemPictureEdit2,
            this.repositoryItemSpinEdit1});
            this.gcMenu.Size = new System.Drawing.Size(1035, 378);
            this.gcMenu.TabIndex = 1;
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
            this.colImage});
            this.gvMenu.ColumnSet.GroupColumn = this.columnRead;
            this.gvMenu.FocusBorderColor = System.Drawing.Color.Transparent;
            this.gvMenu.GridControl = this.gcMenu;
            this.gvMenu.Name = "gvMenu";
            this.gvMenu.OptionsBehavior.AllowSmoothScrolling = true;
            this.gvMenu.OptionsTiles.AllowItemHover = true;
            this.gvMenu.OptionsTiles.AllowPressAnimation = false;
            this.gvMenu.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(25, 0, 0, 10);
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
            tableRowDefinition1.Length.Value = 49D;
            tableRowDefinition2.Length.Value = 32D;
            tableRowDefinition3.Length.Value = 39D;
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
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
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
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
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
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
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
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
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
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 1;
            tileViewItemElement5.Text = "columnDate";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement6.Column = this.colImage;
            tileViewItemElement6.ColumnIndex = 1;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.StretchHorizontal = true;
            tileViewItemElement6.StretchVertical = true;
            tileViewItemElement6.Text = "colImage";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.gvMenu.TileTemplate.Add(tileViewItemElement1);
            this.gvMenu.TileTemplate.Add(tileViewItemElement2);
            this.gvMenu.TileTemplate.Add(tileViewItemElement3);
            this.gvMenu.TileTemplate.Add(tileViewItemElement4);
            this.gvMenu.TileTemplate.Add(tileViewItemElement5);
            this.gvMenu.TileTemplate.Add(tileViewItemElement6);
            this.gvMenu.ItemCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(this.gvMenu_ItemCustomize);
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itemRefesh),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.itemXoa)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // itemRefesh
            // 
            this.itemRefesh.Caption = "Refesh";
            this.itemRefesh.Id = 0;
            this.itemRefesh.ImageOptions.Image = global::DXApplication1.Properties.Resources.Refresh;
            this.itemRefesh.Name = "itemRefesh";
            this.itemRefesh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemRefesh_ItemClick);
            // 
            // itemThem
            // 
            this.itemThem.Caption = "Thêm mới";
            this.itemThem.Id = 1;
            this.itemThem.ImageOptions.Image = global::DXApplication1.Properties.Resources.Add_New;
            this.itemThem.Name = "itemThem";
            this.itemThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemThem_ItemClick);
            // 
            // itemSua
            // 
            this.itemSua.Caption = "Sửa";
            this.itemSua.Id = 2;
            this.itemSua.ImageOptions.Image = global::DXApplication1.Properties.Resources.Edit_Row;
            this.itemSua.Name = "itemSua";
            this.itemSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemSua_ItemClick);
            // 
            // itemXoa
            // 
            this.itemXoa.Caption = "Xóa";
            this.itemXoa.Id = 3;
            this.itemXoa.ImageOptions.Image = global::DXApplication1.Properties.Resources.Trash_Can;
            this.itemXoa.Name = "itemXoa";
            this.itemXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itemXoa_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemRefesh,
            this.itemThem,
            this.itemSua,
            this.itemXoa});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1035, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 378);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1035, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 378);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1035, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 378);
            // 
            // uscMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uscMenu2";
            this.Size = new System.Drawing.Size(1035, 378);
            this.Load += new System.EventHandler(this.uscMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMenu;
        private DevExpress.XtraGrid.Views.Tile.TileView gvMenu;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnRead;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnSender;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnSubject;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnText;
        private DevExpress.XtraGrid.Columns.TileViewColumn columnDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookLoai;
        private DevExpress.XtraGrid.Columns.TileViewColumn colImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem itemRefesh;
        private DevExpress.XtraBars.BarButtonItem itemThem;
        private DevExpress.XtraBars.BarButtonItem itemSua;
        private DevExpress.XtraBars.BarButtonItem itemXoa;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
    }
}
