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
    public partial class NguoiQLForm : Form
    {
        public delegate void dd();
        public dd ShowForm;

        NguoiQL_BLL Nguoi_BLL;
        public NguoiQLForm()
        {
            InitializeComponent();
            this.Nguoi_BLL = new NguoiQL_BLL();
        }

        private void NguoiQLForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowForm();
            Dispose();
        }

        private void NguoiQLForm_Load(object sender, EventArgs e)
        {

        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            ShowForm();
            Dispose();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO.NguoiQL> list = Nguoi_BLL.GetNguoiQLById(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaNguoiQL"].Value.ToString()));
            txt_MaQL.Text = list[0].MaNguoiQL.ToString();
            txt_TenQL.Text = list[0].TenNguoiQL;
            dateTimePicker1.Value = list[0].NgaySinh;
            txt_SDT.Text = list[0].SoDT;
            if (list[0].GioiTinh == true) rb_Male.Checked = true;
            else rb_Female.Checked = true;

        }
        private void  ShowNguoiQL()
        {
            dataGridView1.DataSource = Nguoi_BLL.ShowNguoiQL_BLL();

        }
        private void but_Show_Click(object sender, EventArgs e)
        {
            ShowNguoiQL();
        }
    }
}
