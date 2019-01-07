namespace TH_NET_Cuoi_Ky.GUI
{
    partial class TSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TSForm));
            this.label6 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbLoaiTS1 = new System.Windows.Forms.ComboBox();
            this.cbbNuocSX1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbbLoaiTS = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbNuocSX = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTskt = new System.Windows.Forms.TextBox();
            this.txtDvTinh = new System.Windows.Forms.TextBox();
            this.txtTenTS = new System.Windows.Forms.TextBox();
            this.txtMaTS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butShow = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadCBBLTS = new System.ComponentModel.BackgroundWorker();
            this.loadCBBNSX = new System.ComponentModel.BackgroundWorker();
            this.formMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCácMụcKhácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguoiQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuocSXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.formMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(171, 25);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(250, 24);
            this.txtTuKhoa.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(248, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbLoaiTS1
            // 
            this.cbbLoaiTS1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLoaiTS1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLoaiTS1.FormattingEnabled = true;
            this.cbbLoaiTS1.Location = new System.Drawing.Point(182, 78);
            this.cbbLoaiTS1.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiTS1.Name = "cbbLoaiTS1";
            this.cbbLoaiTS1.Size = new System.Drawing.Size(250, 26);
            this.cbbLoaiTS1.Sorted = true;
            this.cbbLoaiTS1.TabIndex = 2;
            this.cbbLoaiTS1.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiTS1_SelectedIndexChanged);
            // 
            // cbbNuocSX1
            // 
            this.cbbNuocSX1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbNuocSX1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNuocSX1.FormattingEnabled = true;
            this.cbbNuocSX1.Location = new System.Drawing.Point(182, 28);
            this.cbbNuocSX1.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNuocSX1.Name = "cbbNuocSX1";
            this.cbbNuocSX1.Size = new System.Drawing.Size(250, 26);
            this.cbbNuocSX1.Sorted = true;
            this.cbbNuocSX1.TabIndex = 1;
            this.cbbNuocSX1.SelectedIndexChanged += new System.EventHandler(this.cbbNuocSX1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại tài sản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nước sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã tài sản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên tài sản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đơn vị tính";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 180);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbbLoaiTS);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cbbNuocSX);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.txtGhiChu);
            this.tabPage1.Controls.Add(this.txtTskt);
            this.tabPage1.Controls.Add(this.txtDvTinh);
            this.tabPage1.Controls.Add(this.txtTenTS);
            this.tabPage1.Controls.Add(this.txtMaTS);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1021, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hiển thị và cập nhật";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiTS
            // 
            this.cbbLoaiTS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLoaiTS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLoaiTS.FormattingEnabled = true;
            this.cbbLoaiTS.Location = new System.Drawing.Point(829, 11);
            this.cbbLoaiTS.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiTS.Name = "cbbLoaiTS";
            this.cbbLoaiTS.Size = new System.Drawing.Size(181, 24);
            this.cbbLoaiTS.Sorted = true;
            this.cbbLoaiTS.TabIndex = 7;
            this.cbbLoaiTS.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiTS_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(500, 111);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cbbNuocSX
            // 
            this.cbbNuocSX.FormattingEnabled = true;
            this.cbbNuocSX.Location = new System.Drawing.Point(500, 64);
            this.cbbNuocSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNuocSX.Name = "cbbNuocSX";
            this.cbbNuocSX.Size = new System.Drawing.Size(181, 24);
            this.cbbNuocSX.Sorted = true;
            this.cbbNuocSX.TabIndex = 5;
            this.cbbNuocSX.SelectedIndexChanged += new System.EventHandler(this.cbbNuocSX_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(874, 101);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(829, 66);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(181, 22);
            this.txtGhiChu.TabIndex = 8;
            // 
            // txtTskt
            // 
            this.txtTskt.Location = new System.Drawing.Point(500, 13);
            this.txtTskt.Margin = new System.Windows.Forms.Padding(4);
            this.txtTskt.Name = "txtTskt";
            this.txtTskt.Size = new System.Drawing.Size(181, 22);
            this.txtTskt.TabIndex = 4;
            // 
            // txtDvTinh
            // 
            this.txtDvTinh.Location = new System.Drawing.Point(104, 111);
            this.txtDvTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDvTinh.Name = "txtDvTinh";
            this.txtDvTinh.Size = new System.Drawing.Size(181, 22);
            this.txtDvTinh.TabIndex = 3;
            // 
            // txtTenTS
            // 
            this.txtTenTS.Location = new System.Drawing.Point(104, 61);
            this.txtTenTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTS.Name = "txtTenTS";
            this.txtTenTS.Size = new System.Drawing.Size(181, 22);
            this.txtTenTS.TabIndex = 2;
            // 
            // txtMaTS
            // 
            this.txtMaTS.Location = new System.Drawing.Point(104, 15);
            this.txtMaTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTS.Name = "txtMaTS";
            this.txtMaTS.ReadOnly = true;
            this.txtMaTS.Size = new System.Drawing.Size(181, 22);
            this.txtMaTS.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(732, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ghi chú";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(732, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Loại tài sản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Năm sản xuất";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nước sản xuất";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Thông số kĩ thuật";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1021, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTuKhoa);
            this.groupBox3.Location = new System.Drawing.Point(515, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 133);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbNuocSX1);
            this.groupBox1.Controls.Add(this.cbbLoaiTS1);
            this.groupBox1.Location = new System.Drawing.Point(4, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(502, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter tìm kiếm";
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Transparent;
            this.butShow.Image = ((System.Drawing.Image)(resources.GetObject("butShow.Image")));
            this.butShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butShow.Location = new System.Drawing.Point(187, 471);
            this.butShow.Margin = new System.Windows.Forms.Padding(4);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(92, 32);
            this.butShow.TabIndex = 11;
            this.butShow.Text = "Hiển thị";
            this.butShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.menuDGV;
            this.dgv.Location = new System.Drawing.Point(5, 24);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1014, 208);
            this.dgv.TabIndex = 10;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            this.dgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            // 
            // menuDGV
            // 
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(156, 70);
            this.menuDGV.Opening += new System.ComponentModel.CancelEventHandler(this.menuDGV_Opening);
            // 
            // showDetailToolStripMenuItem
            // 
            this.showDetailToolStripMenuItem.Name = "showDetailToolStripMenuItem";
            this.showDetailToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showDetailToolStripMenuItem.Text = "Hiển thị chi tiết";
            this.showDetailToolStripMenuItem.Click += new System.EventHandler(this.showDetailToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.updateToolStripMenuItem.Text = "Sửa";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Transparent;
            this.butAdd.Image = ((System.Drawing.Image)(resources.GetObject("butAdd.Image")));
            this.butAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAdd.Location = new System.Drawing.Point(471, 471);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(92, 32);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "Thêm";
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.Enabled = false;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(755, 471);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(92, 32);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Xóa";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(5, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 239);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // loadCBBLTS
            // 
            this.loadCBBLTS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCBBLTS_DoWork);
            // 
            // loadCBBNSX
            // 
            this.loadCBBNSX.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCBBNSX_DoWork);
            // 
            // formMenu
            // 
            this.formMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quảnLýCácMụcKhácToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem});
            this.formMenu.Location = new System.Drawing.Point(0, 0);
            this.formMenu.Name = "formMenu";
            this.formMenu.Size = new System.Drawing.Size(1034, 24);
            this.formMenu.TabIndex = 19;
            this.formMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fileToolStripMenuItem.Text = "Tài sản";
            // 
            // newTSToolStripMenuItem
            // 
            this.newTSToolStripMenuItem.Name = "newTSToolStripMenuItem";
            this.newTSToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.newTSToolStripMenuItem.Text = "Tài sản mới (Ctrl + N)";
            this.newTSToolStripMenuItem.Click += new System.EventHandler(this.newTSToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importToolStripMenuItem.Text = "Nhập từ file (Ctrl + I)";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportToolStripMenuItem.Text = "Xuất ra file (Ctrl + E)";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // quảnLýCácMụcKhácToolStripMenuItem
            // 
            this.quảnLýCácMụcKhácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phongToolStripMenuItem,
            this.nguoiQLToolStripMenuItem,
            this.loaiTSToolStripMenuItem,
            this.nhaCCToolStripMenuItem,
            this.nuocSXToolStripMenuItem,
            this.nhapXuatToolStripMenuItem});
            this.quảnLýCácMụcKhácToolStripMenuItem.Name = "quảnLýCácMụcKhácToolStripMenuItem";
            this.quảnLýCácMụcKhácToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.quảnLýCácMụcKhácToolStripMenuItem.Text = "Quản lý các mục khác";
            // 
            // phongToolStripMenuItem
            // 
            this.phongToolStripMenuItem.Name = "phongToolStripMenuItem";
            this.phongToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.phongToolStripMenuItem.Text = "Phòng";
            this.phongToolStripMenuItem.Click += new System.EventHandler(this.phongToolStripMenuItem_Click);
            // 
            // nguoiQLToolStripMenuItem
            // 
            this.nguoiQLToolStripMenuItem.Name = "nguoiQLToolStripMenuItem";
            this.nguoiQLToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nguoiQLToolStripMenuItem.Text = "Người Quản Lý";
            this.nguoiQLToolStripMenuItem.Click += new System.EventHandler(this.nguoiQLToolStripMenuItem_Click);
            // 
            // loaiTSToolStripMenuItem
            // 
            this.loaiTSToolStripMenuItem.Name = "loaiTSToolStripMenuItem";
            this.loaiTSToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loaiTSToolStripMenuItem.Text = "Loại Tài Sản";
            this.loaiTSToolStripMenuItem.Click += new System.EventHandler(this.loaiTSToolStripMenuItem_Click);
            // 
            // nhaCCToolStripMenuItem
            // 
            this.nhaCCToolStripMenuItem.Name = "nhaCCToolStripMenuItem";
            this.nhaCCToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nhaCCToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhaCCToolStripMenuItem.Click += new System.EventHandler(this.nhaCCToolStripMenuItem_Click);
            // 
            // nuocSXToolStripMenuItem
            // 
            this.nuocSXToolStripMenuItem.Name = "nuocSXToolStripMenuItem";
            this.nuocSXToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nuocSXToolStripMenuItem.Text = "Nước Sản Xuất";
            this.nuocSXToolStripMenuItem.Click += new System.EventHandler(this.nuocSXToolStripMenuItem_Click);
            // 
            // nhapXuatToolStripMenuItem
            // 
            this.nhapXuatToolStripMenuItem.Name = "nhapXuatToolStripMenuItem";
            this.nhapXuatToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nhapXuatToolStripMenuItem.Text = "Lịch Sử Nhập/Xuất";
            this.nhapXuatToolStripMenuItem.Click += new System.EventHandler(this.nhapXuatToolStripMenuItem_Click);
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhómTácGiảToolStripMenuItem});
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // nhómTácGiảToolStripMenuItem
            // 
            this.nhómTácGiảToolStripMenuItem.Name = "nhómTácGiảToolStripMenuItem";
            this.nhómTácGiảToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nhómTácGiảToolStripMenuItem.Text = "Nhóm Tác Giả";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "Tất cả các tệp|*.*|MS Excel (2007-2019)|*.xlsx|MS Excel (2003)|*.xls";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xlsx";
            this.openFileDialog.Filter = "MS Excel (2007-2019)|*.xlsx|MS Excel (2003)|*.xls";
            // 
            // TSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 510);
            this.Controls.Add(this.formMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.formMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cơ sở vật chất khoa CNTT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSForm_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.formMenu.ResumeLayout(false);
            this.formMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbLoaiTS1;
        private System.Windows.Forms.ComboBox cbbNuocSX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtMaTS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbNuocSX;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTskt;
        private System.Windows.Forms.TextBox txtDvTinh;
        private System.Windows.Forms.TextBox txtTenTS;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbbLoaiTS;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem showDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker loadCBBLTS;
        private System.ComponentModel.BackgroundWorker loadCBBNSX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip formMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCácMụcKhácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguoiQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loaiTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuocSXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

