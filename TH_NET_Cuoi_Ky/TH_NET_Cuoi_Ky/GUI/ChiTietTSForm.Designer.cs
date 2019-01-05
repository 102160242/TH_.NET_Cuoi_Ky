namespace TH_NET_Cuoi_Ky
{
    partial class ChiTietTSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietTSForm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thanhLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTSKT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDonViTinh = new System.Windows.Forms.Label();
            this.labelTenTS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNamSX = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThanhLy = new System.Windows.Forms.Button();
            this.btnChuyenPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Location = new System.Drawing.Point(10, 25);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(711, 295);
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
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
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
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(31, 31);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(80, 18);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Tên tài sản";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(4, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(730, 328);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // labelTSKT
            // 
            this.labelTSKT.AutoSize = true;
            this.labelTSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTSKT.Location = new System.Drawing.Point(185, 64);
            this.labelTSKT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTSKT.Name = "labelTSKT";
            this.labelTSKT.Size = new System.Drawing.Size(163, 18);
            this.labelTSKT.TabIndex = 3;
            this.labelTSKT.Text = "<Thông số kỹ thuật>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm sản xuất";
            // 
            // labelDonViTinh
            // 
            this.labelDonViTinh.AutoSize = true;
            this.labelDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonViTinh.Location = new System.Drawing.Point(594, 31);
            this.labelDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDonViTinh.Name = "labelDonViTinh";
            this.labelDonViTinh.Size = new System.Drawing.Size(108, 18);
            this.labelDonViTinh.TabIndex = 6;
            this.labelDonViTinh.Text = "<Đơn vị tính>";
            // 
            // labelTenTS
            // 
            this.labelTenTS.AutoSize = true;
            this.labelTenTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTS.Location = new System.Drawing.Point(185, 31);
            this.labelTenTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenTS.Name = "labelTenTS";
            this.labelTenTS.Size = new System.Drawing.Size(118, 18);
            this.labelTenTS.TabIndex = 7;
            this.labelTenTS.Text = "<Tên Tài Sản>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thông số kỹ thuật";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.labelNamSX);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.titleLabel);
            this.groupBox2.Controls.Add(this.labelTenTS);
            this.groupBox2.Controls.Add(this.labelTSKT);
            this.groupBox2.Controls.Add(this.labelDonViTinh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(4, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 107);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // labelNamSX
            // 
            this.labelNamSX.AutoSize = true;
            this.labelNamSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamSX.Location = new System.Drawing.Point(594, 64);
            this.labelNamSX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamSX.Name = "labelNamSX";
            this.labelNamSX.Size = new System.Drawing.Size(131, 18);
            this.labelNamSX.TabIndex = 9;
            this.labelNamSX.Text = "<Năm sản xuất>";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(84, 456);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.Enabled = false;
            this.btnThanhLy.Location = new System.Drawing.Point(288, 456);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(75, 23);
            this.btnThanhLy.TabIndex = 11;
            this.btnThanhLy.Text = "Thanh lý";
            this.btnThanhLy.UseVisualStyleBackColor = true;
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // btnChuyenPhong
            // 
            this.btnChuyenPhong.Enabled = false;
            this.btnChuyenPhong.Location = new System.Drawing.Point(479, 456);
            this.btnChuyenPhong.Name = "btnChuyenPhong";
            this.btnChuyenPhong.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenPhong.TabIndex = 12;
            this.btnChuyenPhong.Text = "Chuyển Phòng";
            this.btnChuyenPhong.UseVisualStyleBackColor = true;
            this.btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
            // 
            // ChiTietTSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 488);
            this.Controls.Add(this.btnChuyenPhong);
            this.Controls.Add(this.btnThanhLy);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiTietTSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiển thị chi tiết tài sản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChiTietTSForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thanhLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenPhongToolStripMenuItem;
        private System.Windows.Forms.Label labelTSKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDonViTinh;
        private System.Windows.Forms.Label labelTenTS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNamSX;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnThanhLy;
        private System.Windows.Forms.Button btnChuyenPhong;
    }
}