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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }


        void load_data()
        {
            SqlConnection con = new SqlConnection("server =  vutringoc ; database = ql_banhang; integrated security = true");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_ncc", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();



        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("server =  vutringoc ; database = ql_banhang; integrated security = true");
                SqlCommand cmd = new SqlCommand("insert into tb_ncc values ('" + txtmancc.Text + "', '" + txttenncc.Text + "','" + txtsdt.Text + "','" + txtdiachi.Text + "','" + txtghichu.Text + "') ", con);
                con.Open();
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    load_data();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");

                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Nhap thieu thong tin hoac bi trung");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server =  vutringoc ; database = ql_banhang; integrated security = true");
            SqlCommand cmd = new SqlCommand("update tb_ncc set tenncc =  '" + txttenncc.Text + "', sdt = '" + txtsdt.Text + "', diachi = '" + txtdiachi.Text + "', ghichu = '" + txtghichu.Text + "' where mancc = '" + txtmancc.Text + "' ", con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Cập nhật thành công");
                con.Close();
                load_data();
            }
            
            else
            {
                MessageBox.Show("Cập nhật thất bại");
                con.Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này? ", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("server =  vutringoc ; database = ql_banhang; integrated security = true");
                    SqlCommand cmd = new SqlCommand("delete tb_ncc where mancc = '" + txtmancc.Text + "' ", con);
                    con.Open();
                    int ret = cmd.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("Xóa thành công");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                        con.Close();
                    }
                    load_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Van con ban ghi dang ton tai");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmancc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenncc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtghichu.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_ncc where tenncc = N'" + txttimkiemncc.Text + "'  ", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txtmancc_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtmancc, "Ban phai nhap ma khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void txttenncc_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txttenncc, "Ban phai nhap ma khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void txtdiachi_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtdiachi, "Ban phai nhap ma khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdiachi.Clear();
            txtghichu.Clear();
            txtmancc.Clear();
            txtsdt.Clear();
            txttenncc.Clear();
            txttimkiemncc.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
