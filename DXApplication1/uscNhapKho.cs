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

namespace DXApplication1
{
    public partial class uscNhapKho : UserControl
    {
        public uscNhapKho()
        {
            InitializeComponent();
            itemTuNgay.EditValue = DateTime.Now.AddDays(-7);
            itemDenNgay.EditValue = DateTime.Now;
        }
        MasterDataContext db = new MasterDataContext();
        Color UnreadTextColor = Color.FromArgb(248, 124, 50);
        void LoadData()
        {
            var tuNgay = (DateTime)itemTuNgay.EditValue;
            var denNgay = (DateTime)itemDenNgay.EditValue;
            gcNhapKho.DataSource = db.NhapKho_Select(tuNgay, denNgay, Properties.Settings.Default.MaNV);
        }

        private void itemRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void itemThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapKho frm = new frmNhapKho();
            frm.ShowDialog();
            LoadData();
        }

        private void itemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhapKho.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var row = (NhapKho_SelectResult)gvNhapKho.GetFocusedRow();
                frmNhapKho frm = new frmNhapKho();
                frm.ID = (int)gvNhapKho.GetFocusedRowCellValue("ID");
                frm.objNK_Select = row;
                frm.ShowDialog();
                row = frm.objNK_Select;
                gvNhapKho.RefreshRow(gvNhapKho.FocusedRowHandle);
            }
            catch { }
        }

        private void itemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gvNhapKho.GetFocusedRowCellValue("ID") == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(DialogResult.Yes == XtraMessageBox.Show("Bạn có muốn xóa không?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    var objNK = db.NHAPKHOs.SingleOrDefault(p => p.ID == (int)gvNhapKho.GetFocusedRowCellValue("ID"));
                    db.NHAPKHOs.DeleteOnSubmit(objNK);
                    db.SubmitChanges();
                    gvNhapKho.DeleteSelectedRows();
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
    }
}
