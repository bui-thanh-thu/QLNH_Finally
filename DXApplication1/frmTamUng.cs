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
using System.Data.Linq.SqlClient;

namespace DXApplication1
{
    public partial class frmTamUng : DevExpress.XtraBars.TabForm
    {
        public frmTamUng()
        {
            InitializeComponent();
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle("");
        }
        MasterDataContext db = new MasterDataContext();
        public int? ID { get; set; }
        NHANVIEN objNV;
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
                objNV = db.NHANVIENs.SingleOrDefault(p => p.ID == ID);
                dateNgayNhap.EditValue = DateTime.Now;
                switch (objNV.DonViTinh.GetValueOrDefault())
                {
                    case 0:
                        spinLuongHT.EditValue = (db.BangCongs.Where(p => p.BatDau.GetValueOrDefault().Year == DateTime.Now.Year && p.BatDau.GetValueOrDefault().Month == DateTime.Now.Month && p.NVID == ID).Sum(p => SqlMethods.DateDiffHour(p.BatDau, p.KetThuc)).GetValueOrDefault() * objNV.MucLuong.GetValueOrDefault()) - db.BangLuongs.Where(p => p.NgayLuong.GetValueOrDefault().Year == DateTime.Now.Year && p.NgayLuong.GetValueOrDefault().Month == DateTime.Now.Month && p.NVID == ID).Sum(p => p.SoTien.GetValueOrDefault());
                        break;
                    case 1:
                        spinLuongHT.EditValue = (db.BangCongs.Where(p => p.BatDau.GetValueOrDefault().Year == DateTime.Now.Year && p.BatDau.GetValueOrDefault().Month == DateTime.Now.Month && p.NVID == ID).Count() * objNV.MucLuong.GetValueOrDefault()) - db.BangLuongs.Where(p => p.NgayLuong.GetValueOrDefault().Year == DateTime.Now.Year && p.NgayLuong.GetValueOrDefault().Month == DateTime.Now.Month && p.NVID == ID).Sum(p => p.SoTien.GetValueOrDefault());
                        break;
                    case 2:
                        spinLuongHT.EditValue = (db.BangCongs.Where(p => p.BatDau.GetValueOrDefault().Year == DateTime.Now.Year && p.BatDau.GetValueOrDefault().Month == DateTime.Now.Month && p.NVID == ID).Count() * (objNV.MucLuong.GetValueOrDefault() / 30)) - db.BangLuongs.Where(p => p.NgayLuong.GetValueOrDefault().Year == DateTime.Now.Year && p.NgayLuong.GetValueOrDefault().Month == DateTime.Now.Month && p.NVID == ID).Sum(p => p.SoTien.GetValueOrDefault());
                        break;
                    default:
                        break;
                }
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
                if (spinSoTien.Value <= 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Số tiền ứng].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var objTU = new BangLuong();
                objTU.GhiChu = txtHangNhap.Text;
                objTU.NgayLuong = dateNgayNhap.DateTime;
                objTU.NVID = ID;
                objTU.SoTien = spinSoTien.Value;
                db.BangLuongs.InsertOnSubmit(objTU);
                db.SubmitChanges();
                XtraMessageBox.Show("Hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
