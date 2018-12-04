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
    public partial class PhongAddForm : Form
    {
        Phong_BLL Phong_BLL;
        NguoiQL_BLL NguoiQL_BLL;
        public delegate void dd();
        public dd ReloadPhong;
        public PhongAddForm()
        {
            InitializeComponent();
            Phong_BLL = new Phong_BLL();
            NguoiQL_BLL = new NguoiQL_BLL();
            loadCbbNguoiQL();
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            List<DTO.Phong> l = new List<DTO.Phong>();
            l.Add(new DTO.Phong {
                TenPhong = txtTenPhong.Text,
                MaNguoiQL = Phong_BLL.GetMaNQL(cbbNguoiQL.SelectedItem.ToString())
            });
            Boolean phong = Phong_BLL.AddPhong(l);
            if (phong)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                ReloadPhong();
                Dispose();
            }
            else
            {
                MessageBox.Show("Không thể thêm Người quản lý mới. Vui lòng thử lại sau!");
            }
        }
        private void loadCbbNguoiQL()
        {
            foreach(string i in NguoiQL_BLL.loadcbb())
            {
                if (cbbNguoiQL.FindStringExact(i) < 0)
                    cbbNguoiQL.Items.Add(i);
            }
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            ReloadPhong();
            Dispose();
        }

        private void PhongAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadPhong();
            Dispose();
        }
    }
}
