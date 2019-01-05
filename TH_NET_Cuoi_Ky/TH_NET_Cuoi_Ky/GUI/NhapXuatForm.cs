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
    public partial class NhapXuatForm : Form
    {
        TaiSan_BLL Ts_BLL;
        NhaCC_BLL NCC_BLL;
        Phong_BLL p_BLL;
        NhapXuat_BLL NX_BLL;
        public delegate void dd();
        public dd ShowMainForm;
        public NhapXuatForm()
        {
            InitializeComponent();
            Ts_BLL = new TaiSan_BLL();
            NCC_BLL = new NhaCC_BLL();
            p_BLL = new Phong_BLL();
            NX_BLL = new NhapXuat_BLL();
        }

        private void NhapXuatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowMainForm();
        }
        //private void LoadCbbTenTS()
        //{
        //    foreach (string i in Ts_BLL.LoadCBBTenTS())
        //    {
        //        if (cbb_TenTSNhap.FindStringExact(i) < 0)
        //            cbb_TenTSNhap.Items.Add(i);
        //    }
        //    foreach (string i in Ts_BLL.LoadCBBTenTS())
        //    {
        //        if (cbb_TenTSXuat.FindStringExact(i) < 0)
        //            cbb_TenTSXuat.Items.Add(i);
        //    }
        //}
        //private void LoadCbbNhaCC()
        //{
        //    foreach (string i in NCC_BLL.loadCBBTenNCC())
        //    {
        //        if (cbb_NhaCCNhap.FindStringExact(i) < 0)
        //            cbb_NhaCCNhap.Items.Add(i);
        //    }
        //}
        //private void LoadCbbPhong()
        //{
        //    foreach (string i in p_BLL.loadCBBTenPhong_BLL())
        //    {
        //        if (cbb_PhongNhap.FindStringExact(i) < 0)
        //            cbb_PhongNhap.Items.Add(i);
        //    }
        //}
        private void Show_Nhap()
        {
            dgvNhap.DataSource = NX_BLL.ShowNhap_BLL();
        }
        private void Show_Xuat()
        {
            dgvXuat.DataSource = NX_BLL.ShowXuat_BLL();
        }
        private void LoadCBBNhaCC_Xuat()
        {
            foreach(string i in NCC_BLL.LoadCCB_NhaCC_AfterTenTSChose(cbb_TenTSXuat.SelectedItem.ToString() , cbb_PhongXuat.SelectedItem.ToString()))
            {
                if(cbb_NhaCCXuat.FindStringExact(i)<0)
                {
                    cbb_NhaCCXuat.Items.Add(i);
                }
            }
            cbb_NhaCCXuat.Enabled = true;
        }
        private void LoadCBBPhong_Xuat()
        {
            foreach(string i in p_BLL.LoadCBB_Phong_AfterTenTSChose(cbb_TenTSXuat.SelectedItem.ToString()))
            {
                if(cbb_PhongXuat.FindStringExact(i)<0)
                {
                    cbb_PhongXuat.Items.Add(i);
                }
            }
            cbb_PhongXuat.Enabled = true;
        }

        private void cbb_TenTSXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_PhongXuat.Text = "";
            cbb_NhaCCXuat.Text = "";
            cbb_PhongXuat.Items.Clear();  
            LoadCBBPhong_Xuat();
            cbb_NhaCCXuat.Enabled = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
            ShowMainForm();
        }

        private void cbb_PhongXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_NhaCCXuat.Text = "";
            cbb_NhaCCXuat.Items.Clear();
            LoadCBBNhaCC_Xuat();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Phieu_Nhap.Text = dgvNhap.SelectedRows[0].Cells["SoPhieu"].Value.ToString();
            cbb_TenTSNhap.SelectedItem = dgvNhap.SelectedRows[0].Cells["TenTS"].Value.ToString();
            cbb_NhaCCNhap.SelectedItem = dgvNhap.SelectedRows[0].Cells["TenNhaCC"].Value.ToString();
            cbb_PhongNhap.SelectedItem = dgvNhap.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvNhap.SelectedRows[0].Cells["NgayNhap"].Value).Date;
            txt_GiaNhap.Text = dgvNhap.SelectedRows[0].Cells["NguyenGia"].Value.ToString();
            numericUpDown_SLNhap.Value = Convert.ToDecimal(dgvNhap.SelectedRows[0].Cells["SLNhap"].Value);
            txt_TinhTrangNhap.Text = dgvNhap.SelectedRows[0].Cells["TinhTrang"].Value.ToString();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_phieu_xuat.Text = dgvXuat.SelectedRows[0].Cells["SoPhieu"].Value.ToString();
            cbb_TenTSXuat.SelectedItem = dgvXuat.SelectedRows[0].Cells["TenTS"].Value.ToString(); 
            cbb_PhongXuat.SelectedItem = dgvXuat.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            cbb_NhaCCXuat.SelectedItem = dgvXuat.SelectedRows[0].Cells["TenNhaCC"].Value.ToString();
            dateTimePicker2.Value = Convert.ToDateTime(dgvXuat.SelectedRows[0].Cells["NgayXuat"].Value).Date;
            txt_GiaXuat.Text = dgvXuat.SelectedRows[0].Cells["NguyenGia"].Value.ToString();
            numericUpDown_SLXuat.Value = Convert.ToDecimal(dgvXuat.SelectedRows[0].Cells["SLXuat"].Value);
            txt_TinhTrangXuat.Text = dgvXuat.SelectedRows[0].Cells["TinhTrang"].Value.ToString();
        }

        private void txt_GiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_GiaXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void loadCBBTS_Nhap_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in Ts_BLL.LoadCBBTenTS())
            {
                if (cbb_TenTSNhap.FindStringExact(i) < 0)
                {
                    cbb_TenTSNhap.Invoke(new Action(() =>
                    {
                        cbb_TenTSNhap.Items.Add(i);
                    }));
                }
            }
            foreach (string i in Ts_BLL.LoadCBBTenTS())
            {
                if (cbb_TenTSXuat.FindStringExact(i) < 0)
                {
                    cbb_TenTSXuat.Invoke(new Action(() =>
                    {
                        cbb_TenTSXuat.Items.Add(i);
                    }));
                }
            }
        }

        private void loadCBBPhong_Nhap_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in p_BLL.loadCBBTenPhong_BLL())
            {
                if (cbb_PhongNhap.FindStringExact(i) < 0)
                {
                    cbb_PhongNhap.Invoke(new Action(() => {
                        cbb_PhongNhap.Items.Add(i);
                    }));
                }
            }
        }

        private void loadCBBNCC_Nhap_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in NCC_BLL.loadCBBTenNCC())
            {
                if (cbb_NhaCCNhap.FindStringExact(i) < 0)
                {
                    cbb_NhaCCNhap.Invoke(new Action(() =>
                    {
                        cbb_NhaCCNhap.Items.Add(i);
                    }));
                }
            }
        }

        private void NhapXuatForm_Shown(object sender, EventArgs e)
        {
            loadCBBTS_Nhap.RunWorkerAsync();
            loadCBBPhong_Nhap.RunWorkerAsync();
            loadCBBNCC_Nhap.RunWorkerAsync();
        }

        private void Reload()
        {
            Show_Nhap();
            Show_Xuat();
            this.Visible = true;
        }

        public void enableBtn(bool enable)
        {
            btnDelete.Enabled = enable;
            btnUpdate.Enabled = enable;
            btnLuanchuyen.Enabled = enable;
            btn_ThanhLy.Enabled = enable;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.enableBtn(false);

            if (tabControl1.SelectedIndex == 0)
            {
                if(dgvNhap.SelectedRows.Count > 0)
                {
                    this.enableBtn(true);
                }
                else
                {
                    this.enableBtn(false);
                }
            }
            else
            {
                if (dgvXuat.SelectedRows.Count > 0)
                {
                    this.enableBtn(true);
                }
                else
                {
                    this.enableBtn(false);
                }
            }
        }

        private void dgvNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhap.SelectedRows.Count > 0)
            {
                this.enableBtn(true);
            }
            else
            {
                this.enableBtn(false);
            }
        }

        private void dgvXuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvXuat.SelectedRows.Count > 0)
            {
                this.enableBtn(true);
            }
            else
            {
                this.enableBtn(false);
            }
        }

        private void btn_ThanhLy_Click(object sender, EventArgs e)
        {
            ThanhLy f = new ThanhLy();
            f.BackToPreviousForm += () => { };
            f.ShowDialog();
            //this.Visible = false; 
        }

        private void btnLuanchuyen_Click(object sender, EventArgs e)
        {
            LuanChuyen f = new LuanChuyen();
            //f.BackToPreviousForm += Reload;
            f.ShowDialog();
            //this.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (dgvNhap.SelectedRows.Count == 0)
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
                        // Add So phieu nhap cua cac hang duoc chon vao list
                        List<int> l = new List<int>();
                        foreach (DataGridViewRow r in dgvNhap.SelectedRows)
                        {
                            l.Add(Convert.ToInt32(r.Cells["SoPhieu"].Value.ToString()));
                        }
                        //kiem tra xem cac phan tu duoc chon khi xoa di co anh huong toi xuat khong
                        foreach (int i in l)
                        {
                            if (NX_BLL.check_Nhap(i) < 0)
                            {
                                MessageBox.Show("Không thể xóa số phiếu " + i + " vì đã có số lượng xuất ra");
                                return;
                            }
                        }
                        (bool result, string msg) = NX_BLL.deleteNX(l);

                        MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

                        Show_Nhap(); // Refresh lai du lieu tren DataGridView
                    }
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                if (dgvXuat.SelectedRows.Count == 0)
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
                        // Add so phieu cua cac hang duoc chon vao list
                        List<int> l = new List<int>();
                        foreach (DataGridViewRow r in dgvXuat.SelectedRows)
                        {
                            l.Add(Convert.ToInt32(r.Cells["SoPhieu"].Value.ToString()));
                        }
                        (bool result, string msg) = NX_BLL.deleteNX(l);

                        MessageBox.Show(msg, result ? "Thành công" : "Lỗi");

                        Show_Xuat(); // Refresh lai du lieu tren DataGridView
                    }
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (txt_Phieu_Nhap.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn Phiếu cần sửa!");
                    return;
                }
                if (cbb_NhaCCNhap.SelectedIndex == -1 || cbb_PhongNhap.SelectedIndex == -1 || cbb_TenTSNhap.SelectedIndex == -1 || Convert.ToDouble(txt_GiaNhap.Text) < 0 || numericUpDown_SLNhap.Value <= 0 || txt_TinhTrangNhap.Text == "")
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                    return;
                }
                int minNhap = NX_BLL.check_Nhap(Convert.ToInt32(txt_Phieu_Nhap.Text));
                if (Convert.ToInt32(numericUpDown_SLNhap.Value) < Math.Abs(minNhap))
                {
                    MessageBox.Show("Số lượng không hợp lệ, giá trị thấp nhất có thể là " + Math.Abs(minNhap));
                    return;
                }

                (bool result, string msg) = NX_BLL.Update_Nhap(new DTO.NhapXuat
                {
                    SoPhieu = Convert.ToInt32(txt_Phieu_Nhap.Text),
                    MaTS = Ts_BLL.GetIDbyTS(cbb_TenTSNhap.SelectedItem.ToString()),
                    MaNhaCC = NCC_BLL.GetIdByNhaCC(cbb_NhaCCNhap.SelectedItem.ToString()),
                    MaPhong = p_BLL.GetIdByPhong(cbb_PhongNhap.SelectedItem.ToString()),
                    NgayNhap = dateTimePicker1.Value,
                    SLNhap = Convert.ToInt32(numericUpDown_SLNhap.Value),
                    NguyenGia = Convert.ToInt32(txt_GiaNhap.Text),
                    TinhTrang = txt_TinhTrangNhap.Text
                });
                MessageBox.Show(msg, result ? "Thành công" : "Lỗi");
                Show_Nhap();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                if (txt_phieu_xuat.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn Phiếu cần sửa!");
                    return;
                }
                if (cbb_NhaCCXuat.SelectedIndex == -1 || cbb_PhongXuat.SelectedIndex == -1 || cbb_TenTSXuat.SelectedIndex == -1 || Convert.ToDouble(txt_GiaXuat.Text) < 0 || numericUpDown_SLXuat.Value <= 0 || txt_TinhTrangXuat.Text == "")
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                    return;
                }

                int maxXuat = NX_BLL.Check_Xuat(Convert.ToInt32(txt_phieu_xuat.Text));
                if (Convert.ToInt32(numericUpDown_SLXuat.Value) > maxXuat)
                {
                    MessageBox.Show("Số lượng không hợp lệ, giá trị tối đa có thể là " + maxXuat);
                    return;
                }
                (bool result, string msg) = NX_BLL.Update_Xuat(new DTO.NhapXuat
                {
                    SoPhieu = Convert.ToInt32(txt_phieu_xuat.Text),
                    MaTS = Ts_BLL.GetIDbyTS(cbb_TenTSXuat.SelectedItem.ToString()),
                    MaNhaCC = NCC_BLL.GetIdByNhaCC(cbb_NhaCCXuat.SelectedItem.ToString()),
                    MaPhong = p_BLL.GetIdByPhong(cbb_PhongXuat.SelectedItem.ToString()),
                    NgayXuat = dateTimePicker2.Value,
                    SLXuat = Convert.ToInt32(numericUpDown_SLXuat.Value),
                    NguyenGia = Convert.ToInt32(txt_GiaXuat.Text),
                    TinhTrang = txt_TinhTrangXuat.Text
                });
                MessageBox.Show(msg, result ? "Thành công" : "Lỗi");
                Show_Xuat();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (cbb_NhaCCXuat.SelectedIndex == -1 || cbb_PhongXuat.SelectedIndex == -1 || cbb_TenTSXuat.SelectedIndex == -1 || Convert.ToDouble(txt_GiaXuat.Text) < 0 || numericUpDown_SLXuat.Value <= 0 || txt_TinhTrangXuat.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                return;
            }
            int mataisan = Ts_BLL.GetIDbyTS(cbb_TenTSXuat.SelectedItem.ToString());
            int manhacungcap = NCC_BLL.GetIdByNhaCC(cbb_NhaCCXuat.SelectedItem.ToString());
            int maphong = p_BLL.GetIdByPhong(cbb_PhongXuat.SelectedItem.ToString());
            if (mataisan == -1 || manhacungcap == -1 || maphong == -1)
            {
                MessageBox.Show("Không tồn tại tài sản (nhà cung cấp hoặc phòng) đã chọn");
                return;
            }
            List<DTO.NhapXuat> l = new List<DTO.NhapXuat>();
            l.Add(new DTO.NhapXuat
            {
                MaTS = mataisan,
                MaNhaCC = manhacungcap,
                MaPhong = maphong,
                NgayXuat = dateTimePicker2.Value.Date,
                SLXuat = Convert.ToInt32(numericUpDown_SLXuat.Value),
                NguyenGia = Convert.ToDouble(txt_GiaXuat.Text),
                TinhTrang = txt_TinhTrangXuat.Text
            });
            //kiem tra so luong xuat ra co vuot qua sl nhap hay k
            foreach (DTO.NhapXuat i in l)
            {
                if (NX_BLL.getSLNhap(i.MaTS, i.MaPhong, i.MaNhaCC) < i.SLXuat)
                {
                    MessageBox.Show("Số lượng không hợp lệ, giá trị cao nhất có thể là " + NX_BLL.getSLNhap(i.MaTS, i.MaPhong, i.MaNhaCC));
                    return;
                }
            }
            (Boolean result, string msg) = NX_BLL.AddNhapXuat(l);

            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                Show_Xuat();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");
            }
        }

        private void btnHienThiXuat_Click(object sender, EventArgs e)
        {
            Show_Xuat();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            /*if (cbb_NhaCCNhap.SelectedIndex == -1 || cbb_PhongNhap.SelectedIndex == -1 || cbb_TenTSNhap.SelectedIndex == -1 || Convert.ToDouble(txt_GiaNhap.Text) < 0 || numericUpDown_SLNhap.Value <= 0 || txt_TinhTrangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                return;
            }
            int mataisan = Ts_BLL.GetIDbyTS(cbb_TenTSNhap.SelectedItem.ToString());
            int manhacungcap = NCC_BLL.GetIdByNhaCC(cbb_NhaCCNhap.SelectedItem.ToString());
            int maphong = p_BLL.GetIdByPhong(cbb_PhongNhap.SelectedItem.ToString());
            if (mataisan == -1 || manhacungcap == -1 || maphong == -1)
            {
                MessageBox.Show("Không tồn tại tài sản (nhà cung cấp hoặc phòng) đã chọn");
                return;
            }
            List<DTO.NhapXuat> l = new List<DTO.NhapXuat>();
            l.Add(new DTO.NhapXuat
            {
                MaTS = mataisan,
                MaNhaCC = manhacungcap,
                MaPhong = maphong,
                NgayNhap = dateTimePicker1.Value.Date,
                SLNhap = Convert.ToInt32(numericUpDown_SLNhap.Value),
                NguyenGia = Convert.ToDouble(txt_GiaNhap.Text),
                TinhTrang = txt_TinhTrangNhap.Text
            });
            (Boolean result, string msg) = NX_BLL.AddNhapXuat(l);

            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                Show_Nhap();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");
            }*/
            NhapForm f = new NhapForm();
            f.BackToPreviousForm += () => { };
            f.ShowDialog();
        }

        private void btnHienThiNhap_Click(object sender, EventArgs e)
        {
            Show_Nhap();
        }
    }
}
