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
        TaiSan_BLL TS_BLL;
        Phong_BLL P_BLL;
        NhaCC_BLL NCC_BLL;
        NuocSX_BLL NSX_BLL;
        LoaiTS_BLL LTS_BLL;
        public Form1()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
            P_BLL = new Phong_BLL();
            NCC_BLL = new NhaCC_BLL();
            NSX_BLL = new NuocSX_BLL();
            LTS_BLL = new LoaiTS_BLL();
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            dgv.DataSource = TS_BLL.ShowTS_BLL();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        // CBB
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
    }
}
