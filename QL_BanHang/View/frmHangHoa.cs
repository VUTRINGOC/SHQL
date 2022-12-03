using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_BanHang.Control1;
using QL_BanHang.Obiect;
using System.Data.SqlClient;

namespace QL_BanHang.View
{
    public partial class frmHangHoa : Form
    {
        HangHoaCtr hhCtr = new HangHoaCtr();
        //private int flagLuu = 0;
        public frmHangHoa()
        {
            InitializeComponent();
        }
        void load_data()
        {

            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_hanghoa", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dtgvDS.DataSource = dt;
            con.Close();
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BanHangDataSet1.tb_HangHoa' table. You can move, or remove it, as needed.
            //this.tb_HangHoaTableAdapter.Fill(this.qL_BanHangDataSet1.tb_HangHoa);

            // TODO: This line of code loads data into the 'qL_BanHangDataSet.tb_HangHoa' table. You can move, or remove it, as needed.
            //  this.tb_HangHoaTableAdapter.Fill(this.qL_BanHangDataSet.tb_HangHoa);
            //cach 1
            /*
            DataTable dtDS = new System.Data.DataTable();
            dtDS = hhCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
            */

            //cach 2 theo thay
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_ncc", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "mancc";
            //comboBox1.ValueMember = "mancc";
            
            con.Close();
            load_data();
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            try{
                SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
                SqlCommand cmd = new SqlCommand("insert into tb_hanghoa values( '" + txtMa.Text + "',  '" + txtTen.Text + "','" + Convert.ToInt32(txtDonGia.Text) + "', '" + Convert.ToInt32(txtSL.Text) + "' , '" + comboBox1.Text + "', '" + txtdongiaban.Text + "', '" + dateTimePicker1.Text + "' )", con);
                con.Open();
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("Thêm dữ liệu thành công");
                con.Close();
                load_data();
               }
            catch(Exception a)
            {
                MessageBox.Show("Nhap thieu thong tin hoac bi trung");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlCommand cmd = new SqlCommand("update tb_hanghoa set tenhang = '" + txtTen.Text + "', dongia = '" + txtDonGia.Text + "', soluong = '" + txtSL.Text + "', mancc = '" + comboBox1.Text + "', dongiaban = '"+txtdongiaban.Text+"', ngaynhap = '"+ dateTimePicker1.Text +"' where mahang ='" + txtMa.Text + "'  ", con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show("Sửa dữ liệu thành công");
            con.Close();
            load_data();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
                SqlCommand cmd = new SqlCommand("delete from tb_hanghoa where tenhang ='" + txtTen.Text + "' ", con);
                con.Open();
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("Xóa dữ liệu thành công");
                con.Close();
                load_data();
            }  
        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
            txtMa.Text = dtgvDS.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dtgvDS.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDonGia.Text = dtgvDS.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdongiaban.Text = dtgvDS.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSL.Text = dtgvDS.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.Text = dtgvDS.Rows[e.RowIndex].Cells[5].Value.ToString();

            dateTimePicker1.Text = dtgvDS.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_hanghoa where tenhang = N'" + txttimkiemhh.Text + "'  ", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dtgvDS.DataSource = dt;
            con.Close();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtSL, "Vui long nhap so");
            else
                this.errorProvider1.Clear();
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMa, "Ban phai nhap ma san pham");
            else
                this.errorProvider1.Clear();
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtTen, "Ban phai nhap ten san pham");
            else
                this.errorProvider1.Clear();
        }

        private void txtdongiaban_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtdongiaban, "Ban phai nhap don gia ban");
            else
                this.errorProvider1.Clear();
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtDonGia, "Ban phai nhap don gia");
            else
                this.errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtdongiaban.Clear();
            txtMa.Clear();
            txtSL.Clear();
            txtTen.Clear();
            txttimkiemhh.Clear();
        }

        private void btnrefr_Click(object sender, EventArgs e)
        {
            load_data();
        }

        //cach 1:
        //private void binhding()
        //{
        //    txtMa.DataBindings.Clear();
        //    txtMa.DataBindings.Add("Text", dtgvDS.DataSource, "MaHang");
        //    txtTen.DataBindings.Clear();
        //    txtTen.DataBindings.Add("Text", dtgvDS.DataSource, "TenHang");

        //    txtDonGia.DataBindings.Clear();
        //    txtDonGia.DataBindings.Add("Text", dtgvDS.DataSource, "DonGia");
        //    txtSL.DataBindings.Clear();
        //    txtSL.DataBindings.Add("Text", dtgvDS.DataSource, "SoLuong");
        //}

        //private void clearData()
        //{
        //    txtMa.Text = "";
        //    txtTen.Text = "";
        //    txtDonGia.Text = "";
        //    txtSL.Text = "";
        //}

        //private void addData(HangHoaObj hh)
        //{
        //    hh.MaHangHoa = txtMa.Text.Trim();
        //    hh.DonGia = int.Parse(txtDonGia.Text.Trim());
        //    hh.SoLuong = int.Parse(txtSL.Text.Trim());
        //    hh.TenHangHoa = txtTen.Text.Trim();
        //}

        //private void DisEnl(bool e)
        //{
        //    btnThem.Enabled = !e;
        //    btnXoa.Enabled = !e;
        //    btnSua.Enabled = !e;
        //    btnLuu.Enabled = e;
        //    btnHuy.Enabled = e;
        //    txtMa.Enabled = e;
        //    txtTen.Enabled = e;
        //    txtDonGia.Enabled = e;
        //    txtSL.Enabled = false;
        //    btnNhapHang.Enabled = !e;
        //}

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    flagLuu = 0;

        //    clearData();
        //    DisEnl(true);
        //    txtSL.Enabled = true;
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dr == DialogResult.Yes)
        //    {
        //        if (hhCtr.DelData(txtMa.Text.Trim()))
        //            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        else
        //            MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    frmHangHoa_Load(sender, e);
        //}

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    flagLuu = 1;
        //    DisEnl(true);
        //}

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    HangHoaObj hhObj = new HangHoaObj();
        //    addData(hhObj);
        //    if (flagLuu == 0)
        //    {
        //        if (hhCtr.AddData(hhObj))
        //            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        else
        //            MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (flagLuu == 1)
        //    {
        //        if (hhCtr.UpdData(hhObj))
        //            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        else
        //            MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        if (hhCtr.UpdData(hhObj))
        //            MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        else
        //            MessageBox.Show("Nhập hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    frmHangHoa_Load(sender, e);
        //}

        //private void btnHuy_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dr == DialogResult.Yes)
        //        frmHangHoa_Load(sender, e);
        //    else
        //        return;
        //}

        //private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void btnNhapHang_Click(object sender, EventArgs e)
        //{
        //    flagLuu = 2;
        //    btnNhapHang.Enabled = true;
        //    btnThem.Enabled = false;
        //    btnXoa.Enabled = true;
        //    btnSua.Enabled = false;
        //    btnLuu.Enabled = true;
        //    btnHuy.Enabled = true;
        //    txtSL.Enabled = true;
        //}
    }
}
