using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmBangLuong : DevExpress.XtraBars.TabForm
    {
        public frmBangLuong()
        {
            InitializeComponent();
            foreach (var item in db.BangCongs.OrderBy(p => p.BatDau.GetValueOrDefault()).Select(p => new { p.BatDau.GetValueOrDefault().Year }).GroupBy(p => p.Year))
            {
                cbmNam.Items.Add(item.Key.ToString());
            }
            itemNam.EditValue = db.BangCongs.OrderBy(p => p.BatDau.GetValueOrDefault()).Select(p => new { p.BatDau.GetValueOrDefault().Year }).GroupBy(p => p.Year).ToList()[0].Key;
            itemThang.EditValue = 1;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle("");
        }
        MasterDataContext db = new MasterDataContext();
        public int? ID { get; set; }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        void LoadData()
        {
            try
            {
                var thang = itemThang.EditValue;
                var nam = itemNam.EditValue;
                if (thang == null || nam == null)
                    return;
                DateTime tuNgay = new DateTime(int.Parse(nam.ToString()), int.Parse(thang.ToString()), 1);
                gcLichSuDiLam.DataSource = db.LichSuDiLam2_Select(ID, tuNgay);
                gcLichSuTraLuong.DataSource = db.LichSuTamUng2_Select(ID, tuNgay);
                itemCaption.Caption = string.Format("Lương thực nhận: {0:n0}", ((decimal)(gridColumn1.SummaryItem.SummaryValue == null ? 0 : gridColumn1.SummaryItem.SummaryValue) - (decimal)(gridColumn18.SummaryItem.SummaryValue == null ? 0 : gridColumn18.SummaryItem.SummaryValue)));
            }
            catch (Exception ex) { }
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void itemNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void itemThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void itemThanhToanLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (db.LichSuTraLuongs.Where(p => p.ThangTra.GetValueOrDefault() == int.Parse(itemThang.EditValue.ToString()) && p.NamTra.GetValueOrDefault() == int.Parse(itemNam.EditValue.ToString())).Count() > 0)
                {
                    XtraMessageBox.Show("Tháng này đã được trả lương.Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var objLS = new LichSuTraLuong();
                objLS.GhiChu = txtGhiChu.Text;
                objLS.NamTra = int.Parse(itemNam.EditValue.ToString());
                objLS.NgayTra = DateTime.Now;
                objLS.NVID = ID;
                objLS.SoTien = (decimal)(gridColumn1.SummaryItem.SummaryValue == null ? 0 : gridColumn1.SummaryItem.SummaryValue);
                objLS.TamUng = (decimal)(gridColumn18.SummaryItem.SummaryValue == null ? 0 : gridColumn18.SummaryItem.SummaryValue);
                objLS.ThangTra = int.Parse(itemThang.EditValue.ToString());
                objLS.ThucNhan = objLS.SoTien - objLS.TamUng;
                db.LichSuTraLuongs.InsertOnSubmit(objLS);
                db.SubmitChanges();
                XtraMessageBox.Show("Đã lưu dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) { }
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
    }
}
