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
        public dd ReloadLoaiTS;
        LoaiTS_BLL LoaiTS_BLL;
        public LoaiTSAddForm()
        {
            InitializeComponent();
            LoaiTS_BLL = new LoaiTS_BLL();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            List<DTO.LoaiTS> l = new List<DTO.LoaiTS>();
            l.Add(new DTO.LoaiTS
            {
                TenLoaiTS = txtTenLoaiTS.Text,
            });
            Boolean result = LoaiTS_BLL.addLoaiTS(l);
            if (result)
            {
                // Neu add thanh cong thi hien lai Form Loai Tai San
                ReloadLoaiTS();
                Dispose();
            }
            else
            {
                MessageBox.Show("Không thể thêm Loại Tài Sản mới. Vui lòng thử lại sau!");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ReloadLoaiTS();
            Dispose();
        }

        private void LoaiTSAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadLoaiTS();
            Dispose();
        }
    }
}
