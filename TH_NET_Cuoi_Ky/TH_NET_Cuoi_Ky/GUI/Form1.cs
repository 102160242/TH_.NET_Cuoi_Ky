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
        public dd ShowForm;
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
            this.loadAllCBB();
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            ShowTS();
        }
        private void ShowTS()
        {
            dgv.DataSource = TS_BLL.ShowTS_BLL();
        }
        private void Reload()
        {
            ShowTS(); // Load lai du lieu cho DataGridView
            this.loadAllCBB();
            this.Visible = true; // Hien thi lai form
        }
        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO.TaiSan> l = TS_BLL.getTSById(Convert.ToInt32(dgv.SelectedRows[0].Cells["MaTS"].Value.ToString()));
            txtMaTS.Text = l[0].MaTS.ToString();
            txtTenTS.Text = l[0].TenTS;
            txtDvTinh.Text = l[0].DVTinh;
            txtTskt.Text = l[0].TSKT;

            txtGhiChu.Text = l[0].GhiChu;          
            cbbNuocSX.SelectedItem = l[0].NuocSX.TenNuocSX;
            cbbLoaiTS.SelectedItem = l[0].LoaiTS.TenLoaiTS;
            dateTimePicker1.Value = l[0].NamSX;
            
        }
        // CBB
        private void loadAllCBB()
        {
            this.loadCBBPhong();
            this.loadCBBNhaCC();
            this.loadCBBNuocSX();
            this.loadCBBLoaiTS();
        }
        private void loadCBBPhong()
        {
            foreach (string i in P_BLL.loadCBB_BLL())
            {
                if (cbbPhong1.FindStringExact(i) < 0)
                {
                    cbbPhong1.Items.Add(i);
                }
            }
        }
        private void loadCBBNhaCC()
        {
            foreach (string i in NCC_BLL.loadCBB_BLL())
            {
                if (cbbNhaCC1.FindStringExact(i) < 0)
                {
                    cbbNhaCC1.Items.Add(i);
                }
            }
        }
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
            f.ReloadData += Reload;
            f.Show();
            this.Visible = false; // Tam an form
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowForm();
        }
        
    }
}
