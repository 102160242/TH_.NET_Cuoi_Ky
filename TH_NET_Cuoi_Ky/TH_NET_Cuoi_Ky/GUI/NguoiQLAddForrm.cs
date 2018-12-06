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
    public partial class NguoiQLAddForrm : Form
    {
        public delegate void dd();
        public dd ShowNguoiQLForm;
        NguoiQL_BLL Nguoi_BLL;
        public NguoiQLAddForrm()
        {
            InitializeComponent();
            Nguoi_BLL = new NguoiQL_BLL();

        }
        private void but_OK_Click(object sender, EventArgs e)
        {
            Boolean result = Nguoi_BLL.addNguoiQL(new DTO.NguoiQL
            {
                TenNguoiQL = txt_TenQL.Text,
                NgaySinh = dateTimePicker1.Value,
                SoDT = txt_SDT.Text,
                GioiTinh = rb_Male.Checked,
            });
            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                ShowNguoiQLForm();
                Dispose();
            }
            else
            {
                MessageBox.Show("Không thể thêm Người quản lý mới. Vui lòng thử lại sau!");
            }
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            ShowNguoiQLForm();
            Dispose();
        }

        private void NguoiQLAddForrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowNguoiQLForm();
            Dispose();
        }

        private void NguoiQLAddForrm_Load(object sender, EventArgs e)
        {

        }
    }
}
