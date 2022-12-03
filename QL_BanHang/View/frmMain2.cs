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
    public partial class frmMain2 : Form
    {
        public frmMain2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form n1 = new frmHangHoa();
            n1.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form n2 = new frmHoaDon();
            n2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form n3 = new frmKhachHang();
            n3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            Form n4 = new frmNhanVien();
            n4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form n5 = new frmThongKe();
            n5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form n6 = new frmNhaCungCap();
            n6.Show();
        }

        private void frmMain2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select tb_NhanVien.MaNV, tb_NhanVien.TenNV, count (ngaychamcong) as 'Số chấm công' from tb_NhanVien, tb_chamcong1 where tb_NhanVien.MaNV = tb_chamcong1.manv and month(ngaychamcong) = month(getdate()) and year(ngaychamcong) = year(getdate()) group by tb_NhanVien.MaNV, tb_NhanVien.TenNV", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n1 = new frmHangHoa();
            n1.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n2 = new frmHoaDon();
            n2.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n3 = new frmKhachHang();
            n3.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n5 = new frmThongKe();
            n5.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n6 = new frmNhaCungCap();
            n6.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form n4 = new frmNhanVien();
            n4.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to logout", "thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void gửiPhảnHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n7 = new frmtrogiup();
            n7.Show();
        }

        //private void frmMain2_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult r;
        //    r = MessageBox.Show("Do you want to logout?", "Exit",
        //    MessageBoxButtons.YesNo,
        //    MessageBoxIcon.Question,
        //    MessageBoxDefaultButton.Button1);
        //    if (r == DialogResult.No)
        //        e.Cancel = true;
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select tb_NhanVien.MaNV, tb_NhanVien.TenNV, count (ngaychamcong) as 'Số chấm công' from tb_NhanVien, tb_chamcong1 where tb_NhanVien.MaNV = tb_chamcong1.manv and month(ngaychamcong) = '" + cbmonth.Text+ "' and year(ngaychamcong) = '"+cbnam.Text+"'   group by tb_NhanVien.MaNV, tb_NhanVien.TenNV", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form n5 = new frmThongKe();
            n5.Show();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n6 = new frmNhaCungCap();
            n6.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n4 = new frmNhanVien();
            n4.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

