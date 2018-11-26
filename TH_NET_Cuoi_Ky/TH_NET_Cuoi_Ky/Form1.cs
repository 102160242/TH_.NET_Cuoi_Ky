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
        public Form1()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            dgv.DataSource = TS_BLL.ShowTS_BLL();
        }
    }
}
