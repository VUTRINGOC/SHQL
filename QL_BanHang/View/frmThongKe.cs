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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
                SqlDataAdapter da = new SqlDataAdapter("select NgayLap,  dongia ,soluong from tb_CTHD, tb_HoaDon where tb_HoaDon.MAHD = tb_CTHD.MAHD and  year(NgayLap)= '" + cbyear.Text + "'  and month(NgayLap) = '"+ cbmonth.Text + "' ", con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();

                label10.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label10.Text = Convert.ToString(int.Parse(label10.Text) + (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString())));
                }



        }


        private void thongke2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select tenhang ,soluong, ngaynhap from tb_hanghoa where year(Ngaynhap)= '" + txtnam2.Text + "'  and month(NgayNhap) = '" + txtthang2.Text + "' and tenhang = '"+cbname.Text+"'", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
            con.Close();

            label7.Text = "0";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                label7.Text = Convert.ToString(int.Parse(label7.Text) + int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString()) );
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = QL_BanHang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_hanghoa", con );
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            cbname.DataSource = dt;
            cbname.ValueMember = "TenHang";
            con.Close();

        }
    }
}
