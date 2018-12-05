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
        public dd ShowForm;
        LoaiTS_BLL LoaiTS_BLL;
        public LoaiTSForm()
        {
            InitializeComponent();
            this.LoaiTS_BLL = new LoaiTS_BLL();
        }
        private void Reload()
        {
            ShowLoaiTS();
            this.Visible = true;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            LoaiTSAddForm f = new LoaiTSAddForm();
            f.ReloadLoaiTS += Reload;
            f.Show();
            this.Visible = false;
            
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
                Boolean result = LoaiTS_BLL.deleteLoaiTS(l);
                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại sau!");
                }
                ShowLoaiTS();// Refresh lai du lieu tren DataGridView
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiTS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại Tài sản cần sửa!");
            }
            else
            {
                Boolean result = LoaiTS_BLL.updateLoaiTS(new DTO.LoaiTS
                {
                    MaLoaiTS = Convert.ToInt32(txtMaLoaiTS.Text),
                    TenLoaiTS = txtTenLoaiTS.Text,
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
            ShowLoaiTS();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO.LoaiTS> list = LoaiTS_BLL.getLoaiTSByID(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaLoaiTS"].Value.ToString()));
            txtMaLoaiTS.Text = list[0].MaLoaiTS.ToString();
            txtTenLoaiTS.Text = list[0].TenLoaiTS;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ShowForm();
            Dispose();
        }

        private void LoaiTSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowForm();
            Dispose();
        }
    }
}
