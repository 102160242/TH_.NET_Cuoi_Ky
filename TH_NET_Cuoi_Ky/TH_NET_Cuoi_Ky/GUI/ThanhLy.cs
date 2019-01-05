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
    public partial class ThanhLy : Form
    {
        public delegate void dd();
        public dd BackToPreviousForm;
        public bool allowCBBToBeLoaded = true;
        TaiSan_BLL TS_BLL;
        NhaCC_BLL NCC_BLL;
        Phong_BLL P_BLL;
        NhapXuat_BLL NX_BLL;
        public ThanhLy()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
            NCC_BLL = new NhaCC_BLL();
            P_BLL = new Phong_BLL();
            NX_BLL = new NhapXuat_BLL();

        }

        private void ThanhLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BackToPreviousForm();
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
        public void setCBBPhong(String tenPhong)
        {
            cbb_Phong.Items.Clear();
            cbb_Phong.Items.Add(tenPhong);
            cbb_Phong.SelectedIndex = 0;
            cbb_Phong.Enabled = false;
        }

        private void ThanhLy_Shown(object sender, EventArgs e)
        {
            // Load CBB Khong dong bo
            if(allowCBBToBeLoaded)
            {
                LoadCBBTS.RunWorkerAsync();

            }
        }
        private void LoadCBBNhaCC()
        {
            foreach (string i in NCC_BLL.LoadCCB_NhaCC_AfterTenTSChose(cbb_TenTS.SelectedItem.ToString(), cbb_Phong.SelectedItem.ToString()))
            {
                if (cbb_NhaCC.FindStringExact(i) < 0)
                {
                    cbb_NhaCC.Items.Add(i);
                }
            }
            cbb_NhaCC.Enabled = true;
        }
        private void LoadCBBPhong()
        {
            foreach (string i in P_BLL.LoadCBB_Phong_AfterTenTSChose(cbb_TenTS.SelectedItem.ToString()))
            {
                if (cbb_Phong.FindStringExact(i) < 0)
                {
                    cbb_Phong.Items.Add(i);
                }
            }
            cbb_Phong.Enabled = true;
        }
        private void cbb_TenTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_Phong.Text = "";
            cbb_NhaCC.Text = "";
            cbb_Phong.Items.Clear();
            LoadCBBPhong();
            cbb_NhaCC.Enabled = false;
        }
        private void cbb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_NhaCC.Text = "";
            cbb_NhaCC.Items.Clear();
            LoadCBBNhaCC();
        }

        private void LoadCBBTS_DoWork_1(object sender, DoWorkEventArgs e)
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

        private void bnt_OK_Click(object sender, EventArgs e)
        {
            if (cbb_NhaCC.SelectedIndex == -1 || cbb_Phong.SelectedIndex == -1 || cbb_TenTS.SelectedIndex == -1 || Convert.ToDouble(txt_NguyenGia.Text) < 0 || numericUpDown_SL.Value <= 0 || txt_TinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                return;
            }
            int maTS = TS_BLL.GetIDbyTS(cbb_TenTS.SelectedItem.ToString());
            int maNCC = NCC_BLL.GetIdByNhaCC(cbb_NhaCC.SelectedItem.ToString());
            int maPhong = P_BLL.GetIdByPhong(cbb_Phong.SelectedItem.ToString());
            if (maTS == -1 || maNCC == -1 || maPhong == -1)
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
                NgayXuat = dateTimePicker1.Value.Date,
                SLXuat = Convert.ToInt32(numericUpDown_SL.Value),
                NguyenGia = Convert.ToDouble(txt_NguyenGia.Text),
                TinhTrang = txt_TinhTrang.Text
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
                BackToPreviousForm();
                Dispose();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");
            }
        }

        private void txt_NguyenGia_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
