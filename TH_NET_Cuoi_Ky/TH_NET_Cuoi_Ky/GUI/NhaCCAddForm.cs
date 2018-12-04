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
        public dd ReloadNhaCC;
        NhaCC_BLL nhaCC_BLL;
        public NhaCCAddForm()
        {
            InitializeComponent();
            this.nhaCC_BLL = new NhaCC_BLL();
            LoadCBB();
        }
        private void LoadCBB()
        {
            foreach(string i in nhaCC_BLL.loadCBB_BLL())
            {
                if (cbbAddress.FindStringExact(i) < 0)
                {
                    cbbAddress.Items.Add(i);
                }
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Boolean result = nhaCC_BLL.addNhaCC(new DTO.NhaCC
            {
                MaNhaCC = Convert.ToInt32(txtMaNhaCC.Text),
                TenNhaCC = txtTenNhaCC.Text,
                DiaChi =cbbAddress.SelectedItem.ToString(),
            });
            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                ReloadNhaCC();
                Dispose();
            }
            else
            {
                MessageBox.Show("Không thể thêm Người quản lý mới. Vui lòng thử lại sau!");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ReloadNhaCC();
            Dispose();
        }

        private void NhaCCAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadNhaCC();
            Dispose();
        }
    }
}
