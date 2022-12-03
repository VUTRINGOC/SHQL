using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_BanHang.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "nhanvien" && txtmk.Text == "12345")
            {
                MessageBox.Show("Dang nhap thanh cong");
                Form dnmain = new frmMain();
                dnmain.Show();
                
            }
            else
            {
                MessageBox.Show("Thong tin tai khoan mat khau khong chinh xac");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == "quanly" && txtmk.Text == "12345")
            {
                MessageBox.Show("Dang nhap thanh cong");
                Form dnmain = new frmMain2();
                dnmain.Show();
                
            }
            else
            {
                MessageBox.Show("Thong tin tai khoan mat khau khong chinh xac");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to exit", "thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to exit", "thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtrogiup help= new frmtrogiup();
            help.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttaikhoan.Clear();
            txtmk.Clear();
        }

        private void txttaikhoan_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txttaikhoan, "You must enter username");
            else
                this.errorProvider1.Clear();
        }

        private void txtmk_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtmk, "You must enter password");
            else
                this.errorProvider1.Clear();
        }
    }
}
