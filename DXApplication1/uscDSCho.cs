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
    public partial class uscDSCho : UserControl
    {
        public uscDSCho()
        {
            InitializeComponent();
            barManager1.SetPopupContextMenu(gcBan, popupMenu3);
            //barManager1.SetPopupContextMenu(gcCTHD, popupMenu2);
        }
        Color UnreadTextColor = Color.FromArgb(248, 124, 50);
        Color red = Color.FromArgb(255, 0, 0);
        Color green = Color.FromArgb(0, 255, 0);
        Color blue = Color.FromArgb(0, 0, 255);

        MasterDataContext db = new MasterDataContext();
        void LoadData()
        {
            var index = gvBan.FocusedRowHandle;
            gcBan.DataSource = db.DSCho_Select();
            gvBan.FocusedRowHandle = index;
        }
        void LoadCTHD(int HDID)
        {
            try
            {
                gcCTHD.DataSource = db.CTHD_Select2(HDID);
            }
            catch { }
        }
        private void uscMenu_Load(object sender, EventArgs e)
        {
            try
            {
                lookLoai2.DataSource = db.LOAIs;
                LoadData();
                gvBan.FocusedRowHandle = 0;
                if (gvBan.GetFocusedRowCellValue("HDID") != null)
                    LoadCTHD((int)gvBan.GetFocusedRowCellValue("HDID"));
                timer1.Start();
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

        }

        private void itemRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void itemThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEditBan frm = new frmEditBan();
            frm.ShowDialog();
            LoadData();
        }

        private void itemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvBan.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Hãy chọn [Bàn] cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmEditBan frm = new frmEditBan();
                frm.ID = (int)gvBan.GetFocusedRowCellValue("ID");
                frm.ShowDialog();
                LoadData();
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
                if (gvBan.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DialogResult.Yes == XtraMessageBox.Show("Bạn có muốn xóa không?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    var objNK = db.BANs.SingleOrDefault(p => p.ID == (int)gvBan.GetFocusedRowCellValue("ID"));
                    db.BANs.DeleteOnSubmit(objNK);
                    db.SubmitChanges();
                    gvBan.DeleteSelectedRows();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gvBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gvBan.GetFocusedRowCellValue("HDID") == null)
                {
                    gcCTHD.DataSource = null;
                    return;
                }
                LoadCTHD((int)gvBan.GetFocusedRowCellValue("HDID"));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gvCTHD_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            try
            {
                var l = gvCTHD.GetRowCellValue(e.RowHandle, tileViewColumn3);
                switch ((int)l)
                {
                    case 1:
                        e.Item["LoaiID"].Appearance.Normal.BackColor = red;
                        e.Item["SoLuong"].Appearance.Normal.ForeColor = red;
                        e.Item["ThanhTien"].Appearance.Normal.ForeColor = red;
                        break;
                    case 2:
                        e.Item["LoaiID"].Appearance.Normal.BackColor = green;
                        e.Item["SoLuong"].Appearance.Normal.ForeColor = green;
                        e.Item["ThanhTien"].Appearance.Normal.ForeColor = green;
                        break;
                    case 3:
                        e.Item["LoaiID"].Appearance.Normal.BackColor = blue;
                        e.Item["SoLuong"].Appearance.Normal.ForeColor = blue;
                        e.Item["ThanhTien"].Appearance.Normal.ForeColor = blue;
                        break;
                }
            }
            catch { }
        }

        private void itemOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvBan.GetFocusedRowCellValue("ID") == null)
            {
                XtraMessageBox.Show("Hãy chọn [Bàn] cần order.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmOrder frm = new frmOrder();
            frm.BanID = (int)gvBan.GetFocusedRowCellValue("ID");
            frm.HDID = (int?)gvBan.GetFocusedRowCellValue("HDID");
            frm.ShowDialog();
            LoadData();
        }

        private void itemThemMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvBan.GetFocusedRowCellValue("ID") == null)
            {
                XtraMessageBox.Show("Hãy chọn [Bàn] cần order.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmOrder frm = new frmOrder();
            frm.BanID = (int)gvBan.GetFocusedRowCellValue("ID");
            frm.HDID = (int?)gvBan.GetFocusedRowCellValue("HDID");
            frm.ShowDialog();
            LoadData();
        }

        private void itemXoaMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvCTHD.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DialogResult.Yes == XtraMessageBox.Show("Bạn có muốn xóa không?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    var objNK = db.CHITIETHOADONs.SingleOrDefault(p => p.ID == (int)gvCTHD.GetFocusedRowCellValue("ID"));
                    db.CHITIETHOADONs.DeleteOnSubmit(objNK);
                    db.SubmitChanges();
                    gvCTHD.DeleteSelectedRows();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void itemEditMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvCTHD.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Hãy chọn [Dòng] cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmEditCTHD frm = new frmEditCTHD();
                frm.ID = (int)gvCTHD.GetFocusedRowCellValue("ID");
                frm.ShowDialog();
                LoadCTHD((int)gvBan.GetFocusedRowCellValue("HDID"));
            }
            catch
            {

            }
        }

        private void itemTinhTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvBan.GetFocusedRowCellValue("ID") == null)
            {
                XtraMessageBox.Show("Hãy chọn [Bàn] cần tính tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gvBan.GetFocusedRowCellValue("HDID") == null) return;
            frmTinhTien frm = new frmTinhTien((int)gvBan.GetFocusedRowCellValue("HDID"));
            frm.TenBan = "Bàn: " + gvBan.GetFocusedRowCellValue("FullName");
            frm.ShowDialog();
            if (frm.IsOk)
            {
                var objBan = db.BANs.SingleOrDefault(p => p.ID == (int)gvBan.GetFocusedRowCellValue("ID"));
                objBan.MaTT = 1;
                objBan.HDID = null;
                db.SubmitChanges();
                LoadData();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                //gvBan.FocusedRowHandle = 0;
                if (gvBan.GetFocusedRowCellValue("HDID") != null)
                    LoadCTHD((int)gvBan.GetFocusedRowCellValue("HDID"));
            }
            catch
            {

            }
        }

        private void itemNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                db.Update_HD((int)gvBan.GetRowCellValue(0, "HDID"));
                gvBan.DeleteRow(0);
                gvBan.FocusedRowHandle = 0;
                if (gvBan.GetFocusedRowCellValue("HDID") != null)
                    LoadCTHD((int)gvBan.GetFocusedRowCellValue("HDID"));
            }
            catch
            {


            }

        }
    }
}
