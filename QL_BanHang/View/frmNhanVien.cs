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
    public partial class frmNhanVien : Form
    {
        NhanVienCtr nvCtr = new NhanVienCtr();
        private int flagLuu = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nvCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text",dtgvDS.DataSource,"MaNV");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dtgvDS.DataSource, "TenNV");
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dtgvDS.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtgvDS.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dtgvDS.DataSource, "SDT");
            dpNamSinh.DataBindings.Clear();
            dpNamSinh.DataBindings.Add("Text", dtgvDS.DataSource, "NamSinh");
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
        }

        private void addData(NhanVienObj nv)
        {
            nv.MaNhanVien = txtMa.Text.Trim();
            if (cmbGioiTinh.SelectedIndex == 0)
            {
                nv.GioiTinh = "Nam";
            }
            else
                nv.GioiTinh = "Nữ";
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.DienThoai = txtSDT.Text.Trim();
            nv.TenNhanVien = txtTen.Text.Trim();
            nv.NamSinh = dpNamSinh.Text;
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?","Xác nhận xóa",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(nvCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            loadCMB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienObj nvObj = new NhanVienObj();
            addData(nvObj);
            if (flagLuu == 0)
            { 
                if(nvCtr.AddData(nvObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvCtr.UpdData(nvObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmNhanVien_Load(sender, e);
            else
                return;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection("server = VUTRINGOC ; database = ql_banhang; integrated security = true ");
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_nhanvien where tennv = N'" + txttimkiemmnv.Text + "'  ", con);
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
                this.errorProvider1.SetError(txtTen, "Ban phai nhap ma khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtDiaChi, "Ban phai nhap ma khach hang");
            else
                this.errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTen.Clear();
            txttimkiemmnv.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }
    }
}
