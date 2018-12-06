namespace TH_NET_Cuoi_Ky.GUI
{
    partial class LoaiTSAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiTSAddForm));
            this.txtTenLoaiTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenLoaiTS
            // 
            this.txtTenLoaiTS.Location = new System.Drawing.Point(163, 31);
            this.txtTenLoaiTS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiTS.Name = "txtTenLoaiTS";
            this.txtTenLoaiTS.Size = new System.Drawing.Size(217, 24);
            this.txtTenLoaiTS.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên loại tài sản";
            // 
            // butOK
            // 
            this.butOK.BackColor = System.Drawing.Color.Transparent;
            this.butOK.Image = ((System.Drawing.Image)(resources.GetObject("butOK.Image")));
            this.butOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOK.Location = new System.Drawing.Point(102, 75);
            this.butOK.Margin = new System.Windows.Forms.Padding(4);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(71, 32);
            this.butOK.TabIndex = 6;
            this.butOK.Text = "OK";
            this.butOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butOK.UseVisualStyleBackColor = false;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.Transparent;
            this.butCancel.Image = ((System.Drawing.Image)(resources.GetObject("butCancel.Image")));
            this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCancel.Location = new System.Drawing.Point(237, 75);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(97, 32);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "Cancel";
            this.butCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // LoaiTSAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 130);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.txtTenLoaiTS);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoaiTSAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại tài sản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoaiTSAddForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLoaiTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
    }
}