namespace QL_BanHang.View
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.dtgvDSHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datengaylap = new System.Windows.Forms.DateTimePicker();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntimkiemhd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHH = new System.Windows.Forms.DataGridView();
            this.cmbHH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.qLBanHangDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BanHangDataSet3 = new QL_BanHang.QL_BanHangDataSet3();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHH)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHangDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSHD
            // 
            this.dtgvDSHD.AllowUserToAddRows = false;
            this.dtgvDSHD.AllowUserToDeleteRows = false;
            this.dtgvDSHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHD.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHD.Location = new System.Drawing.Point(6, 29);
            this.dtgvDSHD.Name = "dtgvDSHD";
            this.dtgvDSHD.ReadOnly = true;
            this.dtgvDSHD.RowHeadersWidth = 51;
            this.dtgvDSHD.Size = new System.Drawing.Size(643, 177);
            this.dtgvDSHD.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.datengaylap);
            this.groupBox1.Controls.Add(this.cbnhanvien);
            this.groupBox1.Controls.Add(this.cmbKhachHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // datengaylap
            // 
            this.datengaylap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datengaylap.CustomFormat = "yyyy-MM-dd";
            this.datengaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datengaylap.Location = new System.Drawing.Point(155, 75);
            this.datengaylap.Name = "datengaylap";
            this.datengaylap.Size = new System.Drawing.Size(145, 30);
            this.datengaylap.TabIndex = 4;
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(439, 26);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(172, 30);
            this.cbnhanvien.TabIndex = 3;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(439, 73);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(173, 30);
            this.cmbKhachHang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên lập";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMa
            // 
            this.txtMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMa.Location = new System.Drawing.Point(157, 32);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(143, 30);
            this.txtMa.TabIndex = 0;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            this.txtMa.Leave += new System.EventHandler(this.txtMa_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDSHD);
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(6, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 58);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm Hóa Đơn";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.BackColor = System.Drawing.Color.LightBlue;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(176, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 58);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa chi tiết hóa đơn";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.cmbHH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbThanhTien);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(673, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 152);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // btntimkiemhd
            // 
            this.btntimkiemhd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btntimkiemhd.FlatAppearance.BorderSize = 0;
            this.btntimkiemhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimkiemhd.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiemhd.Image")));
            this.btntimkiemhd.Location = new System.Drawing.Point(900, 25);
            this.btntimkiemhd.Name = "btntimkiemhd";
            this.btntimkiemhd.Size = new System.Drawing.Size(53, 58);
            this.btntimkiemhd.TabIndex = 4;
            this.btntimkiemhd.UseVisualStyleBackColor = false;
            this.btntimkiemhd.Click += new System.EventHandler(this.btntimkiemhd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(841, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 58);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dtgvDSHH);
            this.groupBox4.Location = new System.Drawing.Point(678, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 212);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hàng hóa";
            // 
            // dtgvDSHH
            // 
            this.dtgvDSHH.AllowUserToAddRows = false;
            this.dtgvDSHH.AllowUserToDeleteRows = false;
            this.dtgvDSHH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHH.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgvDSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHH.Location = new System.Drawing.Point(6, 29);
            this.dtgvDSHH.Name = "dtgvDSHH";
            this.dtgvDSHH.ReadOnly = true;
            this.dtgvDSHH.RowHeadersWidth = 51;
            this.dtgvDSHH.Size = new System.Drawing.Size(465, 177);
            this.dtgvDSHH.TabIndex = 0;
            this.dtgvDSHH.DataSourceChanged += new System.EventHandler(this.dtgvDSHH_DataSourceChanged);
            this.dtgvDSHH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSHH_CellClick);
            // 
            // cmbHH
            // 
            this.cmbHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbHH.FormattingEnabled = true;
            this.cmbHH.Location = new System.Drawing.Point(129, 25);
            this.cmbHH.Name = "cmbHH";
            this.cmbHH.Size = new System.Drawing.Size(335, 30);
            this.cmbHH.TabIndex = 2;
            this.cmbHH.SelectedIndexChanged += new System.EventHandler(this.cmbHH_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hàng hóa";
            // 
            // btnBot
            // 
            this.btnBot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBot.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBot.FlatAppearance.BorderSize = 0;
            this.btnBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot.Image = ((System.Drawing.Image)(resources.GetObject("btnBot.Image")));
            this.btnBot.Location = new System.Drawing.Point(1018, 23);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(53, 58);
            this.btnBot.TabIndex = 2;
            this.btnBot.UseVisualStyleBackColor = false;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(959, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 58);
            this.btnThem.TabIndex = 2;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSL.Location = new System.Drawing.Point(399, 61);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(65, 30);
            this.txtSL.TabIndex = 0;
            this.txtSL.Text = "1";
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(129, 58);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(117, 30);
            this.txtDonGia.TabIndex = 0;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "(VNĐ)";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.Blue;
            this.lbThanhTien.Location = new System.Drawing.Point(125, 95);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(24, 26);
            this.lbThanhTien.TabIndex = 1;
            this.lbThanhTien.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(789, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 58);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(521, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 58);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(351, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa hóa đơn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btntimkiemhd);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.btnBot);
            this.groupBox5.Controls.Add(this.btnThem);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnDel);
            this.groupBox5.Location = new System.Drawing.Point(12, 170);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1143, 89);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // qLBanHangDataSet3BindingSource
            // 
            this.qLBanHangDataSet3BindingSource.DataSource = this.qL_BanHangDataSet3;
            this.qLBanHangDataSet3BindingSource.Position = 0;
            // 
            // qL_BanHangDataSet3
            // 
            this.qL_BanHangDataSet3.DataSetName = "QL_BanHangDataSet3";
            this.qL_BanHangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1231, 705);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHH)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHangDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btntimkiemhd;
        private System.Windows.Forms.BindingSource qLBanHangDataSet3BindingSource;
        private QL_BanHangDataSet3 qL_BanHangDataSet3;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.DateTimePicker datengaylap;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtMa;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dtgvDSHD;
        public System.Windows.Forms.DataGridView dtgvDSHH;
    }
}