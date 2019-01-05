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
        private bool loadCBBTenTS = true;
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
        public void setCBBTenTS(String tenTS)
        {
            this.loadCBBTenTS = false;
            cbb_TenTS.Items.Clear();
            cbb_TenTS.Items.Add(" ** Thêm mới ** ");
            cbb_TenTS.Items.Add(tenTS);
            cbb_TenTS.SelectedIndex = 1;
            cbb_TenTS.Enabled = false;
        }
        private void LoadCBBTS_DoWork(object sender, DoWorkEventArgs e)
        {
            cbb_TenTS.Invoke(new Action(() =>
            {
                cbb_TenTS.Items.Clear();
                cbb_TenTS.Items.Add(" ** Thêm mới ** ");
            }));
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
            cbb_Phong.Invoke(new Action(() =>
            {
                //cbb_Phong.Items.Clear();
                cbb_Phong.Items.Add(" ** Thêm mới ** ");
            }));
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
            cbb_NhaCC.Invoke(new Action(() =>
            {
                //cbb_NhaCC.Items.Clear();
                cbb_NhaCC.Items.Add(" ** Thêm mới ** ");
            }));
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
            if(this.loadCBBTenTS) LoadCBBTS.RunWorkerAsync();
            LoadCBBPhong.RunWorkerAsync();
            LoadCBBNCC.RunWorkerAsync();
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
        private void addNewTenTS(String tenTS)
        {
            cbb_TenTS.Items.Add(tenTS);
            cbb_TenTS.SelectedItem = tenTS;

        }
        private void addNewPhong(String tenPhong)
        {
            cbb_Phong.Items.Add(tenPhong);
            cbb_Phong.SelectedItem = tenPhong;
        }
        private void addNewNCC(String tenNCC)
        {
            cbb_NhaCC.Items.Add(tenNCC);
            cbb_NhaCC.SelectedItem = tenNCC;
        }
        private void cbb_TenTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_TenTS.SelectedIndex == 0)
            {
                cbb_TenTS.Text = "";
                cbb_TenTS.SelectedIndex = -1;
                TSAddForm f = new TSAddForm();
                f.BackToPreviousForm += () => { };
                f.allowtoReturnTenTS(true);
                f.returnTenTS += addNewTenTS;
                f.ShowDialog();
            }
        }

        private void cbb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Phong.SelectedIndex == 0)
            {
                cbb_Phong.Text = "";
                cbb_Phong.SelectedIndex = -1;
                PhongAddForm f = new PhongAddForm();
                f.BackToPreviousForm += () => { };
                f.allowtoReturnTenPhong(true);
                f.returnTenPhong += addNewPhong;
                f.ShowDialog();
            }
        }

        private void cbb_NhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_NhaCC.SelectedIndex == 0)
            {
                cbb_NhaCC.Text = "";
                cbb_NhaCC.SelectedIndex = -1;
                NhaCCAddForm f = new NhaCCAddForm();
                f.BackToPreviousForm += () => { };
                f.allowtoReturnTenNCC(true);
                f.returnTenNCC += addNewNCC;
                f.ShowDialog();
            }
        }
    }
}
