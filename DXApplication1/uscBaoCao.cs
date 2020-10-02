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
    public partial class uscBaoCao : UserControl
    {
        public uscBaoCao()
        {
            InitializeComponent();
            itemTuNgay.EditValue = DateTime.Now;
            itemDenNgay.EditValue = DateTime.Now;
        }
        MasterDataContext db = new MasterDataContext();
        Color UnreadTextColor = Color.FromArgb(248, 124, 50);
        void LoadData()
        {
            var tuNgay = (DateTime)itemTuNgay.EditValue;
            var denNgay = (DateTime)itemDenNgay.EditValue;
            gcBaoCao.DataSource = db.BaoCao_Select(tuNgay, denNgay);
            chartControl1.DataSource = db.BaoCaoChartBanChay_Select(tuNgay, denNgay);
        }

        private void itemRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void itemThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void itemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void itemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
            lookLoai.DataSource = db.LOAIs;
            lookUsser.DataSource = db.TaiKhoans;
            LoadData();
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STT")
            {
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            }
        }
    }
}
