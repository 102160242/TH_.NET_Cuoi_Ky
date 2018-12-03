namespace TH_NET_Cuoi_Ky.GUI
{
    partial class NguoiQLForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.but_Show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.txt_MaQL = new System.Windows.Forms.TextBox();
            this.txt_TenQL = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_Search = new System.Windows.Forms.Button();
            this.but_Update = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.but_Sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // but_Show
            // 
            this.but_Show.Location = new System.Drawing.Point(419, 386);
            this.but_Show.Name = "but_Show";
            this.but_Show.Size = new System.Drawing.Size(75, 23);
            this.but_Show.TabIndex = 1;
            this.but_Show.Text = "Hiển thị";
            this.but_Show.UseVisualStyleBackColor = true;
            this.but_Show.Click += new System.EventHandler(this.but_Show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính";
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(535, 386);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 6;
            this.but_Add.Text = "Thêm";
            this.but_Add.UseVisualStyleBackColor = true;
            // 
            // txt_MaQL
            // 
            this.txt_MaQL.Location = new System.Drawing.Point(115, 28);
            this.txt_MaQL.Name = "txt_MaQL";
            this.txt_MaQL.Size = new System.Drawing.Size(200, 20);
            this.txt_MaQL.TabIndex = 7;
            // 
            // txt_TenQL
            // 
            this.txt_TenQL.Location = new System.Drawing.Point(115, 54);
            this.txt_TenQL.Name = "txt_TenQL";
            this.txt_TenQL.Size = new System.Drawing.Size(200, 20);
            this.txt_TenQL.TabIndex = 8;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(537, 28);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(205, 20);
            this.txt_SDT.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(563, 65);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(47, 17);
            this.rb_Male.TabIndex = 11;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(650, 65);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(39, 17);
            this.rb_Female.TabIndex = 12;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(816, 217);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // but_Search
            // 
            this.but_Search.Location = new System.Drawing.Point(509, 106);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(75, 23);
            this.but_Search.TabIndex = 14;
            this.but_Search.Text = "Tìm kiếm";
            this.but_Search.UseVisualStyleBackColor = true;
            // 
            // but_Update
            // 
            this.but_Update.Location = new System.Drawing.Point(650, 386);
            this.but_Update.Name = "but_Update";
            this.but_Update.Size = new System.Drawing.Size(75, 23);
            this.but_Update.TabIndex = 15;
            this.but_Update.Text = "Cập nhật";
            this.but_Update.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(603, 106);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(200, 20);
            this.txt_Search.TabIndex = 17;
            // 
            // but_Cancel
            // 
            this.but_Cancel.Location = new System.Drawing.Point(784, 384);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(75, 23);
            this.but_Cancel.TabIndex = 19;
            this.but_Cancel.Text = "Thoát";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Location = new System.Drawing.Point(131, 386);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(159, 21);
            this.cbb_Sort.TabIndex = 21;
            // 
            // but_Sort
            // 
            this.but_Sort.Location = new System.Drawing.Point(59, 386);
            this.but_Sort.Name = "but_Sort";
            this.but_Sort.Size = new System.Drawing.Size(66, 23);
            this.but_Sort.TabIndex = 20;
            this.but_Sort.Text = "Sắp xếp";
            this.but_Sort.UseVisualStyleBackColor = true;
            // 
            // NguoiQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 432);
            this.Controls.Add(this.cbb_Sort);
            this.Controls.Add(this.but_Sort);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.but_Update);
            this.Controls.Add(this.but_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rb_Female);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenQL);
            this.Controls.Add(this.txt_MaQL);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_Show);
            this.Controls.Add(this.label1);
            this.Name = "NguoiQLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NguoiQLForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NguoiQLForm_FormClosing);
            this.Load += new System.EventHandler(this.NguoiQLForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.TextBox txt_MaQL;
        private System.Windows.Forms.TextBox txt_TenQL;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.Button but_Update;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.Button but_Sort;
    }
}