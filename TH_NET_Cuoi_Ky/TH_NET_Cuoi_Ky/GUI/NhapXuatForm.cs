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
            LoadCbbNhaCC();
            LoadCbbPhong();
            LoadCbbTenTS();
        }

        private void NhapXuatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowMainForm();
        }

        private void bnt_Nhap_Click(object sender, EventArgs e)
        {
            if(cbb_NhaCCNhap.SelectedIndex == -1 || cbb_PhongNhap.SelectedIndex == -1 || cbb_TenTSNhap.SelectedIndex == -1 || numericUpDown_GiaNhap.Value <= 0 || numericUpDown_SLNhap.Value <= 0 || txt_TinhTrangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                return;
            }
            int maTS = Ts_BLL.GetIDbyTS(cbb_TenTSNhap.SelectedItem.ToString());
            int maNCC = NCC_BLL.GetIdByNhaCC(cbb_NhaCCNhap.SelectedItem.ToString());
            int maPhong = p_BLL.GetIdByPhong(cbb_PhongNhap.SelectedItem.ToString());
            if(maTS == -1 || maNCC == -1 || maPhong == -1)
            {
                MessageBox.Show("Không tồn tại tài sản (nhà cung cấp hoặc phòng) đã chọn");
                return;
            }
            List<DTO.NhapXuat> l = new List<DTO.NhapXuat>();
            l.Add(new DTO.NhapXuat
            {
                MaTS = maTS,
                MaNhaCC = maNCC,
                MaPhong = maPhong,
                NgayNhap = dateTimePicker1.Value.Date,
                SLNhap = Convert.ToInt32(numericUpDown_SLNhap.Value),
                NguyenGia = Convert.ToDouble(numericUpDown_GiaNhap.Value),
                TinhTrang = txt_TinhTrangNhap.Text
            });
            (bool result, string msg) = NX_BLL.AddNhapXuat(l);

            if (result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                Show_Nhap();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");
            }
        }
        private void LoadCbbTenTS()
        {
            foreach (string i in Ts_BLL.LoadCBBTenTS())
            {
                if (cbb_TenTSNhap.FindStringExact(i) < 0)
                    cbb_TenTSNhap.Items.Add(i);
            }
            foreach (string i in Ts_BLL.LoadCBBTenTS())
            {
                if (cbb_TenTSXuat.FindStringExact(i) < 0)
                    cbb_TenTSXuat.Items.Add(i);
            }
        }
        private void LoadCbbNhaCC()
        {
            foreach (string i in NCC_BLL.loadCBBTenNCC())
            {
                if (cbb_NhaCCNhap.FindStringExact(i) < 0)
                    cbb_NhaCCNhap.Items.Add(i);
            }
        }
        private void LoadCbbPhong()
        {
            foreach (string i in p_BLL.loadCBBTenPhong_BLL())
            {
                if (cbb_PhongNhap.FindStringExact(i) < 0)
                    cbb_PhongNhap.Items.Add(i);
            }
        }

        private void bnt_HienThiNhap_Click(object sender, EventArgs e)
        {
            Show_Nhap();
        }

        private void Bnt_HienThiXuat_Click(object sender, EventArgs e)
        {
            Show_Xuat();
        }
        private void Show_Nhap()
        {
            dataGridView1.DataSource = NX_BLL.ShowNhap_BLL();
        }
        private void Show_Xuat()
        {
            dataGridView2.DataSource = NX_BLL.ShowXuat_BLL();
        }

        private void bnt_Xuat_Click(object sender, EventArgs e)
        {
            if (cbb_NhaCCXuat.SelectedIndex == -1 || cbb_PhongXuat.SelectedIndex == -1 || cbb_TenTSXuat.SelectedIndex == -1 || numericUpDown_GiaXuat.Value <= 0 || numericUpDown_SLXuat.Value <= 0 || txt_TinhTrangXuat.Text == "")
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
                NguyenGia = Convert.ToDouble(numericUpDown_GiaXuat.Value),
                TinhTrang = txt_TinhTrangNhap.Text
            });
            (bool result, string msg) = NX_BLL.AddNhapXuat(l);

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
        private void LoadCBBNhaCC_Xuat()
        {
            foreach(string i in NCC_BLL.LoadCCB_NhaCC_AfterTenTSChose(cbb_TenTSXuat.SelectedItem.ToString()))
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
            cbb_PhongXuat.Items.Clear();
            cbb_NhaCCXuat.Items.Clear();
            LoadCBBNhaCC_Xuat();
            LoadCBBPhong_Xuat();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            dispose();
            ShowMainForm();
        }
    }
}
