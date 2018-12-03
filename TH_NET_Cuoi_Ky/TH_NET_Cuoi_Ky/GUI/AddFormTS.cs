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
    public partial class AddFormTS : Form
    {
        public delegate void dd();
        public dd ReloadData;
        public AddFormTS()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ReloadData();
            Dispose();
        }
        private void Add()
        {
            // Add doi tuong moi vao CSDL
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
           // Add();
            ReloadData();
            Dispose();
        }

        private void AddFormTS_Load(object sender, EventArgs e)
        {

        }
    }
}
