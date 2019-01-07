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
    public partial class NuocSXForm : Form
    {
        public delegate void dd();
        public dd BackToPreviousForm;
        NuocSX_BLL NSX_BLL;
        public NuocSXForm()
        {
            InitializeComponent();
            NSX_BLL = new BLL.NuocSX_BLL();
        }

        private void NuocSXForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void ShowNuocSX()
        {
            dgv.DataSource = NSX_BLL.Show_BLL();
        }
        private void Reload()
        {
            ShowNuocSX();
            //this.Visible = true; // Hien thi lai form
        }
        private void but_Show_Click(object sender, EventArgs e)
        {
            ShowNuocSX();
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = NSX_BLL.Show_BLL(txt_Search.Text);
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            if (txtMaNSX.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Nước cần sửa!");
                return;
            }
            if(txtTenNSX.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            (bool result, string msg) = NSX_BLL.updateTS(new DTO.NuocSX
            {
                MaNuocSX = Convert.ToInt32(txtMaNSX.Text),
                TenNuocSX = txtTenNSX.Text
            });

            MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

            dgv.DataSource = NSX_BLL.Show_BLL(); // Refresh lai du lieu tren DataGridView
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            this.deleteToolStripMenuItem_Click(sender, e);
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            NuocSXAddform f = new NuocSXAddform();
            f.BackToPreviousForm += Reload;
            f.ShowDialog();
            //this.Visible = false; // Tam an form
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.updateToolStripMenuItem_Click(sender, e);
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            BackToPreviousForm();
            Dispose();
        }

        private void NuocSXForm_FormClosed(object sender, FormClosedEventArgs e)
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
            List<DTO.NuocSX> l = NSX_BLL.getNSXByID(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaNuocSX"].Value.ToString()));
            txtMaNSX.Text = l[0].MaNuocSX.ToString();
            txtTenNSX.Text = l[0].TenNuocSX.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng cần xóa!");
            }
            else
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa (các) hàng đã chọn?",
                         "Xác nhận xóa dữ liệu!",
                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Add MaTS cua cac hang duoc chon vao list
                    List<int> l = new List<int>();
                    foreach (DataGridViewRow r in dgv.SelectedRows)
                    {
                        l.Add(Convert.ToInt32(r.Cells["MaNuocSX"].Value.ToString()));
                    }
                    (bool result, string msg) = NSX_BLL.deleteTS(l);

                    MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

                    dgv.DataSource = NSX_BLL.Show_BLL(); // Refresh lai du lieu tren DataGridView
                }
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count > 0)
            {
                but_Update.Enabled = true;
                but_Delete.Enabled = true;
            }
            else
            {
                but_Update.Enabled = false;
                but_Delete.Enabled = false;
            }
        }

        private void NuocSXForm_KeyDown(object sender, KeyEventArgs e)
        {
            // To hop Ctrl + N => Tao moi
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                this.but_Add_Click(sender, e);
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // Neu bam nut Delete khi dang o tren dgv
            {
                this.deleteToolStripMenuItem_Click(sender, e);
            }
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.but_Search_Click(sender, e);
            }
        }

        private void txtTenNSX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.but_Update_Click(sender, e);
            }
        }
    }
}
