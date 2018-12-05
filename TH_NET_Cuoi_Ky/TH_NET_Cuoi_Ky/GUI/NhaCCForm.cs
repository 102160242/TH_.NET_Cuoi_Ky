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
    public partial class NhaCCForm : Form
    {
        public delegate void dd();
        public dd ShowForm;
        NhaCC_BLL nhaCC_BLL;
        public NhaCCForm()
        {
            InitializeComponent();
            this.nhaCC_BLL = new NhaCC_BLL();
            LoadCBB();
        }
        private void LoadCBB()
        {
            foreach (string i in nhaCC_BLL.loadCBBDiaChiNCC())
            {
                if (cbbAddress.FindStringExact(i) < 0)
                {
                    cbbAddress.Items.Add(i);
                }
            }
        }
        private void NhaCCForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowForm();
        }
        private void Reload()
        {
            ShowNhaCC();
            this.Visible = true;
        }
        private void ShowNhaCC()
        {
            dgv.DataSource = nhaCC_BLL.ShowNhaCC_BLL();
        }
        private void butShow_Click(object sender, EventArgs e)
        {
            ShowNhaCC();
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            ShowForm();
            Dispose();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO.NhaCC> list = nhaCC_BLL.GetNhaCCById(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaNhaCC"].Value.ToString()));
            txtMaNhaCC.Text = list[0].MaNhaCC.ToString();
            txtTenNhaCC.Text = list[0].TenNhaCC;
            cbbAddress.SelectedItem = list[0].DiaChi;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            NhaCCAddForm f = new NhaCCAddForm();
            f.ReloadNhaCC += Reload;
            f.Show();
            this.Visible = false;
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if(txtMaNhaCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Tài sản cần sửa!");
            }
            else
            {
                Boolean result = nhaCC_BLL.updateNhaCC(new DTO.NhaCC
                {
                   MaNhaCC = Convert.ToInt32(txtMaNhaCC.Text),
                   TenNhaCC = txtTenNhaCC.Text,
                   DiaChi = cbbAddress.SelectedItem == null ? cbbAddress.Text : cbbAddress.SelectedItem.ToString(),
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
            ShowNhaCC();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa (các) loại tài sản đã chọn?",
                                     "Xác nhận xóa dữ liệu!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Add MaTS cua cac hang duoc chon vao list
                List<int> l = new List<int>();
                foreach (DataGridViewRow r in dgv.SelectedRows)
                {
                    l.Add(Convert.ToInt32(r.Cells["MaNhaCC"].Value.ToString()));
                }
                Boolean result = nhaCC_BLL.deleteNhaCC(l);
                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại sau!");
                }
                ShowNhaCC();// Refresh lai du lieu tren DataGridView
            }
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = nhaCC_BLL.ShowNhaCC_BLL(txtSearch.Text);
        }
    }
}
