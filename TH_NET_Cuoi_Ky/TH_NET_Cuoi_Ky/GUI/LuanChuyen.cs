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
    public partial class LuanChuyen : Form
    {
        public delegate void dd();
        public dd BackToPreviousForm;
        public bool allowCBBToBeLoaded = true;
        TaiSan_BLL TS_BLL;
        NhaCC_BLL NCC_BLL;
        Phong_BLL P_BLL;
        NhapXuat_BLL NX_BLL;
        public LuanChuyen()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
            NCC_BLL = new NhaCC_BLL();
            P_BLL = new Phong_BLL();
            NX_BLL = new NhapXuat_BLL();
        }

        private void LuanChuyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToPreviousForm();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackToPreviousForm();
            Dispose();
        }
        // Set CBB, khong cho thay doi
        public void setCBBTenTS(String tenTS)
        {
            cbb_TenTS.Items.Clear();
            cbb_TenTS.Items.Add(tenTS);
            cbb_TenTS.SelectedIndex = 0;
            cbb_TenTS.Enabled = false;
        }
        public void setCBBNhaCC(String tenNhaCC)
        {
            cbb_NhaCC.Items.Clear();
            cbb_NhaCC.Items.Add(tenNhaCC);
            cbb_NhaCC.SelectedIndex = 0;
            cbb_NhaCC.Enabled = false;
        }
        public void setCBBPhongXuat(String tenPhong)
        {
            cbb_PhongXuat.Items.Clear();
            cbb_PhongXuat.Items.Add(tenPhong);
            cbb_PhongXuat.SelectedIndex = 0;
            cbb_PhongXuat.Enabled = false;
        }

        private void LuanChuyen_Shown(object sender, EventArgs e)
        {
            if(allowCBBToBeLoaded)
            {
                loadCBBTS.RunWorkerAsync();
            }
        }

        private void bnt_OK_Click(object sender, EventArgs e)
        {
            if (cbb_NhaCC.SelectedIndex == -1 || cbb_PhongXuat.SelectedIndex == -1 || cbbPhongNhap.SelectedIndex == -1 || cbb_TenTS.SelectedIndex == -1  || numericUpDown_SLNhap.Value <= 0 || txt_TinhTrangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                return;
            }
            int maTS = TS_BLL.GetIDbyTS(cbb_TenTS.SelectedItem.ToString());
            int maNCC = NCC_BLL.GetIdByNhaCC(cbb_NhaCC.SelectedItem.ToString());
            int maPhongXuat = P_BLL.GetIdByPhong(cbb_PhongXuat.SelectedItem.ToString());
            int maPhongNhap = P_BLL.GetIdByPhong(cbbPhongNhap.SelectedItem.ToString());
            if (maTS == -1 || maNCC == -1 || maPhongXuat == -1 || maPhongNhap == -1)
            {
                MessageBox.Show("Không tồn tại tài sản (nhà cung cấp hoặc phòng) đã chọn");
                return;
            }
            List<DTO.NhapXuat> l = new List<DTO.NhapXuat>();
            l.Add(new DTO.NhapXuat
            {
                MaTS = maTS,
                MaNhaCC = maNCC,
                MaPhong = maPhongXuat,
                NgayXuat = dateTimePicker1.Value.Date,
                SLXuat = Convert.ToInt32(numericUpDown_SLNhap.Value),
                NguyenGia = 0,
                TinhTrang = txt_TinhTrangNhap.Text + ", chuyển qua phòng " + cbbPhongNhap.SelectedItem.ToString()
            });
            l.Add(new DTO.NhapXuat
            {
                MaTS = maTS,
                MaNhaCC = maNCC,
                MaPhong = maPhongNhap,
                NgayNhap = dateTimePicker1.Value.Date,
                SLNhap = Convert.ToInt32(numericUpDown_SLNhap.Value),
                NguyenGia = 0,
                TinhTrang = txt_TinhTrangNhap.Text + ", chuyển từ phòng " + cbb_PhongXuat.SelectedItem.ToString()
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
                //MessageBox.Show("Thành công");
                Dispose();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");
            }
        }

        private void loadCBBTS_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in TS_BLL.LoadCBBTenTS())
            {
                if (cbb_TenTS.FindStringExact(i) < 0)
                {
                    cbb_TenTS.Invoke(new Action(() =>
                    {
                        cbb_TenTS.Items.Add(i);
                    }));
                }
            }
        }

        private void cbb_TenTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_PhongXuat.Text = "";
            cbb_NhaCC.Text = "";
            cbbPhongNhap.Text = "";
            cbb_PhongXuat.Items.Clear();
            LoadCBBPhongXuat();
            cbb_NhaCC.Enabled = false;
            cbbPhongNhap.Enabled = false;
        }
        private void LoadCBBNhaCC()
        {
            foreach (string i in NCC_BLL.LoadCCB_NhaCC_AfterTenTSChose(cbb_TenTS.SelectedItem.ToString(), cbb_PhongXuat.SelectedItem.ToString()))
            {
                if (cbb_NhaCC.FindStringExact(i) < 0)
                {
                    cbb_NhaCC.Items.Add(i);
                }
            }
            cbb_NhaCC.Enabled = true;
        }
        private void LoadCBBPhongXuat()
        {
            foreach (string i in P_BLL.LoadCBB_Phong_AfterTenTSChose(cbb_TenTS.SelectedItem.ToString()))
            {
                if (cbb_PhongXuat.FindStringExact(i) < 0)
                {
                    cbb_PhongXuat.Items.Add(i);
                }
            }
            cbb_PhongXuat.Enabled = true;
        }
        private void LoadCBBPhongNhap()
        {
            foreach (string i in P_BLL.loadCBBTenPhong_BLL())
            {
                if (cbbPhongNhap.FindStringExact(i) < 0)
                {
                    cbbPhongNhap.Items.Add(i);
                }
            }
        }
        private void cbb_PhongXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_NhaCC.Text = "";
            cbbPhongNhap.Text = "";
            cbb_NhaCC.Items.Clear();
            LoadCBBNhaCC();
            LoadCBBPhongNhap();
            cbbPhongNhap.Items.Remove(cbb_PhongXuat.SelectedItem.ToString());
            cbbPhongNhap.Enabled = true;
        }
    }
}
