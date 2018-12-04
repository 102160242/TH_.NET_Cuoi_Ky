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
            this.but_Delete = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.but_Update = new System.Windows.Forms.Button();
            this.but_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.but_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BntShowPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Delete
            // 
            this.but_Delete.Location = new System.Drawing.Point(291, 305);
            this.but_Delete.Name = "but_Delete";
            this.but_Delete.Size = new System.Drawing.Size(75, 23);
            this.but_Delete.TabIndex = 43;
            this.but_Delete.Text = "Xóa";
            this.but_Delete.UseVisualStyleBackColor = true;
            this.but_Delete.Click += new System.EventHandler(this.but_Delete_Click);
            // 
            // but_Cancel
            // 
            this.but_Cancel.Location = new System.Drawing.Point(381, 305);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(75, 23);
            this.but_Cancel.TabIndex = 40;
            this.but_Cancel.Text = "Thoát";
            this.but_Cancel.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(354, 69);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(112, 20);
            this.txt_Search.TabIndex = 39;
            // 
            // but_Update
            // 
            this.but_Update.Location = new System.Drawing.Point(199, 305);
            this.but_Update.Name = "but_Update";
            this.but_Update.Size = new System.Drawing.Size(75, 23);
            this.but_Update.TabIndex = 38;
            this.but_Update.Text = "Cập nhật";
            this.but_Update.UseVisualStyleBackColor = true;
            this.but_Update.Click += new System.EventHandler(this.but_Update_Click);
            // 
            // but_Search
            // 
            this.but_Search.Location = new System.Drawing.Point(276, 67);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(66, 23);
            this.but_Search.TabIndex = 37;
            this.but_Search.Text = "Tìm kiếm";
            this.but_Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 189);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Location = new System.Drawing.Point(112, 70);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(103, 20);
            this.txt_TenPhong.TabIndex = 31;
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(112, 22);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.ReadOnly = true;
            this.txt_MaPhong.Size = new System.Drawing.Size(103, 20);
            this.txt_MaPhong.TabIndex = 30;
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(105, 305);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 29;
            this.but_Add.Text = "Thêm";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã số";
            // 
            // BntShowPhong
            // 
            this.BntShowPhong.Location = new System.Drawing.Point(11, 305);
            this.BntShowPhong.Name = "BntShowPhong";
            this.BntShowPhong.Size = new System.Drawing.Size(75, 23);
            this.BntShowPhong.TabIndex = 24;
            this.BntShowPhong.Text = "Hiển thị";
            this.BntShowPhong.UseVisualStyleBackColor = true;
            this.BntShowPhong.Click += new System.EventHandler(this.BntShowPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Người Quản Lý";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(358, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // PhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 333);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_Delete);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.but_Update);
            this.Controls.Add(this.but_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_TenPhong);
            this.Controls.Add(this.txt_MaPhong);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BntShowPhong);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PhongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhongForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhongForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Delete;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button but_Update;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
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