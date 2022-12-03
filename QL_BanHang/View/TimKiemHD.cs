using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_BanHang.View
{
    public partial class TimKiemHD : Form
    {
        public TimKiemHD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select mahd, NgayLap, nguoilap, khachhang from tb_hoadon where khachhang = '" + txttimkiemten.Text + "' ", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


            SqlConnection con1 = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
            SqlDataAdapter da1 = new SqlDataAdapter("select tb_cthd.mahd, mahh, tb_cthd.soluong, tb_cthd.dongia from tb_cthd, tb_hoadon, tb_hanghoa  where tb_cthd.mahd = tb_hoadon.mahd and tb_cthd.mahh = tb_hanghoa.mahang and  khachhang = '" + txttimkiemten.Text + "' ", con1);
            DataTable dt1 = new DataTable();
            con1.Open();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            con1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select mahd, NgayLap, nguoilap, khachhang from tb_hoadon where mahd = '" + txttimkiemmhd.Text + "' ", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


            SqlConnection con1 = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
            SqlDataAdapter da1 = new SqlDataAdapter("select tb_cthd.mahd, tb_hanghoa.tenhang, tb_cthd.soluong, tb_cthd.dongia from tb_cthd, tb_hoadon, tb_hanghoa  where tb_cthd.mahd = tb_hoadon.mahd and tb_cthd.mahh = tb_hanghoa.mahang and tb_cthd.mahd  = '" + txttimkiemmhd.Text + "' ", con1);
            DataTable dt1 = new DataTable();
            con1.Open();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            con1.Close();


            label1.Text = "0";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        frmHoaDon frhd = new frmHoaDon();
        private void TimKiemHD_Load(object sender, EventArgs e)
        {
            
            
            SqlConnection con2 = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
            SqlDataAdapter da2 = new SqlDataAdapter("select mahd, NgayLap, nguoilap, khachhang from tb_hoadon where mahd = '" + frhd.txtMa.Text + "' ", con2);
            DataTable dt2 = new DataTable();
            con2.Open();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con2.Close();


            SqlConnection con3 = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
            SqlDataAdapter da3 = new SqlDataAdapter("select tb_cthd.mahd, tb_hanghoa.tenhang, tb_cthd.soluong, tb_cthd.dongia from tb_cthd, tb_hoadon, tb_hanghoa  where tb_cthd.mahd = tb_hoadon.mahd and tb_cthd.mahh = tb_hanghoa.mahang and tb_cthd.mahd  = '" + frhd.txtMa.Text + "' ", con3);
            DataTable dt3 = new DataTable();
            con3.Open();
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;
            con3.Close();


            label1.Text = "0";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()));
            }

        }
    }
}
