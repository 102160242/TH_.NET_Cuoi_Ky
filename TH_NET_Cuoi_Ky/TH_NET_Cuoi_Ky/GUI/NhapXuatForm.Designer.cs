namespace TH_NET_Cuoi_Ky.GUI
{
    partial class NhapXuatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapXuatForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Phieu_Nhap = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhap = new System.Windows.Forms.DataGridView();
            this.txt_TinhTrangNhap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHienThiNhap = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_SLNhap = new System.Windows.Forms.NumericUpDown();
            this.btnNhap = new System.Windows.Forms.Button();
            this.cbb_TenTSNhap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_PhongNhap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_NhaCCNhap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_phieu_xuat = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_GiaXuat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvXuat = new System.Windows.Forms.DataGridView();
            this.txt_TinhTrangXuat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnHienThiXuat = new System.Windows.Forms.Button();
            this.cbb_TenTSXuat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_SLXuat = new System.Windows.Forms.NumericUpDown();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_PhongXuat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_NhaCCXuat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_ThanhLy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.loadCBBTS_Nhap = new System.ComponentModel.BackgroundWorker();
            this.loadCBBNCC_Nhap = new System.ComponentModel.BackgroundWorker();
            this.loadCBBPhong_Nhap = new System.ComponentModel.BackgroundWorker();
            this.btnLuanchuyen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SLNhap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SLXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 471);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.txt_Phieu_Nhap);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txt_GiaNhap);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt_TinhTrangNhap);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.btnHienThiNhap);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.numericUpDown_SLNhap);
            this.tabPage1.Controls.Add(this.btnNhap);
            this.tabPage1.Controls.Add(this.cbb_TenTSNhap);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbb_PhongNhap);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbb_NhaCCNhap);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(938, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Phieu_Nhap
            // 
            this.txt_Phieu_Nhap.Location = new System.Drawing.Point(137, 16);
            this.txt_Phieu_Nhap.Name = "txt_Phieu_Nhap";
            this.txt_Phieu_Nhap.ReadOnly = true;
            this.txt_Phieu_Nhap.Size = new System.Drawing.Size(168, 24);
            this.txt_Phieu_Nhap.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 49;
            this.label15.Text = "Số Phiếu";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Location = new System.Drawing.Point(442, 56);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(168, 24);
            this.txt_GiaNhap.TabIndex = 48;
            this.txt_GiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaNhap_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNhap);
            this.groupBox1.Location = new System.Drawing.Point(7, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 277);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử nhập";
            // 
            // dgvNhap
            // 
            this.dgvNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhap.Location = new System.Drawing.Point(0, 24);
            this.dgvNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhap.Size = new System.Drawing.Size(923, 253);
            this.dgvNhap.TabIndex = 1;
            this.dgvNhap.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dgvNhap.SelectionChanged += new System.EventHandler(this.dgvNhap_SelectionChanged);
            this.dgvNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvNhap_KeyDown);
            // 
            // txt_TinhTrangNhap
            // 
            this.txt_TinhTrangNhap.Location = new System.Drawing.Point(758, 56);
            this.txt_TinhTrangNhap.Name = "txt_TinhTrangNhap";
            this.txt_TinhTrangNhap.Size = new System.Drawing.Size(168, 24);
            this.txt_TinhTrangNhap.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(673, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 45;
            this.label13.Text = "Tình Trạng";
            // 
            // btnHienThiNhap
            // 
            this.btnHienThiNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThiNhap.Image")));
            this.btnHienThiNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiNhap.Location = new System.Drawing.Point(837, 118);
            this.btnHienThiNhap.Name = "btnHienThiNhap";
            this.btnHienThiNhap.Size = new System.Drawing.Size(90, 32);
            this.btnHienThiNhap.TabIndex = 44;
            this.btnHienThiNhap.Text = "Hiển Thị";
            this.btnHienThiNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiNhap.UseVisualStyleBackColor = true;
            this.btnHienThiNhap.Click += new System.EventHandler(this.btnHienThiNhap_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 43;
            this.label11.Text = "Số Lượng";
            // 
            // numericUpDown_SLNhap
            // 
            this.numericUpDown_SLNhap.Location = new System.Drawing.Point(442, 96);
            this.numericUpDown_SLNhap.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_SLNhap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SLNhap.Name = "numericUpDown_SLNhap";
            this.numericUpDown_SLNhap.Size = new System.Drawing.Size(168, 24);
            this.numericUpDown_SLNhap.TabIndex = 42;
            // 
            // btnNhap
            // 
            this.btnNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhap.Image")));
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(740, 118);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(90, 32);
            this.btnNhap.TabIndex = 40;
            this.btnNhap.Text = "Nhập ";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // cbb_TenTSNhap
            // 
            this.cbb_TenTSNhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_TenTSNhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_TenTSNhap.FormattingEnabled = true;
            this.cbb_TenTSNhap.Location = new System.Drawing.Point(137, 56);
            this.cbb_TenTSNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_TenTSNhap.Name = "cbb_TenTSNhap";
            this.cbb_TenTSNhap.Size = new System.Drawing.Size(168, 26);
            this.cbb_TenTSNhap.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nguyên Giá";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(758, 16);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 24);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày Nhập";
            // 
            // cbb_PhongNhap
            // 
            this.cbb_PhongNhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_PhongNhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_PhongNhap.FormattingEnabled = true;
            this.cbb_PhongNhap.Location = new System.Drawing.Point(442, 16);
            this.cbb_PhongNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_PhongNhap.Name = "cbb_PhongNhap";
            this.cbb_PhongNhap.Size = new System.Drawing.Size(168, 26);
            this.cbb_PhongNhap.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Phòng";
            // 
            // cbb_NhaCCNhap
            // 
            this.cbb_NhaCCNhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_NhaCCNhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_NhaCCNhap.FormattingEnabled = true;
            this.cbb_NhaCCNhap.Location = new System.Drawing.Point(137, 96);
            this.cbb_NhaCCNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_NhaCCNhap.Name = "cbb_NhaCCNhap";
            this.cbb_NhaCCNhap.Size = new System.Drawing.Size(168, 26);
            this.cbb_NhaCCNhap.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tên tài sản";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.txt_phieu_xuat);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txt_GiaXuat);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.txt_TinhTrangXuat);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnHienThiXuat);
            this.tabPage2.Controls.Add(this.cbb_TenTSXuat);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.numericUpDown_SLXuat);
            this.tabPage2.Controls.Add(this.btnXuat);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbb_PhongXuat);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cbb_NhaCCXuat);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(938, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xuất";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_phieu_xuat
            // 
            this.txt_phieu_xuat.Location = new System.Drawing.Point(137, 16);
            this.txt_phieu_xuat.Name = "txt_phieu_xuat";
            this.txt_phieu_xuat.ReadOnly = true;
            this.txt_phieu_xuat.Size = new System.Drawing.Size(168, 24);
            this.txt_phieu_xuat.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 18);
            this.label16.TabIndex = 61;
            this.label16.Text = "Số Phiếu";
            // 
            // txt_GiaXuat
            // 
            this.txt_GiaXuat.Location = new System.Drawing.Point(442, 56);
            this.txt_GiaXuat.Name = "txt_GiaXuat";
            this.txt_GiaXuat.Size = new System.Drawing.Size(168, 24);
            this.txt_GiaXuat.TabIndex = 60;
            this.txt_GiaXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaXuat_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvXuat);
            this.groupBox2.Location = new System.Drawing.Point(7, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(924, 286);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử xuất";
            // 
            // dgvXuat
            // 
            this.dgvXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuat.Location = new System.Drawing.Point(0, 24);
            this.dgvXuat.Name = "dgvXuat";
            this.dgvXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXuat.Size = new System.Drawing.Size(923, 253);
            this.dgvXuat.TabIndex = 56;
            this.dgvXuat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            this.dgvXuat.SelectionChanged += new System.EventHandler(this.dgvXuat_SelectionChanged);
            this.dgvXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvXuat_KeyDown);
            // 
            // txt_TinhTrangXuat
            // 
            this.txt_TinhTrangXuat.Location = new System.Drawing.Point(758, 56);
            this.txt_TinhTrangXuat.Name = "txt_TinhTrangXuat";
            this.txt_TinhTrangXuat.Size = new System.Drawing.Size(168, 24);
            this.txt_TinhTrangXuat.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(673, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 18);
            this.label14.TabIndex = 57;
            this.label14.Text = "Tình Trạng";
            // 
            // btnHienThiXuat
            // 
            this.btnHienThiXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThiXuat.Image")));
            this.btnHienThiXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiXuat.Location = new System.Drawing.Point(837, 118);
            this.btnHienThiXuat.Name = "btnHienThiXuat";
            this.btnHienThiXuat.Size = new System.Drawing.Size(90, 32);
            this.btnHienThiXuat.TabIndex = 55;
            this.btnHienThiXuat.Text = "Hiển Thị";
            this.btnHienThiXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiXuat.UseVisualStyleBackColor = true;
            this.btnHienThiXuat.Click += new System.EventHandler(this.btnHienThiXuat_Click);
            // 
            // cbb_TenTSXuat
            // 
            this.cbb_TenTSXuat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_TenTSXuat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_TenTSXuat.FormattingEnabled = true;
            this.cbb_TenTSXuat.Location = new System.Drawing.Point(137, 56);
            this.cbb_TenTSXuat.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_TenTSXuat.Name = "cbb_TenTSXuat";
            this.cbb_TenTSXuat.Size = new System.Drawing.Size(168, 26);
            this.cbb_TenTSXuat.TabIndex = 54;
            this.cbb_TenTSXuat.SelectedIndexChanged += new System.EventHandler(this.cbb_TenTSXuat_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 18);
            this.label12.TabIndex = 52;
            this.label12.Text = "Số Lượng";
            // 
            // numericUpDown_SLXuat
            // 
            this.numericUpDown_SLXuat.Location = new System.Drawing.Point(442, 96);
            this.numericUpDown_SLXuat.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_SLXuat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SLXuat.Name = "numericUpDown_SLXuat";
            this.numericUpDown_SLXuat.Size = new System.Drawing.Size(168, 24);
            this.numericUpDown_SLXuat.TabIndex = 51;
            // 
            // btnXuat
            // 
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(758, 118);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(72, 32);
            this.btnXuat.TabIndex = 49;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nguyên Giá";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(758, 16);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(168, 24);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ngày Xuất";
            // 
            // cbb_PhongXuat
            // 
            this.cbb_PhongXuat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_PhongXuat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_PhongXuat.Enabled = false;
            this.cbb_PhongXuat.FormattingEnabled = true;
            this.cbb_PhongXuat.Location = new System.Drawing.Point(442, 16);
            this.cbb_PhongXuat.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_PhongXuat.Name = "cbb_PhongXuat";
            this.cbb_PhongXuat.Size = new System.Drawing.Size(168, 26);
            this.cbb_PhongXuat.TabIndex = 44;
            this.cbb_PhongXuat.SelectedIndexChanged += new System.EventHandler(this.cbb_PhongXuat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Phòng";
            // 
            // cbb_NhaCCXuat
            // 
            this.cbb_NhaCCXuat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_NhaCCXuat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_NhaCCXuat.Enabled = false;
            this.cbb_NhaCCXuat.FormattingEnabled = true;
            this.cbb_NhaCCXuat.Location = new System.Drawing.Point(137, 96);
            this.cbb_NhaCCXuat.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_NhaCCXuat.Name = "cbb_NhaCCXuat";
            this.cbb_NhaCCXuat.Size = new System.Drawing.Size(168, 26);
            this.cbb_NhaCCXuat.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Nhà Cung Cấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tên tài sản";
            // 
            // btn_ThanhLy
            // 
            this.btn_ThanhLy.Enabled = false;
            this.btn_ThanhLy.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThanhLy.Image")));
            this.btn_ThanhLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThanhLy.Location = new System.Drawing.Point(584, 479);
            this.btn_ThanhLy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThanhLy.Name = "btn_ThanhLy";
            this.btn_ThanhLy.Size = new System.Drawing.Size(93, 32);
            this.btn_ThanhLy.TabIndex = 53;
            this.btn_ThanhLy.Text = "Thanh Lý";
            this.btn_ThanhLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThanhLy.UseVisualStyleBackColor = true;
            this.btn_ThanhLy.Click += new System.EventHandler(this.btn_ThanhLy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(733, 477);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 32);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(225, 478);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 32);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(430, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // loadCBBTS_Nhap
            // 
            this.loadCBBTS_Nhap.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCBBTS_Nhap_DoWork);
            // 
            // loadCBBNCC_Nhap
            // 
            this.loadCBBNCC_Nhap.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCBBNCC_Nhap_DoWork);
            // 
            // loadCBBPhong_Nhap
            // 
            this.loadCBBPhong_Nhap.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCBBPhong_Nhap_DoWork);
            // 
            // btnLuanchuyen
            // 
            this.btnLuanchuyen.Enabled = false;
            this.btnLuanchuyen.Location = new System.Drawing.Point(27, 478);
            this.btnLuanchuyen.Name = "btnLuanchuyen";
            this.btnLuanchuyen.Size = new System.Drawing.Size(102, 32);
            this.btnLuanchuyen.TabIndex = 44;
            this.btnLuanchuyen.Text = "Luân Chuyển";
            this.btnLuanchuyen.UseVisualStyleBackColor = true;
            this.btnLuanchuyen.Click += new System.EventHandler(this.btnLuanchuyen_Click);
            // 
            // NhapXuatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 520);
            this.Controls.Add(this.btnLuanchuyen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_ThanhLy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NhapXuatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhập xuất tài sản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhapXuatForm_FormClosing);
            this.Shown += new System.EventHandler(this.NhapXuatForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SLNhap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SLXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvNhap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_PhongNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_NhaCCNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_SLNhap;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ComboBox cbb_TenTSNhap;
        private System.Windows.Forms.Button btn_ThanhLy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_SLXuat;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_PhongXuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_NhaCCXuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_TenTSXuat;
        private System.Windows.Forms.Button btnHienThiNhap;
        private System.Windows.Forms.Button btnHienThiXuat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvXuat;
        private System.Windows.Forms.TextBox txt_TinhTrangNhap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_TinhTrangXuat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.TextBox txt_GiaXuat;
        private System.ComponentModel.BackgroundWorker loadCBBTS_Nhap;
        private System.ComponentModel.BackgroundWorker loadCBBNCC_Nhap;
        private System.ComponentModel.BackgroundWorker loadCBBPhong_Nhap;
        private System.Windows.Forms.TextBox txt_Phieu_Nhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_phieu_xuat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLuanchuyen;
    }
}