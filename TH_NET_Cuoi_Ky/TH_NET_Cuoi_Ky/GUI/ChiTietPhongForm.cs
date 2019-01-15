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
    public partial class ChiTietPhongForm : Form
    {
        public delegate void dd();
        public dd ShowPhongForm;
        private BLL.Phong_BLL phong_BLL;
        private int maPhong;

        public ChiTietPhongForm()
        {
            InitializeComponent();
            phong_BLL = new BLL.Phong_BLL();
        }
        public void ShowPhongDetail()
        {
            dgv.DataSource = phong_BLL.ShowPhongDetail(this.maPhong);
        }
        public void setMaPhong(int maPhong)
        {
            this.maPhong = maPhong;
        }
        private void ChiTietPhongForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowPhongForm();
        }
        public void setLabel(String TenPhong, String TenNguoiQL)
        {
            labelTenPhong.Text = TenPhong;
            labelNguoiQL.Text = TenNguoiQL;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            String tenPhong = labelTenPhong.Text;

            NhapForm f = new NhapForm();
            f.BackToPreviousForm += ShowPhongDetail;
            f.setCBBTenPhong(tenPhong);
            f.ShowDialog();
        }

        private void thanhLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tenTS = dgv.SelectedRows[0].Cells["TenTS"].Value.ToString();
            String tenNCC = dgv.SelectedRows[0].Cells["TenNhaCC"].Value.ToString();
            String tenPhong = dgv.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            ThanhLy f = new ThanhLy();

            f.allowCBBToBeLoaded = false;
            f.setCBBTenTS(tenTS);
            f.setCBBPhong(tenPhong);
            f.setCBBNhaCC(tenNCC);
            f.BackToPreviousForm += ShowPhongDetail;
            f.ShowDialog();
        }

        private void chuyenPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tenTS = dgv.SelectedRows[0].Cells["TenTS"].Value.ToString();
            String tenNCC = dgv.SelectedRows[0].Cells["TenNhaCC"].Value.ToString();
            String tenPhong = dgv.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            LuanChuyen f = new LuanChuyen();

            f.setCBBTenTS(tenTS);
            f.setCBBPhongXuat(tenPhong);
            f.setCBBNhaCC(tenNCC);
            f.allowCBBToBeLoaded = false;
            f.BackToPreviousForm += ShowPhongDetail;
            f.ShowDialog();
            //this.Visible = false;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                btnThanhLy.Enabled = true;
                btnChuyenPhong.Enabled = true;
            }
            else
            {
                btnThanhLy.Enabled = false;
                btnChuyenPhong.Enabled = false;
            }
        }

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgv.HitTest(e.X, e.Y);
                dgv.ClearSelection();
                if (hti.RowIndex != -1)
                {
                    dgv.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            thanhLyToolStripMenuItem_Click(sender, e);
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            chuyenPhongToolStripMenuItem_Click(sender, e);
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            dgv.DataSource = phong_BLL.Search_TaiSanInPhong(this.maPhong , txtSearch.Text);
        }
    }
}
