namespace TH_NET_Cuoi_Ky.GUI
{
    partial class ChiTietPhongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhongForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.labelNguoiQL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thanhLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChuyenPhong = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThanhLy = new System.Windows.Forms.Button();
            this.bntSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.titleLabel);
            this.groupBox2.Controls.Add(this.labelTenPhong);
            this.groupBox2.Controls.Add(this.labelNguoiQL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 71);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(31, 31);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(80, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Tên Phòng";
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhong.Location = new System.Drawing.Point(185, 31);
            this.labelTenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(109, 18);
            this.labelTenPhong.TabIndex = 7;
            this.labelTenPhong.Text = "<Tên Phòng>";
            // 
            // labelNguoiQL
            // 
            this.labelNguoiQL.AutoSize = true;
            this.labelNguoiQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNguoiQL.Location = new System.Drawing.Point(569, 31);
            this.labelNguoiQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNguoiQL.Name = "labelNguoiQL";
            this.labelNguoiQL.Size = new System.Drawing.Size(139, 18);
            this.labelNguoiQL.TabIndex = 6;
            this.labelNguoiQL.Text = "<Người Quản Lý>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Người Quản Lý";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(5, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(730, 364);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Location = new System.Drawing.Point(8, 25);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(715, 331);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhLyToolStripMenuItem,
            this.chuyenPhongToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 48);
            // 
            // thanhLyToolStripMenuItem
            // 
            this.thanhLyToolStripMenuItem.Name = "thanhLyToolStripMenuItem";
            this.thanhLyToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.thanhLyToolStripMenuItem.Text = "Thanh lý";
            this.thanhLyToolStripMenuItem.Click += new System.EventHandler(this.thanhLyToolStripMenuItem_Click);
            // 
            // chuyenPhongToolStripMenuItem
            // 
            this.chuyenPhongToolStripMenuItem.Name = "chuyenPhongToolStripMenuItem";
            this.chuyenPhongToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.chuyenPhongToolStripMenuItem.Text = "Chuyển sang phòng khác";
            this.chuyenPhongToolStripMenuItem.Click += new System.EventHandler(this.chuyenPhongToolStripMenuItem_Click);
            // 
            // btnChuyenPhong
            // 
            this.btnChuyenPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyenPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChuyenPhong.Enabled = false;
            this.btnChuyenPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenPhong.Image")));
            this.btnChuyenPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenPhong.Location = new System.Drawing.Point(329, 457);
            this.btnChuyenPhong.Name = "btnChuyenPhong";
            this.btnChuyenPhong.Size = new System.Drawing.Size(96, 32);
            this.btnChuyenPhong.TabIndex = 17;
            this.btnChuyenPhong.Text = "Chuyển Phòng";
            this.btnChuyenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChuyenPhong.UseVisualStyleBackColor = false;
            this.btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhap.Image")));
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(39, 457);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(96, 32);
            this.btnNhap.TabIndex = 15;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThanhLy.Enabled = false;
            this.btnThanhLy.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhLy.Image")));
            this.btnThanhLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhLy.Location = new System.Drawing.Point(184, 457);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(96, 32);
            this.btnThanhLy.TabIndex = 16;
            this.btnThanhLy.Text = "Thanh lý";
            this.btnThanhLy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhLy.UseVisualStyleBackColor = false;
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // bntSearch
            // 
            this.bntSearch.Image = ((System.Drawing.Image)(resources.GetObject("bntSearch.Image")));
            this.bntSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSearch.Location = new System.Drawing.Point(474, 457);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(96, 32);
            this.bntSearch.TabIndex = 18;
            this.bntSearch.Text = "Tìm Kiếm";
            this.bntSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(619, 462);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // ChiTietPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 494);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.btnChuyenPhong);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThanhLy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChiTietPhongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết về Phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChiTietPhongForm_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChuyenPhong;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.Label labelNguoiQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thanhLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenPhongToolStripMenuItem;
        private System.Windows.Forms.Button btnThanhLy;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}