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
        public dd BackToPreviousForm;
        NguoiQL_BLL Nguoi_BLL;
        public NguoiQLAddForrm()
        {
            InitializeComponent();
            Nguoi_BLL = new NguoiQL_BLL();

        }
        private void but_OK_Click(object sender, EventArgs e)
        {
            if(txt_TenQL.Text == "" || txt_SDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return;
            }
            List<DTO.NguoiQL> l = new List<DTO.NguoiQL>();
            l.Add(new DTO.NguoiQL
            {
                TenNguoiQL = txt_TenQL.Text,
                NgaySinh = dateTimePicker1.Value.Date,
                SoDT = txt_SDT.Text,
                GioiTinh = rb_Male.Checked,
            });
            (bool result, string msg) = Nguoi_BLL.addNguoiQL(l);
            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                BackToPreviousForm();
                Dispose();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi!");
            }
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        private void NguoiQLAddForrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        private void NguoiQLAddForrm_Load(object sender, EventArgs e)
        {

        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Khong cho nhap chu cai
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
