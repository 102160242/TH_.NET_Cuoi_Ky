namespace TH_NET_Cuoi_Ky.GUI
{
    partial class MainForm
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
            this.btnTS = new System.Windows.Forms.Button();
            this.btnLoaiTS = new System.Windows.Forms.Button();
            this.btnNguoiQL = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnNhapXuat = new System.Windows.Forms.Button();
            this.btnNhaCC = new System.Windows.Forms.Button();
            this.btnNuocSX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTS
            // 
            this.btnTS.Location = new System.Drawing.Point(31, 39);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(75, 23);
            this.btnTS.TabIndex = 0;
            this.btnTS.Text = "Tài Sản";
            this.btnTS.UseVisualStyleBackColor = true;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // btnLoaiTS
            // 
            this.btnLoaiTS.Location = new System.Drawing.Point(177, 39);
            this.btnLoaiTS.Name = "btnLoaiTS";
            this.btnLoaiTS.Size = new System.Drawing.Size(75, 23);
            this.btnLoaiTS.TabIndex = 1;
            this.btnLoaiTS.Text = "Loại Tài Sản";
            this.btnLoaiTS.UseVisualStyleBackColor = true;
            this.btnLoaiTS.Click += new System.EventHandler(this.btnLoaiTS_Click);
            // 
            // btnNguoiQL
            // 
            this.btnNguoiQL.Location = new System.Drawing.Point(318, 39);
            this.btnNguoiQL.Name = "btnNguoiQL";
            this.btnNguoiQL.Size = new System.Drawing.Size(94, 23);
            this.btnNguoiQL.TabIndex = 2;
            this.btnNguoiQL.Text = "Người Quản Lý";
            this.btnNguoiQL.UseVisualStyleBackColor = true;
            this.btnNguoiQL.Click += new System.EventHandler(this.btnNguoiQL_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(506, 39);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(75, 23);
            this.btnPhong.TabIndex = 3;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.Location = new System.Drawing.Point(31, 99);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(75, 23);
            this.btnNhapXuat.TabIndex = 4;
            this.btnNhapXuat.Text = "Nhập Xuất";
            this.btnNhapXuat.UseVisualStyleBackColor = true;
            this.btnNhapXuat.Click += new System.EventHandler(this.btnNhapXuat_Click);
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.Location = new System.Drawing.Point(177, 99);
            this.btnNhaCC.Name = "btnNhaCC";
            this.btnNhaCC.Size = new System.Drawing.Size(88, 23);
            this.btnNhaCC.TabIndex = 5;
            this.btnNhaCC.Text = "Nhà Cung Cấp";
            this.btnNhaCC.UseVisualStyleBackColor = true;
            this.btnNhaCC.Click += new System.EventHandler(this.btnNhaCC_Click);
            // 
            // btnNuocSX
            // 
            this.btnNuocSX.Location = new System.Drawing.Point(318, 110);
            this.btnNuocSX.Name = "btnNuocSX";
            this.btnNuocSX.Size = new System.Drawing.Size(94, 23);
            this.btnNuocSX.TabIndex = 6;
            this.btnNuocSX.Text = "Nước Sản Xuất";
            this.btnNuocSX.UseVisualStyleBackColor = true;
            this.btnNuocSX.Click += new System.EventHandler(this.btnNuocSX_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 264);
            this.Controls.Add(this.btnNuocSX);
            this.Controls.Add(this.btnNhaCC);
            this.Controls.Add(this.btnNhapXuat);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnNguoiQL);
            this.Controls.Add(this.btnLoaiTS);
            this.Controls.Add(this.btnTS);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Button btnLoaiTS;
        private System.Windows.Forms.Button btnNguoiQL;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnNhapXuat;
        private System.Windows.Forms.Button btnNhaCC;
        private System.Windows.Forms.Button btnNuocSX;
    }
}