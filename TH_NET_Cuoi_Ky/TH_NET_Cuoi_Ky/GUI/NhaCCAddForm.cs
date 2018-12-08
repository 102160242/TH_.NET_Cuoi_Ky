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
        public dd ShowNhaCCForm;
        NhaCC_BLL nhaCC_BLL;
        public NhaCCAddForm()
        {
            InitializeComponent();
            this.nhaCC_BLL = new NhaCC_BLL();
        }
        private void LoadCBB()
        {
            foreach(string i in nhaCC_BLL.loadCBBDiaChiNCC())
            {
                if (cbbAddress.FindStringExact(i) < 0)
                {
                    cbbAddress.Items.Add(i);
                }
            }
        }

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
            Boolean result = nhaCC_BLL.addNhaCC(l);
            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                ShowNhaCCForm();
                Dispose();
            }
            else
            {
                MessageBox.Show("Không thể thêm Người quản lý mới. Vui lòng thử lại sau!");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ShowNhaCCForm();
            Dispose();
        }

        private void NhaCCAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowNhaCCForm();
            Dispose();
        }

        private void NhaCCAddForm_Shown(object sender, EventArgs e)
        {
            LoadCBB();
        }
    }
}
