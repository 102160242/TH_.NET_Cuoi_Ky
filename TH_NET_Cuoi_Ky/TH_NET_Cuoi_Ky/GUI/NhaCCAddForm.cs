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
    public partial class NhaCCAddForm : Form
    {
        public delegate void dd();
        public delegate void dd2(string s);

        public dd BackToPreviousForm;
        public dd2 returnTenNCC;
        NhaCC_BLL nhaCC_BLL;
        private bool allow = false;
        public NhaCCAddForm()
        {
            InitializeComponent();
            this.nhaCC_BLL = new NhaCC_BLL();
        }
        //private void LoadCBB()
        //{
        //    foreach(string i in nhaCC_BLL.loadCBBDiaChiNCC())
        //    {
        //        if (cbbAddress.FindStringExact(i) < 0)
        //        {
        //            cbbAddress.Items.Add(i);
        //        }
        //    }
        //}

        private void butOK_Click(object sender, EventArgs e)
        {
            if(txtTenNhaCC.Text == "" || cbbAddress.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            List<DTO.NhaCC> l = new List<DTO.NhaCC>();
            l.Add(new DTO.NhaCC
            {
                TenNhaCC = txtTenNhaCC.Text,
                DiaChi = cbbAddress.SelectedItem == null ? cbbAddress.Text : cbbAddress.SelectedItem.ToString(),
            });
            (bool result, string msg) = nhaCC_BLL.addNhaCC(l);
            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                BackToPreviousForm();
                if (this.allow) returnTenNCC(txtTenNhaCC.Text);
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

        private void NhaCCAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        private void NhaCCAddForm_Shown(object sender, EventArgs e)
        {
            loadCBB.RunWorkerAsync();
        }

        private void loadCBB_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in nhaCC_BLL.loadCBBDiaChiNCC())
            {
                if (cbbAddress.FindStringExact(i) < 0)
                {
                    cbbAddress.Invoke(new Action(() => { cbbAddress.Items.Add(i); }));
                }
            }
        }

        internal void allowtoReturnTenNCC(bool v)
        {
            this.allow = v;
        }

        private void NhaCCAddForm_KeyDown(object sender, KeyEventArgs e)
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
