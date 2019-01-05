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
    public partial class NhapForm : Form
    {
        public delegate void dd();
        public dd BackToPreviousForm;
        TaiSan_BLL TS_BLL;
        Phong_BLL P_BLL;
        NhaCC_BLL NCC_BLL;
        NhapXuat_BLL NX_BLL;
        public NhapForm()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
            P_BLL = new Phong_BLL();
            NCC_BLL = new NhaCC_BLL();
            NX_BLL = new NhapXuat_BLL();
        }

        private void bnt_OK_Click(object sender, EventArgs e)
        {
            if (cbb_TenTS.SelectedIndex == -1 || cbb_Phong.SelectedIndex == -1 || cbb_NhaCC.SelectedIndex == -1 || Convert.ToDouble(txt_NguyenGia.Text) < 0 || numericUpDown_SL.Value <= 0 || txt_TinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                return;
            }
            int mataisan = TS_BLL.GetIDbyTS(cbb_TenTS.SelectedItem.ToString());
            int manhacungcap = NCC_BLL.GetIdByNhaCC(cbb_NhaCC.SelectedItem.ToString());
            int maphong = P_BLL.GetIdByPhong(cbb_Phong.SelectedItem.ToString());
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
                SLNhap = Convert.ToInt32(numericUpDown_SL.Value),
                NguyenGia = Convert.ToDouble(txt_NguyenGia.Text),
                TinhTrang = txt_TinhTrang.Text
            });
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

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LoadCBBTS_DoWork(object sender, DoWorkEventArgs e)
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

        private void LoadCBBPhong_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in P_BLL.loadCBBTenPhong_BLL())
            {
                if (cbb_Phong.FindStringExact(i) < 0)
                {
                    cbb_Phong.Invoke(new Action(() =>
                    {
                        cbb_Phong.Items.Add(i);
                    }));
                }
            }
        }

        private void LoadCBBNCC_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string i in NCC_BLL.loadCBBTenNCC())
            {
                if (cbb_NhaCC.FindStringExact(i) < 0)
                {
                    cbb_NhaCC.Invoke(new Action(() =>
                    {
                        cbb_NhaCC.Items.Add(i);
                    }));
                }
            }
        }

        private void NhapForm_Shown(object sender, EventArgs e)
        {
            LoadCBBTS.RunWorkerAsync();
            LoadCBBPhong.RunWorkerAsync();
            LoadCBBNCC.RunWorkerAsync();
        }
    }
}
