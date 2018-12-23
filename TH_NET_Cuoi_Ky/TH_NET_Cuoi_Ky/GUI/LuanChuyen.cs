using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_NET_Cuoi_Ky.GUI
{
    public partial class LuanChuyen : Form
    {
        public delegate void dd();
        public dd BackToPreviousForm;
        public bool allowCBBToBeLoaded = true;
        public LuanChuyen()
        {
            InitializeComponent();
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

            }
        }
    }
}
