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
    public partial class frmKhachHang : Form
    {
        KhachHangCtr khCtr = new KhachHangCtr();
        private int flagLuu = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = khCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDS.DataSource, "MaKH");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dtgvDS.DataSource, "TenKH");
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dtgvDS.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtgvDS.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dtgvDS.DataSource, "SDT");
            dpNamSinh.DataBindings.Clear();
            dpNamSinh.DataBindings.Add("Text", dtgvDS.DataSource, "NamSinh");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dtgvDS.DataSource, "Email");
            txtDiem.DataBindings.Clear();
            txtDiem.DataBindings.Add("Text", dtgvDS.DataSource, "Diem");
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMa.Enabled = e;
            txtTen.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            cmbGioiTinh.Enabled = e;
            dpNamSinh.Enabled = e;
            txtEmail.Enabled = e;
        }

        private void loadCMB()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.SelectedItem = 0;
        }

        private void clearData()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            dpNamSinh.Value = DateTime.Now.Date;
            loadCMB();
            txtEmail.Text = "";
        }

        private void addData(KhachHangObj kh)
        {

           
                kh.MaKhachHang = txtMa.Text.Trim();
                if (cmbGioiTinh.SelectedIndex == 0)
                {
                    kh.GioiTinh = "Nam";
                }
                else
                    kh.GioiTinh = "Nữ";
                kh.DiaChi = txtDiaChi.Text.Trim();
                kh.DienThoai = txtSDT.Text.Trim();
                kh.TenKhachHang = txtTen.Text.Trim();
                kh.NamSinh = dpNamSinh.Text;
                kh.Email = txtEmail.Text.Trim();
                kh.Diem = int.Parse(txtDiem.Text.Trim());
            
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                flagLuu = 0;
                clearData();
                DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            loadCMB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangObj khObj = new KhachHangObj();
            addData(khObj);
            if (flagLuu == 0)
            {
                if (khCtr.AddData(khObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khCtr.UpdData(khObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmKhachHang_Load(sender, e);
            else
                return;
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_khachhang where tenkh = N'" + txttimkiemkh.Text + "'  ", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dtgvDS.DataSource = dt;
            con.Close();
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMa, "Ban phai nhap ma khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtTen, "Ban phai nhap ten khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtDiaChi, "Ban phai nhap dia chi khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtMa.Clear();
            txtSDT.Clear();
            txttimkiemkh.Clear();
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }
    }
}
