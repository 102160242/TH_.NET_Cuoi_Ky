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
    public partial class NguoiQLForm : Form
    {
        public delegate void dd();
        public dd ShowMainForm;

        NguoiQL_BLL Nguoi_BLL;
        public NguoiQLForm()
        {
            InitializeComponent();
            this.Nguoi_BLL = new NguoiQL_BLL();
        }
        private void but_Cancel_Click(object sender, EventArgs e)
        {
            ShowMainForm();
            Dispose();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO.NguoiQL> list = Nguoi_BLL.GetNguoiQLById(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaNguoiQL"].Value.ToString()));
            txt_MaQL.Text = list[0].MaNguoiQL.ToString();
            txt_TenQL.Text = list[0].TenNguoiQL;
            dateTimePicker1.Value = list[0].NgaySinh;
            txt_SDT.Text = list[0].SoDT;
            if (list[0].GioiTinh == true) rb_Male.Checked = true;
            else rb_Female.Checked = true;

        }
        private void  ShowNguoiQL()
        {
            dgv.DataSource = Nguoi_BLL.ShowNguoiQL_BLL();

        }
        private void but_Show_Click(object sender, EventArgs e)
        {
            ShowNguoiQL();
        }
        private void Reload()
        {
            ShowNguoiQL();
            this.Visible = true;
        }
        private void but_Add_Click(object sender, EventArgs e)
        {
            NguoiQLAddForrm f = new NguoiQLAddForrm();
            f.ShowNguoiQLForm += Reload;
            f.Show();
            this.Visible = false;
        }


        private void NguoiQLForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowMainForm();
            Dispose();
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            if (txt_MaQL.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Tài sản cần sửa!");
            }
            else
            {
                    Boolean result = Nguoi_BLL.updateNguoiQL (new DTO.NguoiQL
                    {
                        MaNguoiQL = Convert.ToInt32(txt_MaQL.Text),
                        TenNguoiQL = txt_TenQL.Text,
                        NgaySinh = dateTimePicker1.Value,
                        SoDT = txt_SDT.Text,
                        GioiTinh = rb_Male.Checked,
                    });
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại sau!");
                    }
                }
            ShowNguoiQL();
            }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa (các) người quản lý đã chọn?",
                                     "Xác nhận xóa dữ liệu!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Add MaTS cua cac hang duoc chon vao list
                List<int> l = new List<int>();
                foreach (DataGridViewRow r in dgv.SelectedRows)
                {
                    l.Add(Convert.ToInt32(r.Cells["MaNguoiQL"].Value.ToString()));
                }
                Boolean result = Nguoi_BLL.deleteNguoiQL(l);
                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại sau!");
                }
                ShowNguoiQL(); // Refresh lai du lieu tren DataGridView
            }
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Nguoi_BLL.ShowNguoiQL_BLL(txt_Search.Text);
        }
    }
    }
