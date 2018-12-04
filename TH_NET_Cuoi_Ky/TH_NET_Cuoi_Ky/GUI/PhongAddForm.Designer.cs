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
            this.but_Cancel = new System.Windows.Forms.Button();
            this.but_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNguoiQL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // but_Cancel
            // 
            this.but_Cancel.Location = new System.Drawing.Point(221, 92);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(75, 23);
            this.but_Cancel.TabIndex = 36;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(15, 92);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 35;
            this.but_OK.Text = "OK";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Người Quản Lý";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(96, 12);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(200, 20);
            this.txtTenPhong.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên Phòng";
            // 
            // cbbNguoiQL
            // 
            this.cbbNguoiQL.FormattingEnabled = true;
            this.cbbNguoiQL.Location = new System.Drawing.Point(96, 57);
            this.cbbNguoiQL.Name = "cbbNguoiQL";
            this.cbbNguoiQL.Size = new System.Drawing.Size(200, 21);
            this.cbbNguoiQL.TabIndex = 39;
            // 
            // PhongAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 124);
            this.Controls.Add(this.cbbNguoiQL);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.label1);
            this.Name = "PhongAddForm";
            this.Text = "PhongAddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhongAddForm_FormClosed);
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
    }
}