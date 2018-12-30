using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH_NET_Cuoi_Ky.GUI;

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
        public void Reload()
        {
            //this.Visible = true;
        }
        private void ChiTietTSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowTSForm();
            Dispose();
        }
        public void setLabel(String TenTS, String TSKT, String DVTinh, String NamSX)
        {
            labelTenTS.Text = TenTS;
            labelTSKT.Text = TSKT;
            labelDonViTinh.Text = DVTinh;
            labelNamSX.Text = NamSX;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var cms = sender as ContextMenuStrip;
            var mousepos = Control.MousePosition;
            if (cms != null)
            {
                var rel_mousePos = cms.PointToClient(mousepos);
                if (cms.ClientRectangle.Contains(rel_mousePos))
                {
                    // Neu menu duoc mo bang chuot
                    var dgv_rel_mousePos = dgv.PointToClient(mousepos);
                    var hti = dgv.HitTest(dgv_rel_mousePos.X, dgv_rel_mousePos.Y);
                    if (hti.RowIndex == -1)
                    {
                        // Huy su kien khi khong co hang nao
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
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
            f.BackToPreviousForm += Reload;
            f.ShowDialog();

            //this.Visible = false;
        }
        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            chuyenPhongToolStripMenuItem_Click(sender, e);
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
            f.BackToPreviousForm += Reload;
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
    }
}
