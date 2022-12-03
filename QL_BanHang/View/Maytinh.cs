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
    public partial class Maytinh : Form
    {
        public Maytinh()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                textBox3.Text = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text) + "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                textBox3.Text = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text) + "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {

                int soThuNhat = Convert.ToInt32(txtso1.Text);
                int soThuHai = Convert.ToInt32(txtso2.Text);
                int Kq = soThuNhat + soThuHai;
                txtketqua.Text = Kq.ToString();

            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                int soThuNhat = Convert.ToInt32(txtso1.Text);
                int soThuHai = Convert.ToInt32(txtso2.Text);
                int Kq = soThuNhat - soThuHai;
                txtketqua.Text = Kq.ToString();
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                int soThuNhat = Convert.ToInt32(txtso1.Text);
                int soThuHai = Convert.ToInt32(txtso2.Text);
                int Kq = soThuNhat * soThuHai;
                txtketqua.Text = Kq.ToString();
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                float soThuNhat = Convert.ToSingle(txtso1.Text);
                float soThuHai = Convert.ToSingle(txtso2.Text);
                float Kq = soThuNhat / soThuHai;
                txtketqua.Text = Kq.ToString();
            }
        }
    }
}
