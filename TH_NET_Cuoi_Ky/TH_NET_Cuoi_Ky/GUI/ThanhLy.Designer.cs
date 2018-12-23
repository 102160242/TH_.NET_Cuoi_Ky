namespace TH_NET_Cuoi_Ky.GUI
{
    partial class ThanhLy
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_TinhTrangNhap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbb_TenTSNhap = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_PhongNhap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_NhaCCNhap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 84;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 83;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_TinhTrangNhap
            // 
            this.txt_TinhTrangNhap.Location = new System.Drawing.Point(134, 205);
            this.txt_TinhTrangNhap.Name = "txt_TinhTrangNhap";
            this.txt_TinhTrangNhap.Size = new System.Drawing.Size(168, 24);
            this.txt_TinhTrangNhap.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 79;
            this.label13.Text = "Tình Trạng";
            // 
            // cbb_TenTSNhap
            // 
            this.cbb_TenTSNhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_TenTSNhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_TenTSNhap.FormattingEnabled = true;
            this.cbb_TenTSNhap.Location = new System.Drawing.Point(134, 5);
            this.cbb_TenTSNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_TenTSNhap.Name = "cbb_TenTSNhap";
            this.cbb_TenTSNhap.Size = new System.Drawing.Size(168, 26);
            this.cbb_TenTSNhap.TabIndex = 76;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 165);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 24);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "Ngày Xuất";
            // 
            // cbb_PhongNhap
            // 
            this.cbb_PhongNhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_PhongNhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_PhongNhap.FormattingEnabled = true;
            this.cbb_PhongNhap.Location = new System.Drawing.Point(134, 45);
            this.cbb_PhongNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_PhongNhap.Name = "cbb_PhongNhap";
            this.cbb_PhongNhap.Size = new System.Drawing.Size(168, 26);
            this.cbb_PhongNhap.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Phòng Xuất";
            // 
            // cbb_NhaCCNhap
            // 
            this.cbb_NhaCCNhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_NhaCCNhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_NhaCCNhap.FormattingEnabled = true;
            this.cbb_NhaCCNhap.Location = new System.Drawing.Point(134, 85);
            this.cbb_NhaCCNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_NhaCCNhap.Name = "cbb_NhaCCNhap";
            this.cbb_NhaCCNhap.Size = new System.Drawing.Size(168, 26);
            this.cbb_NhaCCNhap.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Tên tài sản";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Location = new System.Drawing.Point(136, 125);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(168, 24);
            this.txt_GiaNhap.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 85;
            this.label4.Text = "Nguyên Giá";
            // 
            // ThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 295);
            this.Controls.Add(this.txt_GiaNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_TinhTrangNhap);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbb_TenTSNhap);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_PhongNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_NhaCCNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ThanhLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Lý";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThanhLy_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_TinhTrangNhap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbb_TenTSNhap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_PhongNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_NhaCCNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Label label4;
    }
}