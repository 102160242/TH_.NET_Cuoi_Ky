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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.btnNuocSX = new System.Windows.Forms.Button();
            this.btnNhaCC = new System.Windows.Forms.Button();
            this.btnNhapXuat = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnNguoiQL = new System.Windows.Forms.Button();
            this.btnLoaiTS = new System.Windows.Forms.Button();
            this.btnTS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.btnNuocSX);
            this.groupBox1.Controls.Add(this.btnNhaCC);
            this.groupBox1.Controls.Add(this.btnNhapXuat);
            this.groupBox1.Controls.Add(this.btnPhong);
            this.groupBox1.Controls.Add(this.btnNguoiQL);
            this.groupBox1.Controls.Add(this.btnLoaiTS);
            this.groupBox1.Controls.Add(this.btnTS);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lựa chọn";
            // 
            // butCancel
            // 
            this.butCancel.Image = ((System.Drawing.Image)(resources.GetObject("butCancel.Image")));
            this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCancel.Location = new System.Drawing.Point(485, 103);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 14;
            this.butCancel.Text = "Thoát";
            this.butCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // btnNuocSX
            // 
            this.btnNuocSX.Location = new System.Drawing.Point(321, 103);
            this.btnNuocSX.Name = "btnNuocSX";
            this.btnNuocSX.Size = new System.Drawing.Size(94, 23);
            this.btnNuocSX.TabIndex = 13;
            this.btnNuocSX.Text = "Nước Sản Xuất";
            this.btnNuocSX.UseVisualStyleBackColor = true;
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.Location = new System.Drawing.Point(180, 103);
            this.btnNhaCC.Name = "btnNhaCC";
            this.btnNhaCC.Size = new System.Drawing.Size(88, 23);
            this.btnNhaCC.TabIndex = 12;
            this.btnNhaCC.Text = "Nhà Cung Cấp";
            this.btnNhaCC.UseVisualStyleBackColor = true;
            // 
            // btnNhapXuat
            // 
            this.btnNhapXuat.Location = new System.Drawing.Point(34, 103);
            this.btnNhapXuat.Name = "btnNhapXuat";
            this.btnNhapXuat.Size = new System.Drawing.Size(75, 23);
            this.btnNhapXuat.TabIndex = 11;
            this.btnNhapXuat.Text = "Nhập Xuất";
            this.btnNhapXuat.UseVisualStyleBackColor = true;
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(485, 43);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(75, 23);
            this.btnPhong.TabIndex = 10;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            // 
            // btnNguoiQL
            // 
            this.btnNguoiQL.Location = new System.Drawing.Point(321, 43);
            this.btnNguoiQL.Name = "btnNguoiQL";
            this.btnNguoiQL.Size = new System.Drawing.Size(94, 23);
            this.btnNguoiQL.TabIndex = 9;
            this.btnNguoiQL.Text = "Người Quản Lý";
            this.btnNguoiQL.UseVisualStyleBackColor = true;
            // 
            // btnLoaiTS
            // 
            this.btnLoaiTS.Location = new System.Drawing.Point(180, 43);
            this.btnLoaiTS.Name = "btnLoaiTS";
            this.btnLoaiTS.Size = new System.Drawing.Size(75, 23);
            this.btnLoaiTS.TabIndex = 8;
            this.btnLoaiTS.Text = "Loại Tài Sản";
            this.btnLoaiTS.UseVisualStyleBackColor = true;
            // 
            // btnTS
            // 
            this.btnTS.BackColor = System.Drawing.Color.Transparent;
            this.btnTS.Location = new System.Drawing.Point(34, 43);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(75, 23);
            this.btnTS.TabIndex = 7;
            this.btnTS.Text = "Tài Sản";
            this.btnTS.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 193);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cơ sở vật chất khoa Công nghệ thông tin";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button btnNuocSX;
        private System.Windows.Forms.Button btnNhaCC;
        private System.Windows.Forms.Button btnNhapXuat;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnNguoiQL;
        private System.Windows.Forms.Button btnLoaiTS;
        private System.Windows.Forms.Button btnTS;
    }
}