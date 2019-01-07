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
    public partial class LoaiTSForm : Form
    {
        public delegate void dd();
        public dd BackToPreviousForm;
        LoaiTS_BLL LoaiTS_BLL;
        public LoaiTSForm()
        {
            InitializeComponent();
            this.LoaiTS_BLL = new LoaiTS_BLL();
        }
        private void Reload()
        {
            ShowLoaiTS();
            //this.Visible = true;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            LoaiTSAddForm f = new LoaiTSAddForm();
            f.BackToPreviousForm += Reload;
            f.ShowDialog();
            //this.Visible = false;            
        }
        private void ShowLoaiTS()
        {
            dgv.DataSource = LoaiTS_BLL.Show_BLL();
        }
        private void butShow_Click(object sender, EventArgs e)
        {
            ShowLoaiTS();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            dgv.DataSource = LoaiTS_BLL.Show_BLL(txtSearch.Text);
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            this.deleteToolStripMenuItem_Click(sender, e);
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiTS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại Tài sản cần sửa!");
                return;
            }
            if (txtTenLoaiTS.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            (bool result, string msg) = LoaiTS_BLL.updateLoaiTS(new DTO.LoaiTS
            {
                MaLoaiTS = Convert.ToInt32(txtMaLoaiTS.Text),
                TenLoaiTS = txtTenLoaiTS.Text,
            });

            MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

            ShowLoaiTS();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.updateToolStripMenuItem_Click(sender, e);
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            BackToPreviousForm();
            Dispose();
        }

        private void LoaiTSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToPreviousForm();
            Dispose();
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
            List<DTO.LoaiTS> list = LoaiTS_BLL.getLoaiTSByID(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaLoaiTS"].Value.ToString()));
            txtMaLoaiTS.Text = list[0].MaLoaiTS.ToString();
            txtTenLoaiTS.Text = list[0].TenLoaiTS;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa (các) loại tài sản đã chọn?",
                                     "Xác nhận xóa dữ liệu!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Add MaLoaiTS cua cac hang duoc chon vao list
                List<int> l = new List<int>();
                foreach (DataGridViewRow r in dgv.SelectedRows)
                {
                    l.Add(Convert.ToInt32(r.Cells["MaLoaiTS"].Value.ToString()));
                }
                (bool result, string msg) = LoaiTS_BLL.deleteLoaiTS(l);

                MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

                ShowLoaiTS();// Refresh lai du lieu tren DataGridView
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                butUpdate.Enabled = true;
                butDelete.Enabled = true;
            }
            else
            {
                butUpdate.Enabled = false;
                butDelete.Enabled = false;
            }
        }

        private void LoaiTSForm_KeyDown(object sender, KeyEventArgs e)
        {
            // To hop Ctrl + N => Tao moi
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                this.butAdd_Click(sender, e);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhan Enter trong o tim kiem
            if (e.KeyCode == Keys.Enter)
            {
                this.butSearch_Click(sender, e);
            }
        }

        private void txtTenLoaiTS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.butUpdate_Click(sender, e);
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // Neu bam nut Delete khi dang o tren dgv
            {
                this.deleteToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
