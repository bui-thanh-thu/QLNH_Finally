using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmOrder : DevExpress.XtraBars.TabForm
    {
        public frmOrder()
        {
            InitializeComponent();
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle("");
        }
        MasterDataContext db = new MasterDataContext();
        Color UnreadTextColor = Color.FromArgb(248, 124, 50);
        Color red = Color.FromArgb(255, 0, 0);
        Color green = Color.FromArgb(0, 255, 0);
        Color blue = Color.FromArgb(0, 0, 255);
        public int? BanID { get; set; }
        public int? HDID { get; set; }
        HOADON objHD;
        void LoadData()
        {
            List<clsMenu> lt = new List<clsMenu>();
            foreach (var item in db.Menu_Select())
            {
                try
                {
                    clsMenu m = new clsMenu();
                    m.ID = item.ID;
                    m.Name = item.Name;
                    m.GiaBan = item.GiaBan.GetValueOrDefault();
                    m.LoaiID = item.LoaiID.GetValueOrDefault();
                    m.SoLuong = 0;
                    m.GhiChu = "";
                    if (item.HinhAnh != null)
                    {
                        MemoryStream st = new MemoryStream(item.HinhAnh.ToArray());
                        m.HinhAnh = Image.FromStream(st);
                    }
                    else
                        m.HinhAnh = Image.FromFile(Application.StartupPath + @"\ErrorImage.png");
                    lt.Add(m);
                }
                catch { }
            }
            gcMenu.DataSource = lt;
        }
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
                lookLoai.DataSource = db.LOAIs;
                LoadData();
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
                if (gvMenu.GetCheckedRows().Count() <= 0)
                {
                    XtraMessageBox.Show("Bạn chưa chọn [Món].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (HDID == null)
                {
                    objHD = new HOADON();
                    objHD.BanID = BanID;
                    objHD.NgayHD = DateTime.Now;
                    objHD.IsDaLam = false;
                    objHD.UserID = Properties.Settings.Default.MaNV;
                    db.HOADONs.InsertOnSubmit(objHD);
                    db.SubmitChanges();
                }
                else
                {
                    objHD = db.HOADONs.SingleOrDefault(p => p.ID == HDID);
                    objHD.NgayHD = DateTime.Now;
                }
                //
                foreach (var i in gvMenu.GetCheckedRows())
                {
                    var objCT = new CHITIETHOADON();
                    objCT.HDID = objHD.ID;
                    objCT.DonGia = (decimal)gvMenu.GetRowCellValue(i, "GiaBan");
                    objCT.MenuID = (int)gvMenu.GetRowCellValue(i, "ID");
                    objCT.SoLuong = (int)gvMenu.GetRowCellValue(i, "SoLuong");
                    objCT.GhiChu = gvMenu.GetRowCellValue(i, "GhiChu").ToString();
                    db.CHITIETHOADONs.InsertOnSubmit(objCT);
                }
                //
                if (HDID == null)
                {
                    var objBan = db.BANs.SingleOrDefault(p => p.ID == BanID);
                    objBan.HDID = objHD.ID;
                    objBan.MaTT = 2;
                }
                db.SubmitChanges();
                XtraMessageBox.Show("Đã lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gvMenu_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            var l = gvMenu.GetRowCellValue(e.RowHandle, columnRead);
            switch ((int)l)
            {
                case 1:
                    e.Item["LoaiID"].Appearance.Normal.BackColor = red;
                    e.Item["GiaBan"].Appearance.Normal.ForeColor = red;
                    e.Item["Name"].Appearance.Normal.ForeColor = red;
                    e.Item["Name"].Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                    break;
                case 2:
                    e.Item["LoaiID"].Appearance.Normal.BackColor = green;
                    e.Item["GiaBan"].Appearance.Normal.ForeColor = green;
                    e.Item["Name"].Appearance.Normal.ForeColor = green;
                    e.Item["Name"].Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                    break;
                case 3:
                    e.Item["LoaiID"].Appearance.Normal.BackColor = blue;
                    e.Item["GiaBan"].Appearance.Normal.ForeColor = blue;
                    e.Item["Name"].Appearance.Normal.ForeColor = blue;
                    e.Item["Name"].Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                    break;
            }
        }

        private void gvMenu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvMenu.GetCheckedRows().Contains(gvMenu.FocusedRowHandle))
                {
                    var a = (int)gvMenu.GetFocusedRowCellValue("SoLuong") + 1;
                    gvMenu.SetFocusedRowCellValue("SoLuong", a);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGhiChu_Click(object sender, EventArgs e)
        {
            if (gvMenu.GetCheckedRows().Contains(gvMenu.FocusedRowHandle))
            {
                var result = XtraInputBox.Show("Nhập nội dung", "Ghi Chú", "");
                gvMenu.SetFocusedRowCellValue("GhiChu", result);
            }
        }
    }
}
