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
    public partial class ThanhLy : Form
    {
        public delegate void dd();
        public dd BackToPreviousForm;
        public bool allowCBBToBeLoaded = true;
        public ThanhLy()
        {
            InitializeComponent();
        }

        private void ThanhLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToPreviousForm();
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

            }
        }
    }
}
