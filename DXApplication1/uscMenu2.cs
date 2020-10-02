using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;

namespace DXApplication1
{
    public partial class uscMenu2 : UserControl
    {
        public uscMenu2()
        {
            InitializeComponent();
            barManager1.SetPopupContextMenu(gcMenu, popupMenu1);
        }
        Color UnreadTextColor = Color.FromArgb(248, 124, 50);
        Color red = Color.FromArgb(255, 0, 0);
        Color green = Color.FromArgb(0, 255, 0);
        Color blue = Color.FromArgb(0, 0, 255);

        MasterDataContext db = new MasterDataContext();
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
        private void uscMenu_Load(object sender, EventArgs e)
        {
            try
            {
                lookLoai.DataSource = db.LOAIs;
                LoadData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {

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

        private void itemRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void itemThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMenuEdit frm = new frmMenuEdit();
            frm.ShowDialog();
            LoadData();
        }

        private void itemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvMenu.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Hãy chọn [Món] cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var row = (clsMenu)gvMenu.GetFocusedRow();
                frmMenuEdit frm = new frmMenuEdit();
                frm.ID = (int)gvMenu.GetFocusedRowCellValue("ID");
                frm.objMN_Select = row;
                frm.ShowDialog();
                row = frm.objMN_Select;
                gvMenu.RefreshRow(gvMenu.FocusedRowHandle);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void itemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvMenu.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DialogResult.Yes == XtraMessageBox.Show("Bạn có muốn xóa không?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    var objNK = db.MENUs.SingleOrDefault(p => p.ID == (int)gvMenu.GetFocusedRowCellValue("ID"));
                    db.MENUs.DeleteOnSubmit(objNK);
                    db.SubmitChanges();
                    gvMenu.DeleteSelectedRows();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    public class clsMenu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal GiaBan { get; set; }
        public Image HinhAnh { get; set; }
        public int LoaiID { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
    }
}
