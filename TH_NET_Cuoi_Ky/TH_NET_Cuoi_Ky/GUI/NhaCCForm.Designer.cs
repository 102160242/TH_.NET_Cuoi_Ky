namespace TH_NET_Cuoi_Ky.GUI
{
    partial class NhaCCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCCForm));
            this.label1 = new System.Windows.Forms.Label();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhaCC = new System.Windows.Forms.TextBox();
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.cbbAddress = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.but_Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // but_Cancel
            // 
            this.but_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("but_Cancel.Image")));
            this.but_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Cancel.Location = new System.Drawing.Point(441, 377);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(75, 23);
            this.but_Cancel.TabIndex = 12;
            this.but_Cancel.Text = "Thoát";
            this.but_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // butDelete
            // 
            this.butDelete.Image = ((System.Drawing.Image)(resources.GetObject("butDelete.Image")));
            this.butDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelete.Location = new System.Drawing.Point(360, 377);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 13;
            this.butDelete.Text = "Xóa";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Image = ((System.Drawing.Image)(resources.GetObject("butUpdate.Image")));
            this.butUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUpdate.Location = new System.Drawing.Point(279, 377);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(75, 23);
            this.butUpdate.TabIndex = 14;
            this.butUpdate.Text = "Cập nhật";
            this.butUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Transparent;
            this.butAdd.Image = ((System.Drawing.Image)(resources.GetObject("butAdd.Image")));
            this.butAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAdd.Location = new System.Drawing.Point(198, 377);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 15;
            this.butAdd.Text = "Thêm";
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Transparent;
            this.butShow.Image = ((System.Drawing.Image)(resources.GetObject("butShow.Image")));
            this.butShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butShow.Location = new System.Drawing.Point(117, 377);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(75, 23);
            this.butShow.TabIndex = 16;
            this.butShow.Text = "Hiển thị";
            this.butShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Địa chỉ";
            // 
            // txtMaNhaCC
            // 
            this.txtMaNhaCC.Location = new System.Drawing.Point(115, 30);
            this.txtMaNhaCC.Name = "txtMaNhaCC";
            this.txtMaNhaCC.ReadOnly = true;
            this.txtMaNhaCC.Size = new System.Drawing.Size(187, 20);
            this.txtMaNhaCC.TabIndex = 20;
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.Location = new System.Drawing.Point(115, 64);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(187, 20);
            this.txtTenNhaCC.TabIndex = 21;
            // 
            // cbbAddress
            // 
            this.cbbAddress.FormattingEnabled = true;
            this.cbbAddress.Location = new System.Drawing.Point(115, 99);
            this.cbbAddress.Name = "cbbAddress";
            this.cbbAddress.Size = new System.Drawing.Size(187, 21);
            this.cbbAddress.TabIndex = 23;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(8, 161);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(630, 210);
            this.dgv.TabIndex = 25;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtTenNhaCC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbAddress);
            this.groupBox1.Controls.Add(this.txtMaNhaCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 135);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.but_Search);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(324, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 131);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(96, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 20);
            this.txtSearch.TabIndex = 22;
            // 
            // but_Search
            // 
            this.but_Search.Image = ((System.Drawing.Image)(resources.GetObject("but_Search.Image")));
            this.but_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Search.Location = new System.Drawing.Point(96, 88);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(75, 23);
            this.but_Search.TabIndex = 11;
            this.but_Search.Text = "Tìm kiếm";
            this.but_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Search.UseVisualStyleBackColor = true;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Từ khóa";
            // 
            // NhaCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.but_Cancel);
            this.MaximizeBox = false;
            this.Name = "NhaCCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà cung cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhaCCForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhaCC;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.ComboBox cbbAddress;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.TextBox txtSearch;
    }
}