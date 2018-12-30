using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_NET_Cuoi_Ky.GUI
{
    public partial class NuocSXAddform : Form
    {
        public delegate void dd();
        public dd BackToPreviousForm;
        BLL.NuocSX_BLL NSX_BLL;
        public NuocSXAddform()
        {
            InitializeComponent();
            NSX_BLL = new BLL.NuocSX_BLL();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtTenNSX.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            List<DTO.NuocSX> l = new List<DTO.NuocSX>();
            l.Add(new DTO.NuocSX
            {
                TenNuocSX = txtTenNSX.Text,
            });
            (bool result, string msg) = NSX_BLL.addNSX(l);

            if (result)
            {
                // Neu add thanh cong thi hien lai Form Nuoc SX
                BackToPreviousForm();
                Dispose();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BackToPreviousForm();
            Dispose();
        }

        private void NuocSXAddform_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToPreviousForm();
            Dispose();
        }
    }
}
