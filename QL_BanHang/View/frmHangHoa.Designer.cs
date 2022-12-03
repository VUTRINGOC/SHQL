namespace QL_BanHang.View
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.dtgvDS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLBanHangDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BanHangDataSet2 = new QL_BanHang.QL_BanHangDataSet2();
            this.qLBanHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BanHangDataSet = new QL_BanHang.QL_BanHangDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdongiaban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.qL_BanHangDataSet1 = new QL_BanHang.QL_BanHangDataSet1();
            this.qLBanHangDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txttimkiemhh = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnrefr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHangDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHangDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHangDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSet1BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Location = new System.Drawing.Point(828, 126);
            this.txtDonGia.MaxLength = 50;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(256, 30);
            this.txtDonGia.TabIndex = 0;
            this.txtDonGia.Leave += new System.EventHandler(this.txtDonGia_Leave);
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTen.Location = new System.Drawing.Point(828, 86);
            this.txtTen.MaxLength = 30;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(256, 30);
            this.txtTen.TabIndex = 0;
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // txtMa
            // 
            this.txtMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMa.Location = new System.Drawing.Point(371, 46);
            this.txtMa.MaxLength = 10;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(183, 30);
            this.txtMa.TabIndex = 0;
            this.txtMa.Leave += new System.EventHandler(this.txtMa_Leave);
            // 
            // dtgvDS
            // 
            this.dtgvDS.AllowUserToAddRows = false;
            this.dtgvDS.AllowUserToDeleteRows = false;
            this.dtgvDS.AllowUserToOrderColumns = true;
            this.dtgvDS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDS.AutoGenerateColumns = false;
            this.dtgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.donGiaBanDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ngaynhapDataGridViewTextBoxColumn});
            this.dtgvDS.DataMember = "tb_HangHoa";
            this.dtgvDS.DataSource = this.qLBanHangDataSet2BindingSource;
            this.dtgvDS.Location = new System.Drawing.Point(0, 29);
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.ReadOnly = true;
            this.dtgvDS.RowHeadersWidth = 51;
            this.dtgvDS.Size = new System.Drawing.Size(1334, 136);
            this.dtgvDS.TabIndex = 0;
            this.dtgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDS_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn Giá Nhập";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // donGiaBanDataGridViewTextBoxColumn
            // 
            this.donGiaBanDataGridViewTextBoxColumn.DataPropertyName = "DonGiaBan";
            this.donGiaBanDataGridViewTextBoxColumn.HeaderText = "Đơn Giá Bán";
            this.donGiaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaBanDataGridViewTextBoxColumn.Name = "donGiaBanDataGridViewTextBoxColumn";
            this.donGiaBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mancc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã Nhà Cung Cấp";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngaynhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            this.ngaynhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qLBanHangDataSet2BindingSource
            // 
            this.qLBanHangDataSet2BindingSource.DataSource = this.qL_BanHangDataSet2;
            this.qLBanHangDataSet2BindingSource.Position = 0;
            // 
            // qL_BanHangDataSet2
            // 
            this.qL_BanHangDataSet2.DataSetName = "QL_BanHangDataSet2";
            this.qL_BanHangDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBanHangDataSetBindingSource
            // 
            this.qLBanHangDataSetBindingSource.DataSource = this.qL_BanHangDataSet;
            this.qLBanHangDataSetBindingSource.Position = 0;
            // 
            // qL_BanHangDataSet
            // 
            this.qL_BanHangDataSet.DataSetName = "QL_BanHangDataSet";
            this.qL_BanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hàng hóa";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng hóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDS);
            this.groupBox2.Location = new System.Drawing.Point(12, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1337, 165);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng hóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdongiaban);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1337, 265);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1091, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "(VNĐ)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 30);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày Nhập";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(708, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Đơn giá bán";
            // 
            // txtdongiaban
            // 
            this.txtdongiaban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdongiaban.Location = new System.Drawing.Point(828, 180);
            this.txtdongiaban.MaxLength = 30;
            this.txtdongiaban.Name = "txtdongiaban";
            this.txtdongiaban.Size = new System.Drawing.Size(256, 30);
            this.txtdongiaban.TabIndex = 6;
            this.txtdongiaban.Leave += new System.EventHandler(this.txtdongiaban_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã NCC";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(828, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 30);
            this.comboBox1.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSL.Location = new System.Drawing.Point(371, 124);
            this.txtSL.MaxLength = 50;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(183, 30);
            this.txtSL.TabIndex = 2;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1091, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "(VNĐ)";
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(473, 314);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(42, 48);
            this.btnadd.TabIndex = 17;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(538, 314);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(41, 48);
            this.btnedit.TabIndex = 18;
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(611, 314);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(39, 48);
            this.btndel.TabIndex = 19;
            this.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // qL_BanHangDataSet1
            // 
            this.qL_BanHangDataSet1.DataSetName = "QL_BanHangDataSet1";
            this.qL_BanHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLBanHangDataSet1BindingSource
            // 
            this.qLBanHangDataSet1BindingSource.DataSource = this.qL_BanHangDataSet1;
            this.qLBanHangDataSet1BindingSource.Position = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txttimkiemhh);
            this.groupBox3.Location = new System.Drawing.Point(1094, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 111);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo tên hàng hóa";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(62, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttimkiemhh
            // 
            this.txttimkiemhh.Location = new System.Drawing.Point(19, 35);
            this.txttimkiemhh.MaxLength = 30;
            this.txttimkiemhh.Name = "txttimkiemhh";
            this.txttimkiemhh.Size = new System.Drawing.Size(218, 30);
            this.txttimkiemhh.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // tbHangHoaBindingSource
            // 
            this.tbHangHoaBindingSource.DataMember = "tb_HangHoa";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(680, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 48);
            this.button2.TabIndex = 21;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrefr
            // 
            this.btnrefr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrefr.FlatAppearance.BorderSize = 0;
            this.btnrefr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefr.Image = ((System.Drawing.Image)(resources.GetObject("btnrefr.Image")));
            this.btnrefr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefr.Location = new System.Drawing.Point(755, 314);
            this.btnrefr.Name = "btnrefr";
            this.btnrefr.Size = new System.Drawing.Size(38, 48);
            this.btnrefr.TabIndex = 22;
            this.btnrefr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefr.UseVisualStyleBackColor = true;
            this.btnrefr.Click += new System.EventHandler(this.btnrefr_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1364, 571);
            this.Controls.Add(this.btnrefr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hàng hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHangDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHangDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHangDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanHangDataSet1BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView dtgvDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
       // private QL_BanHangDataSet qL_BanHangDataSet;
        private System.Windows.Forms.BindingSource tbHangHoaBindingSource;
       // private QL_BanHangDataSetTableAdapters.tb_HangHoaTableAdapter tb_HangHoaTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn manccDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource qLBanHangDataSetBindingSource;
        private QL_BanHangDataSet qL_BanHangDataSet;
        private QL_BanHangDataSet1 qL_BanHangDataSet1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdongiaban;
        private System.Windows.Forms.BindingSource qLBanHangDataSet1BindingSource;
        private System.Windows.Forms.BindingSource qLBanHangDataSet2BindingSource;
        private QL_BanHangDataSet2 qL_BanHangDataSet2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttimkiemhh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnrefr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
    }
}