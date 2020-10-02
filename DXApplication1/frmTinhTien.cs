using DevExpress.LookAndFeel;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmTinhTien : Form
    {
        public frmTinhTien(int HDID)
        {
            InitializeComponent();
            MasterDataContext db = new MasterDataContext();
            gridControl1.DataSource = db.CTHD_Select(HDID);
        }
        public bool IsOk = false;
        public string TenBan { get; set; }

        void PreviewPrintableComponent(IPrintable component, UserLookAndFeel lookAndFeel)
        {
            PrintableComponentLink link = new PrintableComponentLink()
            {
                //MonarchEnvelope
                PrintingSystemBase = new PrintingSystemBase(),
                Component = component,
                Landscape = false,
                PaperKind = PaperKind.PersonalEnvelope,
                Margins = new Margins(2, 2, 2, 2)
            };
            link.CreateReportHeaderArea += link_CreateReportHeaderArea;
            link.ShowRibbonPreview(lookAndFeel);
        }
        private void link_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string reportHeader = "PHIẾU THANH TOÁN\n";
            reportHeader += TenBan + "            Ngày HĐ:" + string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            //if (xtraTabControl1.SelectedTabPageIndex == 2)
            //    reportHeader += " - Ngày sinh: " + gvCaNhan.GetFocusedRowCellValue("NgaySinh").ToString();
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PreviewPrintableComponent(gridControl1, gridControl1.LookAndFeel);
            IsOk = true;
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            IsOk = false;
            this.Close();
        }
    }
}
