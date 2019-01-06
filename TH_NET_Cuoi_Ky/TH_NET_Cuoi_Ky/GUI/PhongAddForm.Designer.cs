namespace TH_NET_Cuoi_Ky.GUI
{
    partial class PhongAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongAddForm));
            this.but_Cancel = new System.Windows.Forms.Button();
            this.but_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNguoiQL = new System.Windows.Forms.ComboBox();
            this.loadCBB = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // but_Cancel
            // 
            this.but_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.but_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("but_Cancel.Image")));
            this.but_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_Cancel.Location = new System.Drawing.Point(280, 135);
            this.but_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(96, 32);
            this.but_Cancel.TabIndex = 4;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_Cancel.UseVisualStyleBackColor = false;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // but_OK
            // 
            this.but_OK.BackColor = System.Drawing.Color.Transparent;
            this.but_OK.Image = ((System.Drawing.Image)(resources.GetObject("but_OK.Image")));
            this.but_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_OK.Location = new System.Drawing.Point(27, 135);
            this.but_OK.Margin = new System.Windows.Forms.Padding(4);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(96, 32);
            this.but_OK.TabIndex = 35;
            this.but_OK.Text = "OK";
            this.but_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_OK.UseVisualStyleBackColor = false;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Người Quản Lý";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(150, 21);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(226, 24);
            this.txtTenPhong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên Phòng";
            // 
            // cbbNguoiQL
            // 
            this.cbbNguoiQL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbNguoiQL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNguoiQL.FormattingEnabled = true;
            this.cbbNguoiQL.Location = new System.Drawing.Point(150, 81);
            this.cbbNguoiQL.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNguoiQL.Name = "cbbNguoiQL";
            this.cbbNguoiQL.Size = new System.Drawing.Size(226, 26);
            this.cbbNguoiQL.TabIndex = 2;
            // 
            // loadCBB
            // 
            this.loadCBB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCBB_DoWork);
            // 
            // PhongAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 176);
            this.Controls.Add(this.cbbNguoiQL);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PhongAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhongAddForm_FormClosed);
            this.Shown += new System.EventHandler(this.PhongAddForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNguoiQL;
        private System.ComponentModel.BackgroundWorker loadCBB;
    }
}