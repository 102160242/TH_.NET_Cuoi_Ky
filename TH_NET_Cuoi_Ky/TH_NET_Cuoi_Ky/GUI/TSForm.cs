
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

namespace TH_NET_Cuoi_Ky
{
    public partial class Form1 : Form
    {
        public delegate void dd();
        public dd ShowMainForm;
        TaiSan_BLL TS_BLL;
        Phong_BLL P_BLL;
        NhaCC_BLL NCC_BLL;
        NuocSX_BLL NSX_BLL;
        LoaiTS_BLL LTS_BLL;
        public Form1()
        {
            InitializeComponent();
            this.TS_BLL = new TaiSan_BLL();
            this.P_BLL = new Phong_BLL();
            this.NCC_BLL = new NhaCC_BLL();
            this.NSX_BLL = new NuocSX_BLL();
            this.LTS_BLL = new LoaiTS_BLL();

            // Them 2 lua chon SX vao ComboBox sap xep
            //cbbSort.Items.Add("Sắp xếp A-Z");
            //cbbSort.Items.Add("Sắp xếp Z-A");
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            ShowTS();
        }
        private void ShowTS()
        {
            // Hien thi tat ca, khong kem filter hoac dieu kien tim kiem
            dgv.DataSource = TS_BLL.ShowTS_BLL();
        }
        private void Reload()
        {
            ShowTS(); // Load lai du lieu cho DataGridView
            this.Visible = true; // Hien thi lai form
        }
        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.updateToolStripMenuItem_Click(sender, e);   
        }
        // CBB
        private void loadAllCBB()
        {
            //this.loadCBBPhong();
            //this.loadCBBNhaCC();
            this.loadCBBNuocSX();
            this.loadCBBLoaiTS();
        }
        //private void loadCBBPhong()
        //{
        //    foreach (string i in P_BLL.loadCBB_BLL())
        //    {
        //        if (cbbPhong.FindStringExact(i) < 0)
        //        {
        //            cbbPhong.Items.Add(i);
        //        }
        //    }
        //}
        //private void loadCBBNhaCC()
        //{
        //    foreach (string i in NCC_BLL.loadCBB_BLL())
        //    {
        //        if (cbbNhaCC1.FindStringExact(i) < 0)
        //        {
        //            cbbNhaCC1.Items.Add(i);
        //        }
        //    }
        //}
        private void loadCBBNuocSX()
        {
            foreach (string i in NSX_BLL.loadCBB_BLL())
            {
                if (cbbNuocSX1.FindStringExact(i) < 0)
                {
                    cbbNuocSX1.Items.Add(i);
                }
                if (cbbNuocSX.FindStringExact(i) < 0)
                {
                    cbbNuocSX.Items.Add(i);
                }
            }
        }
        private void loadCBBLoaiTS()
        {
            foreach (string i in LTS_BLL.loadCBB_BLL())
            {
                if (cbbLoaiTS1.FindStringExact(i) < 0)
                {
                    cbbLoaiTS1.Items.Add(i);
                }
                if (cbbLoaiTS.FindStringExact(i) < 0)
                {
                    cbbLoaiTS.Items.Add(i);
                }
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            AddFormTS f = new AddFormTS();
            f.BackToPreviousForm += Reload;
            f.ShowDialog();
            //this.Visible = false; // Tam an form
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if(txtMaTS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Tài sản cần sửa!");
                return;
            }
            if (txtTenTS.Text == "" || txtDvTinh.Text == "" || txtTskt.Text == "" || cbbLoaiTS.SelectedIndex == -1 || cbbNuocSX.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            int maNuocSX = NSX_BLL.getIDByName(cbbNuocSX.SelectedItem.ToString());
            int maLoaiTS = LTS_BLL.getIDByName(cbbLoaiTS.SelectedItem.ToString());
            if(maNuocSX == -1 || maLoaiTS == -1)
            {
                MessageBox.Show("Không tồn tại Nước Sản Xuất hoặc Loại Tài Sản đã chọn!");
            }
            else
            {
                (bool result, string msg) = TS_BLL.updateTS(new DTO.TaiSan
                {
                    MaTS = Convert.ToInt32(txtMaTS.Text),
                    TenTS = txtTenTS.Text,
                    DVTinh = txtDvTinh.Text,
                    TSKT = txtTskt.Text,
                    MaNuocSX = maNuocSX,
                    NamSX = dateTimePicker1.Value.Year,
                    MaLoaiTS = maLoaiTS,
                    GhiChu = txtGhiChu.Text,
                });

                MessageBox.Show(msg, result ? "Thành công" : "Lỗi");
            }
            ShowTS(); // Refresh lai du lieu tren DataGridView
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            this.deleteToolStripMenuItem_Click(sender, e);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();

            // Tao List filter va tu khoa
            //if (cbbPhong1.SelectedItem != null) data["Phong"] = cbbPhong1.SelectedItem.ToString();
            //else data["Phong"] = "";
            //if (cbbNhaCC1.SelectedItem != null) data["NhaCC"] = cbbNhaCC1.SelectedItem.ToString();
            //else data["NhaCC"] = "";
            if (cbbNuocSX1.SelectedItem != null) data["NuocSX"] = cbbNuocSX1.SelectedItem.ToString();
            else data["NuocSX"] = "";
            if (cbbLoaiTS1.SelectedItem != null) data["LoaiTS"] = cbbLoaiTS1.SelectedItem.ToString();
            else data["LoaiTS"] = "";
            if (txtTuKhoa.Text != "") data["TuKhoa"] = txtTuKhoa.Text;
            else data["TuKhoa"] = "";
            dgv.DataSource = TS_BLL.SearchTS(data);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowMainForm();
            Dispose();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv2.DataSource = TS_BLL.ShowTSDetail(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaTS"].Value.ToString()));
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

        private void showDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietTSForm f = new ChiTietTSForm();
            f.ShowTSForm += Reload;
            f.ShowTSDetail(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaTS"].Value.ToString()));
            f.Show();
            this.Visible = false;
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
            tabControl1.SelectedIndex = 0; // Chuyen ve tab Hien thi & Cap nhat neu dang o tab khac
            List<DTO.TaiSan> l = TS_BLL.getTSById(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaTS"].Value.ToString()));
            txtMaTS.Text = l[0].MaTS.ToString();
            txtTenTS.Text = l[0].TenTS;
            txtDvTinh.Text = l[0].DVTinh;
            txtTskt.Text = l[0].TSKT;

            txtGhiChu.Text = l[0].GhiChu;
            cbbNuocSX.SelectedItem = l[0].NuocSX.TenNuocSX;
            cbbLoaiTS.SelectedItem = l[0].LoaiTS.TenLoaiTS;
            dateTimePicker1.Value = new DateTime(l[0].NamSX, 1, 1);
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
                        l.Add(Convert.ToInt32(r.Cells["MaTS"].Value.ToString()));
                    }
                    (bool result, string msg) = TS_BLL.deleteTS(l);

                    MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

                    ShowTS(); // Refresh lai du lieu tren DataGridView
                }
            }
        }

        private void loadCBBNSX_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in NSX_BLL.loadCBB_BLL())
            {
                if (cbbNuocSX1.FindStringExact(i) < 0)
                {
                    cbbNuocSX1.Invoke(new Action(() => {
                        cbbNuocSX1.Items.Add(i);
                    }));
                }
                if (cbbNuocSX.FindStringExact(i) < 0)
                {
                    cbbNuocSX.Invoke(new Action(() => {
                        cbbNuocSX.Items.Add(i);
                    }));
                }
            }
        }

        private void loadCBBLTS_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in LTS_BLL.loadCBB_BLL())
            {
                if (cbbLoaiTS1.FindStringExact(i) < 0)
                {
                    cbbLoaiTS1.Invoke(new Action(() => {
                        cbbLoaiTS1.Items.Add(i);
                    }));
                }
                if (cbbLoaiTS.FindStringExact(i) < 0)
                {
                    cbbLoaiTS.Invoke(new Action(() => {
                        cbbLoaiTS.Items.Add(i);
                    }));
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadCBBLTS.RunWorkerAsync();
            loadCBBNSX.RunWorkerAsync();
        }
    }
}
