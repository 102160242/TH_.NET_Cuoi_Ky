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
        public delegate void dd();
        public dd ShowForm;
        public NhapXuatForm()
        {
            InitializeComponent();
            Ts_BLL = new TaiSan_BLL();
            NCC_BLL = new NhaCC_BLL();
            p_BLL = new Phong_BLL();
            LoadCbbNhaCC();
            LoadCbbPhong();
            LoadCbbTenTS();
        }

        private void NhapXuatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowForm();
        }

        private void bnt_Nhap_Click(object sender, EventArgs e)
        {

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
            foreach (string i in NCC_BLL.loadCBBTenNCC())
            {
                if (cbb_NhaCCXuat.FindStringExact(i) < 0)
                    cbb_NhaCCXuat.Items.Add(i);
            }
        }
        private void LoadCbbPhong()
        {
            foreach (string i in p_BLL.loadCBBTenPhong_BLL())
            {
                if (cbb_PhongXuat.FindStringExact(i) < 0)
                    cbb_PhongXuat.Items.Add(i);
            }
            foreach (string i in p_BLL.loadCBBTenPhong_BLL())
            {
                if (cbb_PhongNhap.FindStringExact(i) < 0)
                    cbb_PhongNhap.Items.Add(i);
            }
        }
    }
}
