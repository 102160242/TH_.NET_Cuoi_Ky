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
        public dd ShowMainForm;
        NhaCC_BLL nhaCC_BLL;
        public NhaCCForm()
        {
            InitializeComponent();
            this.nhaCC_BLL = new NhaCC_BLL();
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
            ShowMainForm();
            Dispose();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.updateToolStripMenuItem_Click(sender, e);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            NhaCCAddForm f = new NhaCCAddForm();
            f.ShowNhaCCForm += Reload;
            f.Show();
            this.Visible = false;
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if(txtMaNhaCC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Tài sản cần sửa!");
                return;
            }
            if (txtTenNhaCC.Text == "" || cbbAddress.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            (bool result, string msg) = nhaCC_BLL.updateNhaCC(new DTO.NhaCC
            {
                MaNhaCC = Convert.ToInt32(txtMaNhaCC.Text),
                TenNhaCC = txtTenNhaCC.Text,
                DiaChi = cbbAddress.SelectedItem == null ? cbbAddress.Text : cbbAddress.SelectedItem.ToString(),
            });

            MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

            ShowNhaCC();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            this.deleteToolStripMenuItem_Click(sender, e);
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = nhaCC_BLL.ShowNhaCC_BLL(txtSearch.Text);
        }

        private void NhaCCForm_Shown(object sender, EventArgs e)
        {
            LoadCBB();
        }

        private void NhaCCForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowMainForm();
        }

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgv.HitTest(e.X, e.Y);
                dgv.ClearSelection();
                if (hti.RowIndex != -1)
                {
                    dgv.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void menuDGV_Opening(object sender, CancelEventArgs e)
        {
            var cms = sender as ContextMenuStrip;
            var mousepos = Control.MousePosition;
            if (cms != null)
            {
                var rel_mousePos = cms.PointToClient(mousepos);
                if (cms.ClientRectangle.Contains(rel_mousePos))
                {
                    // Neu menu duoc mo bang chuot
                    var dgv_rel_mousePos = dgv.PointToClient(mousepos);
                    var hti = dgv.HitTest(dgv_rel_mousePos.X, dgv_rel_mousePos.Y);
                    if (hti.RowIndex == -1)
                    {
                        // Huy su kien khi khong co hang nao
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DTO.NhaCC> list = nhaCC_BLL.GetNhaCCById(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaNhaCC"].Value.ToString()));
            txtMaNhaCC.Text = list[0].MaNhaCC.ToString();
            txtTenNhaCC.Text = list[0].TenNhaCC;
            cbbAddress.SelectedItem = list[0].DiaChi;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
                (bool result, string msg) = nhaCC_BLL.deleteNhaCC(l);

                MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

                ShowNhaCC();// Refresh lai du lieu tren DataGridView
            }
        }
    }
}
