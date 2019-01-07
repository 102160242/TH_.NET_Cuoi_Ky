using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH_NET_Cuoi_Ky.BLL;

namespace TH_NET_Cuoi_Ky.GUI
{
    
    public partial class LoaiTSAddForm : Form
    {
        public delegate void dd();
        public delegate void dd2(string s);
        public dd2 returnTenLoaiTS;
        public dd BackToPreviousForm;   
        LoaiTS_BLL LoaiTS_BLL;
        private bool allow = false;

        public LoaiTSAddForm()
        {
            InitializeComponent();
            LoaiTS_BLL = new LoaiTS_BLL();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if(txtTenLoaiTS.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            List<DTO.LoaiTS> l = new List<DTO.LoaiTS>();
            l.Add(new DTO.LoaiTS
            {
                TenLoaiTS = txtTenLoaiTS.Text,
            });
            (bool result, string msg) = LoaiTS_BLL.addLoaiTS(l);
            if (result)
            {
                // Neu add thanh cong thi hien lai Form Loai Tai San
                BackToPreviousForm();
                if (this.allow) returnTenLoaiTS(txtTenLoaiTS.Text);
                Dispose();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");               
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        private void LoaiTSAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        internal void allowtoReturnTenLoaiTS(bool v)
        {
            this.allow = v;
        }

        private void LoaiTSAddForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter de add
            {
                this.butOK_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape) // Thoat neu nhan Esc
            {
                this.butCancel_Click(sender, e);
            }
        }
    }
}
