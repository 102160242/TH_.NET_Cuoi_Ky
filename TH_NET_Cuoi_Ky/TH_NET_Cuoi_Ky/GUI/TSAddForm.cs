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
using TH_NET_Cuoi_Ky.GUI;

namespace TH_NET_Cuoi_Ky.GUI
{
    public partial class TSAddForm : Form
    {
        public delegate void dd();
        public delegate void dd2(String s);
        public dd BackToPreviousForm;
        public dd2 returnTenTS;
        private bool allow = false;
        TaiSan_BLL TS_BLL;
        NuocSX_BLL NSX_BLL;
        LoaiTS_BLL LTS_BLL;
        public void allowtoReturnTenTS(bool value)
        {
            this.allow = value;
        }

        public TSAddForm()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
            NSX_BLL = new NuocSX_BLL();
            LTS_BLL = new LoaiTS_BLL();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            if(txtTenTS.Text == "" || txtDvTinh.Text == "" || txtTskt.Text == "" || cbbLoaiTS.SelectedIndex == -1 || cbbNuocSX.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            int maNuocSX = NSX_BLL.getIDByName(cbbNuocSX.SelectedItem.ToString());
            int maLoaiTS = LTS_BLL.getIDByName(cbbLoaiTS.SelectedItem.ToString());
            if (maNuocSX == -1 || maLoaiTS == -1)
            {
                MessageBox.Show("Không tồn tại Nước Sản Xuất hoặc Loại Tài Sản đã chọn!");
                return;
            }

            List<DTO.TaiSan> l = new List<DTO.TaiSan>();
            l.Add(new DTO.TaiSan
            {
                TenTS = txtTenTS.Text,
                DVTinh = txtDvTinh.Text,
                TSKT = txtTskt.Text,
                MaNuocSX = maNuocSX,
                NamSX = dateTimePicker1.Value.Year,
                MaLoaiTS = maLoaiTS,
                GhiChu = txtGhiChu.Text
            });
            (bool result, string msg) = TS_BLL.addTS(l);

            if(result)
            {
                // Neu add thanh cong thi hien lai Form Tai San
                BackToPreviousForm();
                if (this.allow) returnTenTS(txtTenTS.Text);
                Dispose();
            }
            else
            {
                MessageBox.Show(msg, "Lỗi");
            }      

        }
        //private void loadCBBNuocSX()
        //{
        //    foreach (string i in NSX_BLL.loadCBB_BLL())
        //    {
        //        if (cbbNuocSX.FindStringExact(i) < 0)
        //        {
        //            cbbNuocSX.Items.Add(i);
        //        }
        //    }
        //}
        //private void loadCBBLoaiTS()
        //{
        //    foreach (string i in LTS_BLL.loadCBB_BLL())
        //    {
        //        if (cbbLoaiTS.FindStringExact(i) < 0)
        //        {
        //            cbbLoaiTS.Items.Add(i);
        //        }
        //    }
        //}
        private void AddFormTS_FormClosed(object sender, FormClosedEventArgs e)
        {
            //BackToPreviousForm();
            Dispose();
        }

        private void AddFormTS_Shown(object sender, EventArgs e)
        {
            loadCBBNSX.RunWorkerAsync();
            loadCBBLTS.RunWorkerAsync();
        }
        private void loadCBBNuocSX()
        {
            cbbNuocSX.Items.Clear();
            cbbNuocSX.Items.Add(" ** Thêm mới ** ");
            foreach (string i in NSX_BLL.loadCBB_BLL())
            {
                if (cbbNuocSX.FindStringExact(i) < 0)
                {
                    cbbNuocSX.Items.Add(i);
                }
            }
        }
        private void loadCBBLoaiTS()
        {
            cbbLoaiTS.Items.Clear();
            cbbLoaiTS.Items.Add(" ** Thêm mới ** ");
            foreach (string i in LTS_BLL.loadCBB_BLL())
            {
                if (cbbLoaiTS.FindStringExact(i) < 0)
                {
                    cbbLoaiTS.Items.Add(i);
                }
            }
        }
        private void addNewNuocSX(String tenNSX)
        {
            cbbNuocSX.Items.Add(tenNSX);
            cbbNuocSX.SelectedItem = tenNSX;
        }
        private void addNewLoaiTS(String tenLoaiTS)
        {
            cbbLoaiTS.Items.Add(tenLoaiTS);
            cbbLoaiTS.SelectedItem = tenLoaiTS;
        }
        private void loadCBBNSX_DoWork(object sender, DoWorkEventArgs e)
        {
            // Xoa moi danh sach co trong CBB truoc khi load (phong truong hop load lai)
            cbbNuocSX.Invoke(new Action(() =>
            {
                cbbNuocSX.Items.Clear();
                cbbNuocSX.Items.Add(" ** Thêm mới ** ");
            }));
            foreach (string i in NSX_BLL.loadCBB_BLL())
            {
                if (cbbNuocSX.FindStringExact(i) < 0)
                {
                    cbbNuocSX.Invoke(new Action(() =>
                    {
                        cbbNuocSX.Items.Add(i);
                    }));
                }
            }
        }

        private void loadCBBLTS_DoWork(object sender, DoWorkEventArgs e)
        {
            // Xoa moi danh sach co trong CBB truoc khi load (phong truong hop load lai)
            cbbLoaiTS.Invoke(new Action(() =>
            {
                cbbLoaiTS.Items.Clear();
                cbbLoaiTS.Items.Add(" ** Thêm mới ** ");
            }));
            foreach (string i in LTS_BLL.loadCBB_BLL())
            {
                if (cbbLoaiTS.FindStringExact(i) < 0)
                {
                    cbbLoaiTS.Invoke(new Action(() =>
                    {
                        cbbLoaiTS.Items.Add(i);
                    }));
                }
            }
        }

        private void cbbNuocSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNuocSX.SelectedIndex == 0)
            {
                cbbNuocSX.SelectedIndex = -1;
                cbbNuocSX.Text = "";
                NuocSXAddform f = new NuocSXAddform();
                f.BackToPreviousForm += () => { };
                f.allowReturnNuocSX(true);
                f.returnNuocSX += addNewNuocSX;
                f.ShowDialog();
            }
        }

        private void cbbLoaiTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiTS.SelectedIndex == 0)
            {
                cbbLoaiTS.SelectedIndex = -1;
                cbbLoaiTS.Text = "";
                LoaiTSAddForm f = new LoaiTSAddForm();
                f.BackToPreviousForm += () => { };
                f.allowtoReturnTenLoaiTS(true);
                f.returnTenLoaiTS += addNewLoaiTS;
                f.ShowDialog();

            }
        }

        private void TSAddForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) // Enter de add
            {
                this.butAdd_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Escape) // Thoat neu nhan Esc
            {
                this.butCancel_Click(sender, e);
            }
        }
    }
}
