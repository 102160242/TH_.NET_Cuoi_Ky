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
    public partial class PhongForm : Form
    {
        public delegate void dd();
        public dd ShowMainForm;
        NguoiQL_BLL NQL_BLL;
        Phong_BLL Phong_BLL;
        public PhongForm()
        {
            InitializeComponent();
            this.Phong_BLL = new Phong_BLL();
            NQL_BLL = new NguoiQL_BLL();
            loadCBB();
        }
        private void loadCBB()
        {
            foreach (string i in NQL_BLL.loadcbb())
            {
                if (cbbNguoiQL.FindStringExact(i) < 0)
                    cbbNguoiQL.Items.Add(i);
            }
        }
        private void ShowPhong()
        {
            dgv.DataSource = Phong_BLL.ShowPhong_BLL();
        }

        private void BntShowPhong_Click(object sender, EventArgs e)
        {
            ShowPhong();
        }

        private void Reload()
        {
            ShowPhong();
            this.Visible = true;
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            PhongAddForm f = new PhongAddForm();
            f.ShowPhongForm += Reload;
            f.Show();
            this.Visible = false;
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            if (txt_MaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Phòng cần sửa!");
                return;
            }
            if(txt_TenPhong.Text == "" || cbbNguoiQL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            (bool result, string msg) = Phong_BLL.updatePhong(new DTO.Phong
            {
                MaPhong = Convert.ToInt32(txt_MaPhong.Text),
                TenPhong = txt_TenPhong.Text,
                MaNguoiQL = Phong_BLL.getIdByName(cbbNguoiQL.SelectedItem.ToString())
                    
            });

            MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

            ShowPhong();
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa (các) người quản lý đã chọn?",
                                     "Xác nhận xóa dữ liệu!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                List<int> l = new List<int>();
                foreach (DataGridViewRow r in dgv.SelectedRows)
                {
                    l.Add(Convert.ToInt32(r.Cells["MaPhong"].Value.ToString()));
                }
                (bool result, string msg) = Phong_BLL.deletePhong(l);

                MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

                ShowPhong();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO.Phong> l = Phong_BLL.getPhongById(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaPhong"].Value.ToString()));
            txt_MaPhong.Text = l[0].MaPhong.ToString();
            txt_TenPhong.Text = l[0].TenPhong;
            cbbNguoiQL.SelectedItem = l[0].NguoiQL.TenNguoiQL;
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Phong_BLL.ShowPhong_BLL(txt_Search.Text);
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            ShowMainForm();
            Dispose();
        }

        private void PhongForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowMainForm();
            Dispose();
        }
    }
}
