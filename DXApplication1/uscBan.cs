using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class uscBan : UserControl
    {
        public uscBan()
        {
            InitializeComponent();
        }
        MasterDataContext db = new MasterDataContext();
        void LoadData()
        {
            gcMenu.DataSource = db.BANs;
        }
        private void uscMenu_Load(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            db.SubmitChanges();
            LoadData();
        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            db.SubmitChanges();
            LoadData();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvBan.SetFocusedRowCellValue("MaTT", 0);
        }
    }
}
