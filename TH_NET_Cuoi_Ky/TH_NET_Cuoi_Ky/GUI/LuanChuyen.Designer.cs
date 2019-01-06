namespace TH_NET_Cuoi_Ky.GUI
{
    partial class LuanChuyen
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
            this.txt_TinhTrangNhap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_SLNhap = new System.Windows.Forms.NumericUpDown();
            this.cbb_TenTS = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_PhongXuat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_NhaCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPhongNhap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.loadCBBTS = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SLNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TinhTrangNhap
            // 
            this.txt_TinhTrangNhap.Location = new System.Drawing.Point(134, 245);
            this.txt_TinhTrangNhap.Name = "txt_TinhTrangNhap";
            this.txt_TinhTrangNhap.Size = new System.Drawing.Size(168, 24);
            this.txt_TinhTrangNhap.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 62;
            this.label13.Text = "Tình Trạng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 61;
            this.label11.Text = "Số Lượng";
            // 
            // numericUpDown_SLNhap
            // 
            this.numericUpDown_SLNhap.Location = new System.Drawing.Point(134, 165);
            this.numericUpDown_SLNhap.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_SLNhap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SLNhap.Name = "numericUpDown_SLNhap";
            this.numericUpDown_SLNhap.Size = new System.Drawing.Size(168, 24);
            this.numericUpDown_SLNhap.TabIndex = 5;
            // 
            // cbb_TenTS
            // 
            this.cbb_TenTS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_TenTS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_TenTS.FormattingEnabled = true;
            this.cbb_TenTS.Location = new System.Drawing.Point(134, 5);
            this.cbb_TenTS.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_TenTS.Name = "cbb_TenTS";
            this.cbb_TenTS.Size = new System.Drawing.Size(168, 26);
            this.cbb_TenTS.TabIndex = 1;
            this.cbb_TenTS.SelectedIndexChanged += new System.EventHandler(this.cbb_TenTS_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 205);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 24);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ngày Chuyển";
            // 
            // cbb_PhongXuat
            // 
            this.cbb_PhongXuat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_PhongXuat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_PhongXuat.Enabled = false;
            this.cbb_PhongXuat.FormattingEnabled = true;
            this.cbb_PhongXuat.Location = new System.Drawing.Point(134, 45);
            this.cbb_PhongXuat.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_PhongXuat.Name = "cbb_PhongXuat";
            this.cbb_PhongXuat.Size = new System.Drawing.Size(168, 26);
            this.cbb_PhongXuat.TabIndex = 2;
            this.cbb_PhongXuat.SelectedIndexChanged += new System.EventHandler(this.cbb_PhongXuat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Phòng Xuất";
            // 
            // cbb_NhaCC
            // 
            this.cbb_NhaCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_NhaCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_NhaCC.Enabled = false;
            this.cbb_NhaCC.FormattingEnabled = true;
            this.cbb_NhaCC.Location = new System.Drawing.Point(134, 85);
            this.cbb_NhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_NhaCC.Name = "cbb_NhaCC";
            this.cbb_NhaCC.Size = new System.Drawing.Size(168, 26);
            this.cbb_NhaCC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 52;
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
            this.label7.TabIndex = 51;
            this.label7.Text = "Tên tài sản";
            // 
            // cbbPhongNhap
            // 
            this.cbbPhongNhap.Enabled = false;
            this.cbbPhongNhap.FormattingEnabled = true;
            this.cbbPhongNhap.Location = new System.Drawing.Point(134, 125);
            this.cbbPhongNhap.Name = "cbbPhongNhap";
            this.cbbPhongNhap.Size = new System.Drawing.Size(168, 26);
            this.cbbPhongNhap.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Phòng nhập";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(18, 291);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // loadCBBTS
            // 
            this.loadCBBTS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCBBTS_DoWork);
            // 
            // LuanChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 325);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbPhongNhap);
            this.Controls.Add(this.txt_TinhTrangNhap);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown_SLNhap);
            this.Controls.Add(this.cbb_TenTS);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_PhongXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_NhaCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LuanChuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luân Chuyển";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LuanChuyen_FormClosed);
            this.Shown += new System.EventHandler(this.LuanChuyen_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LuanChuyen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SLNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TinhTrangNhap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_SLNhap;
        private System.Windows.Forms.ComboBox cbb_TenTS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_PhongXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_NhaCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbPhongNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.ComponentModel.BackgroundWorker loadCBBTS;
    }
}