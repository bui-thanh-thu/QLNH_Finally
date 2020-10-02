using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace DXApplication1
{
    public partial class ucHoaDon : UserControl
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=DB_QLNH;Integrated Security=True";
        public ucHoaDon()
        {
            InitializeComponent();
            loadListView();
        }
        public void loadListView()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("HoaDon_Select", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lsvHoaDon.Items.Clear();
            lsvHoaDon.View = View.Details;
            lsvHoaDon.GridLines = true;

            lsvHoaDon.FullRowSelect = true;
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                lsvHoaDon.Items.Add(dr["ID"].ToString());
                lsvHoaDon.Items[i].SubItems.Add(dr["NgayHD"].ToString());
                lsvHoaDon.Items[i].SubItems.Add(dr["Username"].ToString());
                i++;
            }


        }

        private void lsvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < lsvHoaDon.Items.Count; i++)
            {
                if (lsvHoaDon.Items[i].Selected)
                {
                    ListViewItem item = lsvHoaDon.SelectedItems[0];
                    string p_HDID = item.SubItems[0].Text;
                    SqlConnection conn = new SqlConnection(connect);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("CTHD_Select3", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("HDID", SqlDbType.NVarChar, 50).Value = p_HDID;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    lsvCTHD.Items.Clear();
                    lsvCTHD.View = View.Details;
                    lsvCTHD.GridLines = true;

                    lsvCTHD.FullRowSelect = true;
                    int index = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        lbMaHD.Text ="Mã hóa đơn: " + dr["ID"].ToString();
                        lsvCTHD.Items.Add(dr["Name"].ToString());
                        lsvCTHD.Items[index].SubItems.Add(dr["SoLuong"].ToString());
                        lsvCTHD.Items[index].SubItems.Add(dr["DonGia"].ToString());
                        lsvCTHD.Items[index].SubItems.Add(dr["Thành tiền"].ToString());
                        index++;
                    }
                  //  TongTien();

                }

            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            loadListView();
        }
        //public void TongTien()
        //{
        //    float tong = 0;
        //    int n = lsvCTHD.Items.Count - 1;
        //    for (int i = 0; i< n; i++)
        //    {
        //        string p = lsvCTHD.Items[i].SubItems["Thành Tiền"].ToString();
        //        tong += float.Parse(p);
        //    }
        //    lbTongtien.Text = tong.ToString();
        //}
    }
}
