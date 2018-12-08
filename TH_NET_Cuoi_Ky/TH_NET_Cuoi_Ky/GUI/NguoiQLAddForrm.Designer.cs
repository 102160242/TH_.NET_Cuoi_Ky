namespace TH_NET_Cuoi_Ky.GUI
{
    partial class NguoiQLAddForrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguoiQLAddForrm));
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenQL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.but_OK = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.BackColor = System.Drawing.Color.Transparent;
            this.rb_Female.Location = new System.Drawing.Point(299, 153);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(45, 22);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = false;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.BackColor = System.Drawing.Color.Transparent;
            this.rb_Male.Checked = true;
            this.rb_Male.Location = new System.Drawing.Point(169, 153);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(58, 22);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = false;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(130, 108);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(258, 24);
            this.txt_SDT.TabIndex = 3;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_TenQL
            // 
            this.txt_TenQL.Location = new System.Drawing.Point(130, 20);
            this.txt_TenQL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenQL.Name = "txt_TenQL";
            this.txt_TenQL.Size = new System.Drawing.Size(258, 24);
            this.txt_TenQL.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Họ và Tên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 65);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 24);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày sinh";
            // 
            // but_OK
            // 
            this.but_OK.BackColor = System.Drawing.Color.Transparent;
            this.but_OK.Image = ((System.Drawing.Image)(resources.GetObject("but_OK.Image")));
            this.but_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_OK.Location = new System.Drawing.Point(78, 195);
            this.but_OK.Margin = new System.Windows.Forms.Padding(4);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(69, 32);
            this.but_OK.TabIndex = 6;
            this.but_OK.Text = "OK";
            this.but_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_OK.UseVisualStyleBackColor = false;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // but_Cancel
            // 
            this.but_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.but_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("but_Cancel.Image")));
            this.but_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Cancel.Location = new System.Drawing.Point(246, 195);
            this.but_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(89, 32);
            this.but_Cancel.TabIndex = 7;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Cancel.UseVisualStyleBackColor = false;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // NguoiQLAddForrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 235);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_Female);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenQL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NguoiQLAddForrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Người Quản Lý";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NguoiQLAddForrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenQL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Button but_Cancel;
    }
}