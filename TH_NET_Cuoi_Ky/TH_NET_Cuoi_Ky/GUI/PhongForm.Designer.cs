namespace TH_NET_Cuoi_Ky.GUI
{
    partial class PhongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongForm));
            this.but_Delete = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.but_Update = new System.Windows.Forms.Button();
            this.but_Search = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.but_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BntShowPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Delete
            // 
            this.but_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_Delete.Image = ((System.Drawing.Image)(resources.GetObject("but_Delete.Image")));
            this.but_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Delete.Location = new System.Drawing.Point(466, 422);
            this.but_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.but_Delete.Name = "but_Delete";
            this.but_Delete.Size = new System.Drawing.Size(65, 32);
            this.but_Delete.TabIndex = 43;
            this.but_Delete.Text = "Xóa";
            this.but_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Delete.UseVisualStyleBackColor = false;
            this.but_Delete.Click += new System.EventHandler(this.but_Delete_Click);
            // 
            // but_Cancel
            // 
            this.but_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.but_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("but_Cancel.Image")));
            this.but_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Cancel.Location = new System.Drawing.Point(580, 422);
            this.but_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(74, 32);
            this.but_Cancel.TabIndex = 40;
            this.but_Cancel.Text = "Thoát";
            this.but_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Cancel.UseVisualStyleBackColor = false;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(513, 96);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(184, 24);
            this.txt_Search.TabIndex = 39;
            // 
            // but_Update
            // 
            this.but_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.but_Update.Image = ((System.Drawing.Image)(resources.GetObject("but_Update.Image")));
            this.but_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Update.Location = new System.Drawing.Point(324, 422);
            this.but_Update.Margin = new System.Windows.Forms.Padding(4);
            this.but_Update.Name = "but_Update";
            this.but_Update.Size = new System.Drawing.Size(103, 32);
            this.but_Update.TabIndex = 38;
            this.but_Update.Text = "Cập nhật";
            this.but_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Update.UseVisualStyleBackColor = false;
            this.but_Update.Click += new System.EventHandler(this.but_Update_Click);
            // 
            // but_Search
            // 
            this.but_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.but_Search.Image = ((System.Drawing.Image)(resources.GetObject("but_Search.Image")));
            this.but_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Search.Location = new System.Drawing.Point(387, 94);
            this.but_Search.Margin = new System.Windows.Forms.Padding(4);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(101, 32);
            this.but_Search.TabIndex = 37;
            this.but_Search.Text = "Tìm kiếm";
            this.but_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Search.UseVisualStyleBackColor = false;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(18, 152);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(681, 262);
            this.dgv.TabIndex = 36;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Location = new System.Drawing.Point(129, 97);
            this.txt_TenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(199, 24);
            this.txt_TenPhong.TabIndex = 31;
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(129, 30);
            this.txt_MaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.ReadOnly = true;
            this.txt_MaPhong.Size = new System.Drawing.Size(199, 24);
            this.txt_MaPhong.TabIndex = 30;
            // 
            // but_Add
            // 
            this.but_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.but_Add.Image = ((System.Drawing.Image)(resources.GetObject("but_Add.Image")));
            this.but_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Add.Location = new System.Drawing.Point(194, 422);
            this.but_Add.Margin = new System.Windows.Forms.Padding(4);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(79, 32);
            this.but_Add.TabIndex = 29;
            this.but_Add.Text = "Thêm";
            this.but_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Add.UseVisualStyleBackColor = false;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã số";
            // 
            // BntShowPhong
            // 
            this.BntShowPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BntShowPhong.Image = ((System.Drawing.Image)(resources.GetObject("BntShowPhong.Image")));
            this.BntShowPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BntShowPhong.Location = new System.Drawing.Point(52, 422);
            this.BntShowPhong.Margin = new System.Windows.Forms.Padding(4);
            this.BntShowPhong.Name = "BntShowPhong";
            this.BntShowPhong.Size = new System.Drawing.Size(95, 32);
            this.BntShowPhong.TabIndex = 24;
            this.BntShowPhong.Text = "Hiển thị";
            this.BntShowPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BntShowPhong.UseVisualStyleBackColor = false;
            this.BntShowPhong.Click += new System.EventHandler(this.BntShowPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(382, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Người Quản Lý";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(519, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 26);
            this.comboBox1.TabIndex = 45;
            // 
            // PhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 461);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_Delete);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.but_Update);
            this.Controls.Add(this.but_Search);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txt_TenPhong);
            this.Controls.Add(this.txt_MaPhong);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BntShowPhong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PhongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhongForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Delete;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button but_Update;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BntShowPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}