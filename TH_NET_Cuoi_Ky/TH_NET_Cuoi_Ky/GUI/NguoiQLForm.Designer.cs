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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguoiQLForm));
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_Search = new System.Windows.Forms.Button();
            this.but_Update = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.but_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuDGV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // but_Show
            // 
            this.but_Show.BackColor = System.Drawing.Color.Transparent;
            this.but_Show.Image = ((System.Drawing.Image)(resources.GetObject("but_Show.Image")));
            this.but_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Show.Location = new System.Drawing.Point(40, 443);
            this.but_Show.Margin = new System.Windows.Forms.Padding(4);
            this.but_Show.Name = "but_Show";
            this.but_Show.Size = new System.Drawing.Size(90, 36);
            this.but_Show.TabIndex = 10;
            this.but_Show.Text = "Hiển thị";
            this.but_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Show.UseVisualStyleBackColor = false;
            this.but_Show.Click += new System.EventHandler(this.but_Show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(384, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(384, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính";
            // 
            // but_Add
            // 
            this.but_Add.BackColor = System.Drawing.Color.Transparent;
            this.but_Add.Image = ((System.Drawing.Image)(resources.GetObject("but_Add.Image")));
            this.but_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Add.Location = new System.Drawing.Point(179, 443);
            this.but_Add.Margin = new System.Windows.Forms.Padding(4);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(90, 36);
            this.but_Add.TabIndex = 11;
            this.but_Add.Text = "Thêm";
            this.but_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Add.UseVisualStyleBackColor = false;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // txt_MaQL
            // 
            this.txt_MaQL.Location = new System.Drawing.Point(119, 18);
            this.txt_MaQL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaQL.Name = "txt_MaQL";
            this.txt_MaQL.ReadOnly = true;
            this.txt_MaQL.Size = new System.Drawing.Size(217, 24);
            this.txt_MaQL.TabIndex = 1;
            // 
            // txt_TenQL
            // 
            this.txt_TenQL.Location = new System.Drawing.Point(119, 59);
            this.txt_TenQL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenQL.Name = "txt_TenQL";
            this.txt_TenQL.Size = new System.Drawing.Size(217, 24);
            this.txt_TenQL.TabIndex = 2;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(500, 19);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(217, 24);
            this.txt_SDT.TabIndex = 4;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 100);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.BackColor = System.Drawing.Color.Transparent;
            this.rb_Male.Location = new System.Drawing.Point(500, 57);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(58, 22);
            this.rb_Male.TabIndex = 5;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = false;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.BackColor = System.Drawing.Color.Transparent;
            this.rb_Female.Location = new System.Drawing.Point(627, 57);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(45, 22);
            this.rb_Female.TabIndex = 6;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = false;
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
            this.dgv.Size = new System.Drawing.Size(706, 263);
            this.dgv.TabIndex = 9;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
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
            // but_Search
            // 
            this.but_Search.BackColor = System.Drawing.Color.Transparent;
            this.but_Search.Image = ((System.Drawing.Image)(resources.GetObject("but_Search.Image")));
            this.but_Search.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.but_Search.Location = new System.Drawing.Point(387, 101);
            this.but_Search.Margin = new System.Windows.Forms.Padding(4);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(90, 36);
            this.but_Search.TabIndex = 7;
            this.but_Search.Text = "Tìm kiếm";
            this.but_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Search.UseVisualStyleBackColor = false;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // but_Update
            // 
            this.but_Update.BackColor = System.Drawing.Color.Transparent;
            this.but_Update.Image = ((System.Drawing.Image)(resources.GetObject("but_Update.Image")));
            this.but_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Update.Location = new System.Drawing.Point(318, 443);
            this.but_Update.Margin = new System.Windows.Forms.Padding(4);
            this.but_Update.Name = "but_Update";
            this.but_Update.Size = new System.Drawing.Size(90, 36);
            this.but_Update.TabIndex = 12;
            this.but_Update.Text = "Cập nhật";
            this.but_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Update.UseVisualStyleBackColor = false;
            this.but_Update.Click += new System.EventHandler(this.but_Update_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(500, 102);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(217, 24);
            this.txt_Search.TabIndex = 8;
            // 
            // but_Cancel
            // 
            this.but_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.but_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("but_Cancel.Image")));
            this.but_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Cancel.Location = new System.Drawing.Point(596, 444);
            this.but_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(90, 36);
            this.but_Cancel.TabIndex = 14;
            this.but_Cancel.Text = "Thoát";
            this.but_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Cancel.UseVisualStyleBackColor = false;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // but_Delete
            // 
            this.but_Delete.BackColor = System.Drawing.Color.Transparent;
            this.but_Delete.Image = ((System.Drawing.Image)(resources.GetObject("but_Delete.Image")));
            this.but_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Delete.Location = new System.Drawing.Point(457, 444);
            this.but_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.but_Delete.Name = "but_Delete";
            this.but_Delete.Size = new System.Drawing.Size(90, 36);
            this.but_Delete.TabIndex = 13;
            this.but_Delete.Text = "Xóa";
            this.but_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Delete.UseVisualStyleBackColor = false;
            this.but_Delete.Click += new System.EventHandler(this.but_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(3, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 294);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // NguoiQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_Delete);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.but_Update);
            this.Controls.Add(this.but_Search);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NguoiQLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người Quản Lý";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NguoiQLForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuDGV.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.Button but_Update;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.Button but_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip menuDGV;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}