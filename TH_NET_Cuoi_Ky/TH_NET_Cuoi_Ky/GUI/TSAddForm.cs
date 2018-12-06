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
    public partial class AddFormTS : Form
    {
        public delegate void dd();
        public dd ShowTSForm;
        TaiSan_BLL TS_BLL;
        NuocSX_BLL NSX_BLL;
        LoaiTS_BLL LTS_BLL;

        public AddFormTS()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
            NSX_BLL = new NuocSX_BLL();
            LTS_BLL = new LoaiTS_BLL();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ShowTSForm();
            Dispose();
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            int maNuocSX = NSX_BLL.getIDByName(cbbNuocSX.SelectedItem.ToString());
            int maLoaiTS = LTS_BLL.getIDByName(cbbLoaiTS.SelectedItem.ToString());
            if (maNuocSX == -1 || maLoaiTS == -1)
            {
                MessageBox.Show("Không tồn tại Nước Sản Xuất hoặc Loại Tài Sản đã chọn!");
            }
            else
            {
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
                Boolean result = TS_BLL.addTS(l);

                if(result)
                {
                    // Neu add thanh cong thi hien lai Form Tai San
                    ShowTSForm();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Không thể thêm Tài Sản mới. Vui lòng thử lại sau!");
                }
            }

        }
        private void loadCBBNuocSX()
        {
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
            foreach (string i in LTS_BLL.loadCBB_BLL())
            {
                if (cbbLoaiTS.FindStringExact(i) < 0)
                {
                    cbbLoaiTS.Items.Add(i);
                }
            }
        }
        private void AddFormTS_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowTSForm();
            Dispose();
        }

        private void AddFormTS_Shown(object sender, EventArgs e)
        {
            loadCBBNuocSX();
            loadCBBLoaiTS();
        }
    }
}
