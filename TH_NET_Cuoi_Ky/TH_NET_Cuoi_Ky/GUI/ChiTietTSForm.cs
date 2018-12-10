using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_NET_Cuoi_Ky
{
    public partial class ChiTietTSForm : Form
    {
        public delegate void dd();
        public dd ShowTSForm;
        BLL.TaiSan_BLL TS_BLL;
        public ChiTietTSForm()
        {
            InitializeComponent();
            TS_BLL = new BLL.TaiSan_BLL();
        }
        public void ShowTSDetail(int maTS)
        {
            dgv.DataSource = TS_BLL.ShowTSDetail(maTS);
        }
        private void ChiTietTSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowTSForm();
            Dispose();
        }
    }
}
