namespace TH_NET_Cuoi_Ky.GUI
{
    partial class LoaiTSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiTSForm));
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiTS = new System.Windows.Forms.TextBox();
            this.txtMaLoaiTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butShow = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInfo.Controls.Add(this.txtTenLoaiTS);
            this.groupBoxInfo.Controls.Add(this.txtMaLoaiTS);
            this.groupBoxInfo.Controls.Add(this.label2);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Location = new System.Drawing.Point(4, 13);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Size = new System.Drawing.Size(329, 119);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin";
            // 
            // txtTenLoaiTS
            // 
            this.txtTenLoaiTS.Location = new System.Drawing.Point(126, 67);
            this.txtTenLoaiTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiTS.Name = "txtTenLoaiTS";
            this.txtTenLoaiTS.Size = new System.Drawing.Size(191, 24);
            this.txtTenLoaiTS.TabIndex = 2;
            this.txtTenLoaiTS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenLoaiTS_KeyDown);
            // 
            // txtMaLoaiTS
            // 
            this.txtMaLoaiTS.Location = new System.Drawing.Point(128, 27);
            this.txtMaLoaiTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoaiTS.Name = "txtMaLoaiTS";
            this.txtMaLoaiTS.ReadOnly = true;
            this.txtMaLoaiTS.Size = new System.Drawing.Size(191, 24);
            this.txtMaLoaiTS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại tài sản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại tài sản";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearch.Controls.Add(this.butSearch);
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.label3);
            this.groupBoxSearch.Location = new System.Drawing.Point(341, 13);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Size = new System.Drawing.Size(329, 119);
            this.groupBoxSearch.TabIndex = 1;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm kiếm";
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Transparent;
            this.butSearch.Image = ((System.Drawing.Image)(resources.GetObject("butSearch.Image")));
            this.butSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSearch.Location = new System.Drawing.Point(114, 65);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(99, 32);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "Tìm kiếm";
            this.butSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(114, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 24);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ khóa";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.menuDGV;
            this.dgv.Location = new System.Drawing.Point(7, 24);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(653, 253);
            this.dgv.TabIndex = 5;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            this.dgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            // 
            // menuDGV
            // 
            this.menuDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(95, 48);
            this.menuDGV.Opening += new System.ComponentModel.CancelEventHandler(this.menuDGV_Opening);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.updateToolStripMenuItem.Text = "Sửa";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Transparent;
            this.butShow.Image = ((System.Drawing.Image)(resources.GetObject("butShow.Image")));
            this.butShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butShow.Location = new System.Drawing.Point(11, 430);
            this.butShow.Margin = new System.Windows.Forms.Padding(4);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(96, 32);
            this.butShow.TabIndex = 6;
            this.butShow.Text = "Hiển thị";
            this.butShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Transparent;
            this.butAdd.Image = ((System.Drawing.Image)(resources.GetObject("butAdd.Image")));
            this.butAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAdd.Location = new System.Drawing.Point(150, 430);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(96, 32);
            this.butAdd.TabIndex = 7;
            this.butAdd.Text = "Thêm";
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.Color.Transparent;
            this.butUpdate.Enabled = false;
            this.butUpdate.Image = ((System.Drawing.Image)(resources.GetObject("butUpdate.Image")));
            this.butUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUpdate.Location = new System.Drawing.Point(289, 430);
            this.butUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(96, 32);
            this.butUpdate.TabIndex = 8;
            this.butUpdate.Text = "Cập nhật";
            this.butUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butUpdate.UseVisualStyleBackColor = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Transparent;
            this.butDelete.Enabled = false;
            this.butDelete.Image = ((System.Drawing.Image)(resources.GetObject("butDelete.Image")));
            this.butDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelete.Location = new System.Drawing.Point(428, 430);
            this.butDelete.Margin = new System.Windows.Forms.Padding(4);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(96, 32);
            this.butDelete.TabIndex = 9;
            this.butDelete.Text = "Xóa";
            this.butDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.Transparent;
            this.butCancel.Image = ((System.Drawing.Image)(resources.GetObject("butCancel.Image")));
            this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCancel.Location = new System.Drawing.Point(567, 430);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(96, 32);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "Thoát";
            this.butCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgv);
            this.groupBox3.Location = new System.Drawing.Point(4, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 284);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // LoaiTSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(674, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoaiTSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại tài sản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoaiTSForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoaiTSForm_KeyDown);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtTenLoaiTS;
        private System.Windows.Forms.TextBox txtMaLoaiTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}