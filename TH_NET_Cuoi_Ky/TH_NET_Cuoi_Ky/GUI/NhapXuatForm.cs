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
    public partial class NhapXuatForm : Form
    {
        public delegate void dd();
        public dd ShowForm;
        public NhapXuatForm()
        {
            InitializeComponent();
        }

        private void NhapXuatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowForm();
        }
    }
}
