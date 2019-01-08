
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
using TH_NET_Cuoi_Ky.GUI;

namespace TH_NET_Cuoi_Ky.GUI
{
    public partial class TSForm : Form
    {
        public delegate void dd();
        public dd ShowMainForm;
        TaiSan_BLL TS_BLL;
        Phong_BLL P_BLL;
        NhaCC_BLL NCC_BLL;
        NuocSX_BLL NSX_BLL;
        LoaiTS_BLL LTS_BLL;
        public TSForm()
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
        //private void loadCBBNuocSX()
        //{
        //    cbbNuocSX1.Items.Clear();
        //    cbbNuocSX1.Items.Add(" ** Thêm mới ** ");
        //    cbbNuocSX.Items.Clear();
        //    cbbNuocSX.Items.Add(" ** Thêm mới ** ");
        //    foreach (string i in NSX_BLL.loadCBB_BLL())
        //    {
        //        if (cbbNuocSX1.FindStringExact(i) < 0)
        //        {
        //            cbbNuocSX1.Items.Add(i);
        //        }
        //        if (cbbNuocSX.FindStringExact(i) < 0)
        //        {
        //            cbbNuocSX.Items.Add(i);
        //        }
        //    }
        //}
        //private void loadCBBLoaiTS()
        //{
        //    cbbLoaiTS.Items.Clear();
        //    cbbLoaiTS.Items.Add(" ** Thêm mới ** ");
        //    cbbLoaiTS1.Items.Clear();
        //    cbbLoaiTS1.Items.Add(" ** Thêm mới ** ");
        //    foreach (string i in LTS_BLL.loadCBB_BLL())
        //    {
        //        if (cbbLoaiTS1.FindStringExact(i) < 0)
        //        {
        //            cbbLoaiTS1.Items.Add(i);
        //        }
        //        if (cbbLoaiTS.FindStringExact(i) < 0)
        //        {
        //            cbbLoaiTS.Items.Add(i);
        //        }
        //    }
        //}
        private void addNewNuocSX(String tenNSX)
        {
            cbbNuocSX.Items.Add(tenNSX);
            cbbNuocSX.SelectedItem = tenNSX;
            cbbNuocSX1.Items.Add(tenNSX);
            cbbNuocSX1.SelectedItem = tenNSX;

        }
        private void addNewLoaiTS(String tenLoaiTS)
        {
            cbbLoaiTS.Items.Add(tenLoaiTS);
            cbbLoaiTS.SelectedItem = tenLoaiTS;
            cbbLoaiTS1.Items.Add(tenLoaiTS);
            cbbLoaiTS1.SelectedItem = tenLoaiTS;
        }

        /* ---------------- Xu ly su kien click cac button ---------------- */
        private void butShow_Click(object sender, EventArgs e)
        {
            loadDGVWorker.RunWorkerAsync();
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            TSAddForm f = new TSAddForm();
            f.BackToPreviousForm += Reload;
            f.ShowDialog();
            //this.Visible = false; // Tam an form
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaTS.Text == "")
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
            if (maNuocSX == -1 || maLoaiTS == -1)
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
            loadDGVWorker.RunWorkerAsync(); // Refresh lai du lieu tren DataGridView
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
        /* ---------------- Xu ly su kien click cac button ---------------- */

        /* ---------------- Xu ly su kien menu ---------------- */
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

                    loadDGVWorker.RunWorkerAsync(); // Refresh lai du lieu tren DataGridView
                }
            }
        }
        private void showDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int maTS = Convert.ToInt32(dgv.SelectedRows[0].Cells["MaTS"].Value.ToString());
            String tenTS = dgv.SelectedRows[0].Cells["TenTS"].Value.ToString();
            String TSKT = dgv.SelectedRows[0].Cells["TSKT"].Value.ToString();
            String DVTinh = dgv.SelectedRows[0].Cells["DVTinh"].Value.ToString();
            String NamSX = dgv.SelectedRows[0].Cells["NamSX"].Value.ToString();

            ChiTietTSForm f = new ChiTietTSForm();
            f.ShowTSForm += Reload;
            f.setMaTS(maTS);
            f.ShowTSDetail();
            f.setLabel(tenTS, TSKT, DVTinh, NamSX);
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
        /* ---------------- Xu ly su kien menu ---------------- */

        /* ---------------- Xu ly su kien cho Datagridview ---------------- */
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
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                btnDel.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnDel.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.updateToolStripMenuItem_Click(sender, e);
        }
        /* ---------------- Xu ly su kien cho Datagridview ---------------- */
    
        /* ---------------- Xu ly su kien combobox  ---------------- */

        private void cbbLoaiTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiTS.SelectedIndex == 0)
            {
                cbbLoaiTS.SelectedIndex = -1;
                cbbLoaiTS.Text = "";
                LoaiTSAddForm f = new LoaiTSAddForm();
                f.BackToPreviousForm += () => { };
                f.allowtoReturnTenLoaiTS(true);
                f.returnTenLoaiTS += addNewLoaiTS;
                f.ShowDialog();
            }
        }
        private void cbbLoaiTS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbbLoaiTS1.SelectedIndex == 0)
            {
                cbbLoaiTS1.SelectedIndex = -1;
                cbbLoaiTS1.Text = "";
                LoaiTSAddForm f = new LoaiTSAddForm();
                f.BackToPreviousForm += () => { };
                f.allowtoReturnTenLoaiTS(true);
                f.returnTenLoaiTS += addNewLoaiTS;
                f.ShowDialog();
            }*/
        }
        private void cbbNuocSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNuocSX.SelectedIndex == 0)
            {
                cbbNuocSX.SelectedIndex = -1;
                cbbNuocSX.Text = "";
                NuocSXAddform f = new NuocSXAddform();
                f.BackToPreviousForm += () => { };
                f.allowReturnNuocSX(true);
                f.returnNuocSX += addNewNuocSX;
                f.ShowDialog();
            }
        }
        private void cbbNuocSX1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbbNuocSX1.SelectedIndex == 0)
            {
                cbbNuocSX1.SelectedIndex = -1;
                cbbNuocSX1.Text = "";
                NuocSXAddform f = new NuocSXAddform();
                f.BackToPreviousForm += () => { };
                f.allowReturnNuocSX(true);
                f.returnNuocSX += addNewNuocSX;
                f.ShowDialog();
            }*/
        }
        /* ---------------- Xu ly su kien combobox  ---------------- */

        /* ---------------- Xu ly cac to hop phim  ---------------- */
        private void TSForm_KeyDown(object sender, KeyEventArgs e)
        {
            // To hop Ctrl + N => Tao Tai San moi
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                this.butAdd_Click(sender, e);
            }
            // To hop Ctrl + N => Nhap du lieu tu file
            if (e.KeyCode == Keys.I && e.Modifiers == Keys.Control)
            {
                this.importToolStripMenuItem_Click(sender, e);
            }
            // To hop Ctrl + E => Xuat du lieu ra file
            if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {
                this.exportToolStripMenuItem_Click(sender, e);
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Neu dang o tren tab Hien thi va cap nhat
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.btnUpdate_Click(sender, e);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.btnSearch_Click(sender, e);
                }
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // Neu bam nut Delete khi dang o tren dgv
            {
                this.deleteToolStripMenuItem_Click(sender, e);
            }
        }
        /* ---------------- Xu ly cac to hop phim  ---------------- */

        /* ---------------- Xu ly cac su kien menu cua form  ---------------- */
        private void newTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.butAdd_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongForm f = new PhongForm();
            f.BackToPreviousForm += Reload;
            this.Visible = false;
            f.Show();
        }

        private void nguoiQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguoiQLForm f = new NguoiQLForm();
            f.BackToPreviousForm += Reload;
            this.Visible = false;
            f.Show();
        }

        private void loaiTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiTSForm f = new LoaiTSForm();
            f.BackToPreviousForm += Reload;
            this.Visible = false;
            f.Show();
        }

        private void nuocSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuocSXForm f = new NuocSXForm();
            f.BackToPreviousForm += Reload;
            this.Visible = false;
            f.Show();
        }

        private void nhapXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapXuatForm f = new NhapXuatForm();
            f.BackToPreviousForm += Reload;
            this.Visible = false;
            f.Show();
        }

        private void nhaCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCCForm f = new NhaCCForm();
            f.BackToPreviousForm += Reload;
            this.Visible = false;
            f.Show();
        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_ExportTSForm f = new Import_ExportTSForm();
            f.getDGV += () =>
            {
                return dgv;
            };
            f.Text = "Xuất dữ liệu ra file";
            f.startExportingData();
            f.ShowDialog();
        }
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_ExportTSForm f = new Import_ExportTSForm();
            f.getDGV += () => { return null; };
            f.Text = "Nhập dữ liệu từ file";
            f.startImportingData();
            f.ShowDialog();
        }
        /* ---------------- Xu ly cac su kien menu cua form  ---------------- */

        /* ---------------- Xu ly cac su kien khac cua form  ---------------- */
        private void ShowTS()
        {
            // Hien thi tat ca, khong kem filter hoac dieu kien tim kiem
            dgv.DataSource = TS_BLL.ShowTS_BLL();
        }
        private void Reload()
        {
            loadDGVWorker.RunWorkerAsync(); // Load lai du lieu cho DataGridView
            this.Visible = true; // Hien thi lai form
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ShowMainForm();
            Dispose();
        }
        private void loadCBBNSX_DoWork(object sender, DoWorkEventArgs e)
        {
            // Xoa moi danh sach co trong CBB truoc khi load (phong truong hop load lai)
            /*cbbNuocSX1.Invoke(new Action(() =>
            {
                cbbNuocSX1.Items.Clear();
                cbbNuocSX1.Items.Add(" ** Thêm mới ** ");
            }));*/
            cbbNuocSX.Invoke(new Action(() =>
            {
                cbbNuocSX.Items.Clear();
                cbbNuocSX.Items.Add(" ** Thêm mới ** ");
            }));
            foreach (string i in NSX_BLL.loadCBB_BLL())
            {
                if (cbbNuocSX1.FindStringExact(i) < 0)
                {
                    cbbNuocSX1.Invoke(new Action(() =>
                    {
                        cbbNuocSX1.Items.Add(i);
                    }));
                }
                if (cbbNuocSX.FindStringExact(i) < 0)
                {
                    cbbNuocSX.Invoke(new Action(() =>
                    {
                        cbbNuocSX.Items.Add(i);
                    }));
                }
            }
        }
        //private void loadCBBNSX_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    cbbNuocSX1.Invoke(new Action(() => {
        //    loadCBBNuocSX();
        //}));
        //}
        private void loadCBBLTS_DoWork(object sender, DoWorkEventArgs e)
        {
            // Xoa moi danh sach co trong CBB truoc khi load (phong truong hop load lai)
            /*cbbLoaiTS1.Invoke(new Action(() =>
            {
                cbbLoaiTS1.Items.Clear();
                cbbLoaiTS1.Items.Add(" ** Thêm mới ** ");
            }));*/
            cbbLoaiTS.Invoke(new Action(() =>
            {
                cbbLoaiTS.Items.Clear();
                cbbLoaiTS.Items.Add(" ** Thêm mới ** ");
            }));
            foreach (string i in LTS_BLL.loadCBB_BLL())
            {
                cbbLoaiTS1.Invoke(new Action(() =>
                {
                    if (cbbLoaiTS1.FindStringExact(i) < 0)
                    {
                        cbbLoaiTS1.Items.Add(i);

                    }
                }));
                if (cbbLoaiTS.FindStringExact(i) < 0)
                {
                    cbbLoaiTS.Invoke(new Action(() =>
                    {
                        cbbLoaiTS.Items.Add(i);
                    }));
                }
            }
        }
        //private void loadCBBLTS_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    cbbLoaiTS1.Invoke(new Action(() => {
        //        loadCBBLoaiTS();
        //    }));
        //}

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadCBBLTS.RunWorkerAsync();
            loadCBBNSX.RunWorkerAsync();
        }

        private void loadDGVWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            statusLabel.Invoke(new Action(() =>
            {
                statusLabel.Visible = true;
                statusLabel.Text = "Đang load dữ liệu...";
            }));
            butShow.Invoke(new Action(() => {
                butShow.Enabled = false;
            }));
            dgv.Invoke(new Action(ShowTS));       
        }

        private void loadDGVWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusLabel.Invoke(new Action(() =>
            {
                statusLabel.Visible = false;
            }));
            butShow.Invoke(new Action(() => {
                butShow.Enabled = true;
            }));
        }

        /* ---------------- Xu ly cac su kien khac cua form  ---------------- */
    }
}
