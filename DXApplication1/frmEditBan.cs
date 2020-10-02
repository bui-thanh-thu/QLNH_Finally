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
    public partial class frmEditBan : DevExpress.XtraBars.TabForm
    {
        public frmEditBan()
        {
            InitializeComponent();
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle("");
        }
        MasterDataContext db = new MasterDataContext();
        public int? ID { get; set; }
        BAN objNK;
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
                    objNK = new BAN();
                }
                else
                {
                    objNK = db.BANs.SingleOrDefault(p => p.ID == ID);
                    txtKhu.Text = objNK.Name;
                    spinSoBan.EditValue = objNK.Number;
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
                if (txtKhu.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Khu].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (spinSoBan.Value <= 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập [Số bàn].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                objNK.Name = txtKhu.Text;
                objNK.Number = (int)spinSoBan.Value;
                if (ID == null)
                {
                    objNK.MaTT = 1;
                    db.BANs.InsertOnSubmit(objNK);
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
    }
}
