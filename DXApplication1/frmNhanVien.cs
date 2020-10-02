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
    public partial class frmNhanVien : DevExpress.XtraBars.TabForm
    {
        public frmNhanVien()
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
                if (ID == null)
                {
                    dateNgayVaoLam.EditValue = DateTime.Now;
                    objNV = new NHANVIEN();
                    objNV.IsDangLam = true;
                }
                else
                {
                    objNV = db.NHANVIENs.SingleOrDefault(p => p.ID == ID);
                    dateNgayVaoLam.EditValue = objNV.NgayVaoLam.GetValueOrDefault();
                    txtHoTen.Text = objNV.HoTen;
                    txtDiaChi.Text = objNV.DiaChi;
                    txtSDT.Text = objNV.DienThoai;
                    spinTuoi.EditValue = objNV.Age;
                    spinMucLuong.EditValue = objNV.MucLuong.GetValueOrDefault();
                    cbmCachTinh.SelectedIndex = objNV.DonViTinh.GetValueOrDefault();
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
                if (txtHoTen.Text == "" || txtSDT.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Họ tên hoặc Số điện thoại].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (spinMucLuong.Value <= 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Mức lương].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                objNV.DiaChi = txtDiaChi.Text;
                objNV.NgayVaoLam = dateNgayVaoLam.DateTime;
                objNV.HoTen = txtHoTen.Text;
                objNV.MucLuong = spinMucLuong.Value;
                objNV.Age = (int)spinTuoi.Value;
                objNV.DienThoai = txtSDT.Text;
                objNV.DonViTinh = cbmCachTinh.SelectedIndex;
                if (ID == null)
                    db.NHANVIENs.InsertOnSubmit(objNV);
                db.SubmitChanges();
                XtraMessageBox.Show("Đã lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
