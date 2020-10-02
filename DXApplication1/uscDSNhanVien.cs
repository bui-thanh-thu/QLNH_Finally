using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Linq.SqlClient;

namespace DXApplication1
{
    public partial class uscDSNhanVien : UserControl
    {
        public uscDSNhanVien()
        {
            InitializeComponent();
        }
        MasterDataContext db = new MasterDataContext();
        Color UnreadTextColor = Color.FromArgb(248, 124, 50);
        void LoadData()
        {
            gcNhanVien.DataSource = db.NhanVien_Select();
        }
        void LoadDetail()
        {
            var NVID = (int?)gvNhanVien.GetFocusedRowCellValue("ID");
            if (NVID == null)
            {
                gcLichSuDiLam.DataSource = null;
                gcLichSuTraLuong.DataSource = null;
            }
            else
            {
                switch (xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0:
                        gcLichSuDiLam.DataSource = db.LichSuDiLam_Select(NVID);
                        break;
                    case 1:
                        gcLichSuTraLuong.DataSource = db.LichSuTamUng_Select(NVID);
                        break;
                    case 2:
                        gcLSTL.DataSource = db.LichSuTraLuong_Select(NVID);
                        break;
                    default:
                        break;
                }
            }
        }
        private void itemRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void itemThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
            LoadData();
        }

        private void itemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhanVien.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmNhanVien frm = new frmNhanVien();
                frm.ID = (int)gvNhanVien.GetFocusedRowCellValue("ID");
                frm.ShowDialog();
                LoadData();
            }
            catch { }
        }

        private void itemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhanVien.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DialogResult.Yes == XtraMessageBox.Show("Bạn có muốn xóa không?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    var objNK = db.NHANVIENs.SingleOrDefault(p => p.ID == (int)gvNhanVien.GetFocusedRowCellValue("ID"));
                    db.NHANVIENs.DeleteOnSubmit(objNK);
                    db.SubmitChanges();
                    gvNhanVien.DeleteSelectedRows();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gvNhapKho_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            e.Item["IsRead"].Appearance.Normal.BackColor = UnreadTextColor;
            //e.Item["TienNhap"].Appearance.Normal.ForeColor = UnreadTextColor;
            //e.Item["Name"].Appearance.Normal.ForeColor = UnreadTextColor;
            //e.Item["NgayNhap"].Appearance.Normal.ForeColor = UnreadTextColor;
            e.Item["Sender"].Appearance.Normal.ForeColor = UnreadTextColor;
            //e.Item["Name"].Appearance.Normal.FontStyleDelta = FontStyle.Bold;
        }

        private void uscNhapKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvNhapKho_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STT")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }

        private void gvNhanVien_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STT")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }

        private void itemCheckin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhanVien.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần [Check In].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((bool?)gvNhanVien.GetFocusedRowCellValue("IsDangLam") != true)
                {
                    XtraMessageBox.Show("Nhân viên này đã nghĩ việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (db.BangCongs.FirstOrDefault(p => p.NVID == (int)gvNhanVien.GetFocusedRowCellValue("ID") && SqlMethods.DateDiffDay(p.BatDau.GetValueOrDefault(), DateTime.Now) == 0) != null)
                {
                    XtraMessageBox.Show("Nhân viên này đã [Check In].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                args.Caption = "CHECK IN";
                args.Prompt = "Chọn thời gian";
                args.DefaultButtonIndex = 0;
                //
                DateEdit lookBan = new DateEdit();
                lookBan.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
                //
                args.Editor = lookBan;
                args.DefaultResponse = DateTime.Now;
                //
                var result = XtraInputBox.Show(args).ToString();
                var result1 = XtraInputBox.Show("Nhập nội dung", "Ghi Chú", "");
                var objBC = new BangCong();
                objBC.BatDau = DateTime.Parse(result);
                objBC.NVID = (int)gvNhanVien.GetFocusedRowCellValue("ID");
                objBC.GhiChu = result1;
                db.BangCongs.InsertOnSubmit(objBC);
                db.SubmitChanges();
                XtraMessageBox.Show("Hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDetail();
            }
            catch { }
        }

        private void itemCheckout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhanVien.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần [Check Out].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((bool?)gvNhanVien.GetFocusedRowCellValue("IsDangLam") != true)
                {
                    XtraMessageBox.Show("Nhân viên này đã nghĩ việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var objBC = db.BangCongs.FirstOrDefault(p => p.NVID == (int)gvNhanVien.GetFocusedRowCellValue("ID") && SqlMethods.DateDiffDay(p.BatDau.GetValueOrDefault(), DateTime.Now) == 0);
                if (objBC == null)
                {
                    XtraMessageBox.Show("Nhân viên này chưa [Check In].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    XtraInputBoxArgs args = new XtraInputBoxArgs();
                    // set required Input Box options 
                    args.Caption = "CHECK IN";
                    args.Prompt = "Chọn thời gian";
                    args.DefaultButtonIndex = 0;
                    //
                    DateEdit lookBan = new DateEdit();
                    lookBan.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
                    //
                    args.Editor = lookBan;
                    args.DefaultResponse = DateTime.Now;
                    //
                    var result = XtraInputBox.Show(args).ToString();
                    var result1 = XtraInputBox.Show("Nhập nội dung", "Ghi Chú", objBC.GhiChu);
                    objBC.KetThuc = DateTime.Parse(result);
                    objBC.GhiChu = result1;
                }
                db.SubmitChanges();
                XtraMessageBox.Show("Hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDetail();
            }
            catch { }
        }

        private void itemNghiViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhanVien.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((bool?)gvNhanVien.GetFocusedRowCellValue("IsDangLam") != true)
                {
                    XtraMessageBox.Show("Nhân viên này đã nghĩ việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var objNK = db.NHANVIENs.SingleOrDefault(p => p.ID == (int)gvNhanVien.GetFocusedRowCellValue("ID"));
                objNK.IsDangLam = false;
                objNK.NgayNghiViec = DateTime.Now;
                db.SubmitChanges();
                LoadData();
            }
            catch { }
        }

        private void gvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadDetail();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            LoadDetail();
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STT")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }

        private void gridView2_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STT")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }

        private void itemTamUng_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhanVien.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((bool?)gvNhanVien.GetFocusedRowCellValue("IsDangLam") != true)
                {
                    XtraMessageBox.Show("Nhân viên này đã nghĩ việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmTamUng frm = new frmTamUng();
                frm.ID = (int)gvNhanVien.GetFocusedRowCellValue("ID");
                frm.ShowDialog();
                LoadDetail();
            }
            catch { }
        }

        private void itemDiLamLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhanVien.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((bool?)gvNhanVien.GetFocusedRowCellValue("IsDangLam") == true)
                {
                    XtraMessageBox.Show("Nhân viên này đang đi làm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var objNK = db.NHANVIENs.SingleOrDefault(p => p.ID == (int)gvNhanVien.GetFocusedRowCellValue("ID"));
                objNK.IsDangLam = true;
                objNK.NgayNghiViec = null;
                objNK.NgayVaoLam = DateTime.Now;
                db.SubmitChanges();
                LoadData();
            }
            catch { }
        }

        private void itemBangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhanVien.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((bool?)gvNhanVien.GetFocusedRowCellValue("IsDangLam") != true)
                {
                    XtraMessageBox.Show("Nhân viên này đã nghĩ việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBangLuong frm = new frmBangLuong();
                frm.ID = (int)gvNhanVien.GetFocusedRowCellValue("ID");
                frm.ShowDialog();
                LoadDetail();
            }
            catch { }
        }

        private void gridView3_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STT")
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
        }
    }
}
