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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhLy));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbb_TenTS = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Phong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_NhaCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_NguyenGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_SL = new System.Windows.Forms.NumericUpDown();
            this.LoadCBBTS = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Image = global::TH_NET_Cuoi_Ky.Properties.Resources.but_Cancel_Image;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(240, 294);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 32);
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOK.Image = global::TH_NET_Cuoi_Ky.Properties.Resources.but_OK_Image;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(134, 294);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 32);
            this.btnOK.TabIndex = 83;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(134, 250);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(199, 24);
            this.txt_TinhTrang.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(15, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 79;
            this.label13.Text = "Tình Trạng";
            // 
            // cbb_TenTS
            // 
            this.cbb_TenTS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_TenTS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_TenTS.FormattingEnabled = true;
            this.cbb_TenTS.Location = new System.Drawing.Point(134, 10);
            this.cbb_TenTS.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_TenTS.Name = "cbb_TenTS";
            this.cbb_TenTS.Size = new System.Drawing.Size(199, 26);
            this.cbb_TenTS.Sorted = true;
            this.cbb_TenTS.TabIndex = 1;
            this.cbb_TenTS.SelectedIndexChanged += new System.EventHandler(this.cbb_TenTS_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 210);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 24);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "Ngày Xuất";
            // 
            // cbb_Phong
            // 
            this.cbb_Phong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_Phong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_Phong.Enabled = false;
            this.cbb_Phong.FormattingEnabled = true;
            this.cbb_Phong.Location = new System.Drawing.Point(134, 50);
            this.cbb_Phong.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Phong.Name = "cbb_Phong";
            this.cbb_Phong.Size = new System.Drawing.Size(199, 26);
            this.cbb_Phong.Sorted = true;
            this.cbb_Phong.TabIndex = 2;
            this.cbb_Phong.SelectedIndexChanged += new System.EventHandler(this.cbb_Phong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Phòng Xuất";
            // 
            // cbb_NhaCC
            // 
            this.cbb_NhaCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_NhaCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_NhaCC.Enabled = false;
            this.cbb_NhaCC.FormattingEnabled = true;
            this.cbb_NhaCC.Location = new System.Drawing.Point(134, 90);
            this.cbb_NhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_NhaCC.Name = "cbb_NhaCC";
            this.cbb_NhaCC.Size = new System.Drawing.Size(199, 26);
            this.cbb_NhaCC.Sorted = true;
            this.cbb_NhaCC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Tên tài sản";
            // 
            // txt_NguyenGia
            // 
            this.txt_NguyenGia.Location = new System.Drawing.Point(134, 130);
            this.txt_NguyenGia.Name = "txt_NguyenGia";
            this.txt_NguyenGia.Size = new System.Drawing.Size(199, 24);
            this.txt_NguyenGia.TabIndex = 4;
            this.txt_NguyenGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NguyenGia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 85;
            this.label4.Text = "Nguyên Giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(15, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 88;
            this.label11.Text = "Số Lượng";
            // 
            // numericUpDown_SL
            // 
            this.numericUpDown_SL.Location = new System.Drawing.Point(134, 170);
            this.numericUpDown_SL.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_SL.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SL.Name = "numericUpDown_SL";
            this.numericUpDown_SL.Size = new System.Drawing.Size(199, 24);
            this.numericUpDown_SL.TabIndex = 5;
            // 
            // LoadCBBTS
            // 
            this.LoadCBBTS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadCBBTS_DoWork_1);
            // 
            // ThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(346, 337);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown_SL);
            this.Controls.Add(this.txt_NguyenGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txt_TinhTrang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbb_TenTS);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_Phong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_NhaCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ThanhLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Lý";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThanhLy_FormClosed);
            this.Shown += new System.EventHandler(this.ThanhLy_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThanhLy_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbb_TenTS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_Phong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_NhaCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NguyenGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_SL;
        private System.ComponentModel.BackgroundWorker LoadCBBTS;
    }
}