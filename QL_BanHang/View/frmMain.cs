using QL_BanHang.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_BanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
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
        private void frmMain_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_nhanvien",con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            cbmanv.DataSource = dt;
           
            cbmanv.ValueMember = "manv";
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to logout", "thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Close();

            }
        }

        //private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult r;
        //    r = MessageBox.Show("Do you want to logout?", "Exit",
        //    MessageBoxButtons.YesNo,
        //    MessageBoxIcon.Question,
        //    MessageBoxDefaultButton.Button1);
        //    if (r == DialogResult.No)
        //        e.Cancel = true;
        //}

        private void gửiPhảnHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n7 = new frmtrogiup();
            n7.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("server =  vutringoc ; database = ql_banhang; integrated security = true");
                SqlCommand cmd = new SqlCommand("insert into tb_chamcong1 values('" + datechamcong.Text + "', '" + cbmanv.Text + "') ", con);
                con.Open();
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Chấm công thành công");
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ban da cham cong hom nay");
            }
           
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmtrogiup help = new frmtrogiup();
            //help.Show();
        }
    }
}
