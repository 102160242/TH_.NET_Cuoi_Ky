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
        public dd ShowNhapXuatForm;
        public LuanChuyen()
        {
            InitializeComponent();
        }

        private void LuanChuyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowNhapXuatForm();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowNhapXuatForm();
            Dispose();
        }
    }
}
