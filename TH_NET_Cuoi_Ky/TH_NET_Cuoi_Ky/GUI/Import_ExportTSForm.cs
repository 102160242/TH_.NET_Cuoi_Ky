using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using TH_NET_Cuoi_Ky.BLL;

namespace TH_NET_Cuoi_Ky.GUI
{
    public partial class Import_ExportTSForm : Form
    {
        public delegate DataGridView dd();
        public dd getDGV;
        private bool isFinished;
        private bool isImportProgress;
        TaiSan_BLL TS_BLL;
        NuocSX_BLL NSX_BLL;
        LoaiTS_BLL LTS_BLL;
        public Import_ExportTSForm()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
            NSX_BLL = new NuocSX_BLL();
            LTS_BLL = new LoaiTS_BLL();
            this.isFinished = false;
            this.isImportProgress = false;
        }
        public void startExportingData()
        {
            this.isImportProgress = false;
        }
        public void startImportingData()
        {
            this.isImportProgress = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (this.isFinished)
            {
                Dispose();
            }
            else
            {
                btn.Enabled = false;
                if (exportWorker.IsBusy) exportWorker.CancelAsync();
                if (importWorker.IsBusy) importWorker.CancelAsync();
            }
        }

        private void exportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            label.Invoke(new Action(() =>
            {
                label.Text = "Chuẩn bị xuất dữ liệu...";
            }));
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            try
            {

                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Tài Sản";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;
                if (exportWorker.CancellationPending)
                {
                    e.Cancel = true; // Dung xuat du lieu neu bam nut Cancel
                    return;
                }
                DataGridView dgv = getDGV();
                //Loop through each row and read value from each column.
                for (int i = -1; i < dgv.RowCount; i++)
                {
                    if (exportWorker.CancellationPending)
                    {
                        e.Cancel = true; // Dung xuat du lieu neu bam nut Cancel
                        return;
                    }
                    if (i != -1)
                    {
                        int percent = (int)((float)(i + 1) / dgv.RowCount * 100);
                        exportWorker.ReportProgress(percent);
                    }
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                /*SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;*/

                // if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // {
                workbook.SaveAs(saveFileDialog.FileName);
                // }
            }
            catch (System.Exception ex)
            {
                label.Invoke(new Action(() =>
                {
                    label.Text = ex.Message;
                }));
                exportWorker.CancelAsync();
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void Import_ExportTSForm_Shown(object sender, EventArgs e)
        {
            if (this.isImportProgress)
            {
                openFileDialog.ShowDialog();
                if (openFileDialog.FileName != "")
                {
                    importWorker.RunWorkerAsync();
                }
                else
                {
                    Dispose();
                }
            }
            else
            {
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    exportWorker.RunWorkerAsync();
                }
                else
                {
                    Dispose();
                }
            }
        }

        private void exportWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label.Invoke(new Action(() =>
            {
                label.Text = "Đang xuất dữ liệu (" + e.ProgressPercentage + "%)";
            }));
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Value = e.ProgressPercentage;
            }));
        }

        private void exportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                label.Invoke(new Action(() =>
                {
                    label.Text = "Có lỗi xảy ra trong quá trình xuất dữ liệu!";
                }));
            }
            else if (e.Cancelled)
            {
                label.Invoke(new Action(() =>
                {
                    label.Text = "Quá trình bị hủy!";
                }));
                btn.Enabled = true;
            }
            else
            {
                label.Invoke(new Action(() =>
                {
                    label.Text = "Xuất dữ liệu hoàn thành!";
                }));
                progressBar1.Invoke(new Action(() =>
                {
                    progressBar1.Value = 100;
                }));
            }
            btn.Invoke(new Action(() =>
            {
                btn.Text = "Thoát";
                this.isFinished = true;
            }));
        }

        private void importWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            label.Invoke(new Action(() =>
            {
                label.Text = "Chuẩn bị nhập dữ liệu...";
            }));
            DataTable dt = new DataTable();
            DataRow dr;
            List<DTO.TaiSan> l = new List<DTO.TaiSan>();
            l = TS_BLL.GetTaiSan();
            List<string> abc = new List<string>();
            foreach(DTO.TaiSan i in l)
            {
                abc.Add(i.TenTS);
            }
            //tao doi tuong mo tep tin
            //OpenFileDialog fopen = new OpenFileDialog();
            //chi ra duoi
            //fopen.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //openFileDialog.ShowDialog();
            //xu ly
            //if (openFileDialog.FileName != "")
            //{
            //tao doi tuong excel
            Excel.Application app = new Excel.Application();
            //mo tap ex
            Excel.Workbook wb = app.Workbooks.Open(openFileDialog.FileName);
            try
            {
                // mo sheet
                Excel._Worksheet sheet = wb.Sheets[1];
                // tham chieu toi vung du lieu trong excel
                Excel.Range range = sheet.UsedRange;
                //doc du lieu
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;
                //doc dong tieu de 
                for (int i = 1; i <= cols; i++)
                {
                    string s = sheet.Cells[1, i].Value;
                    dt.Columns.Add(s);
                }
                //doc du lieu
                for (int i = 2; i <= rows; i++)
                {
                    if (importWorker.CancellationPending)
                    {
                        e.Cancel = true; // Dung xuat du lieu neu bam nut Cancel
                        return;
                    }
                    label.Invoke(new Action(() =>
                    {
                        label.Text = "Đang đọc dữ liệu (" + (i - 1) + "/" + rows + ")...";
                    }));
                    dr = dt.NewRow();
                    for (int j = 1; j <= cols; j++)
                    {
                        dr[j - 1] = sheet.Cells[i, j].Value;
                    }
                    dt.Rows.Add(dr);
                }
                List<DTO.TaiSan> ladd = new List<DTO.TaiSan>();
                for (int i = 0; i <= rows; i++)
                {
                    if (importWorker.CancellationPending)
                    {
                        e.Cancel = true; // Dung xuat du lieu neu bam nut Cancel
                        return;
                    }
                    int percent = (int)((float)(i + 1) / rows * 100);
                    importWorker.ReportProgress(percent);
                    if (NSX_BLL.getIDByName(dt.Rows[i]["TenNuocSX"].ToString()) == -1)
                    {
                        List<DTO.NuocSX> list = new List<DTO.NuocSX>();
                        list.Add(new DTO.NuocSX
                        {
                            TenNuocSX = dt.Rows[i]["TenNuocSX"].ToString(),
                        });
                        NSX_BLL.addNSX(list);
                    }
                    if (LTS_BLL.getIDByName(dt.Rows[i]["TenLoaiTS"].ToString()) == -1)
                    {
                        List<DTO.LoaiTS> list = new List<DTO.LoaiTS>();
                        list.Add(new DTO.LoaiTS
                        {
                            TenLoaiTS = dt.Rows[i]["TenLoaiTS"].ToString(),
                        });
                        LTS_BLL.addLoaiTS(list);
                    }
                    DTO.TaiSan ts = new DTO.TaiSan
                    {
                        TenTS = dt.Rows[i]["TenTS"].ToString(),
                        TSKT = dt.Rows[i]["TSKT"].ToString(),
                        DVTinh = dt.Rows[i]["DVTinh"].ToString(),
                        NamSX = Convert.ToInt32(dt.Rows[i]["NamSX"]),
                        MaNuocSX = NSX_BLL.getIDByName(dt.Rows[i]["TenNuocSX"].ToString()),
                        MaLoaiTS = LTS_BLL.getIDByName(dt.Rows[i]["TenLoaiTS"].ToString()),
                        GhiChu = dt.Rows[i]["GhiChu"].ToString()
                    };
                    if (!abc.Contains(ts.TenTS))
                    {
                        abc.Add(ts.TenTS);
                        TS_BLL.addTS(new List<DTO.TaiSan> { ts });
                    }


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label.Invoke(new Action(() =>
                {
                    label.Text = ex.Message;
                }));
                importWorker.CancelAsync();
            }
            /* }
             else
             {
                 MessageBox.Show("Bạn không chọn tệp tin nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }

        private void importWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label.Invoke(new Action(() =>
            {
                label.Text = "Đang nhập dữ liệu (" + e.ProgressPercentage + "%)";
            }));
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Value = e.ProgressPercentage;
            }));
        }

        private void importWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                label.Invoke(new Action(() =>
                {
                    label.Text = "Có lỗi xảy ra trong quá trình nhập dữ liệu!";
                }));
            }
            else if (e.Cancelled)
            {
                label.Invoke(new Action(() =>
                {
                    label.Text = "Quá trình bị hủy!";
                }));
                btn.Enabled = true;
            }
            else
            {
                label.Invoke(new Action(() =>
                {
                    label.Text = "Nhập dữ liệu hoàn thành!";
                }));
                progressBar1.Invoke(new Action(() =>
                {
                    progressBar1.Value = 100;
                }));
            }
            btn.Invoke(new Action(() =>
            {
                btn.Text = "Thoát";
                this.isFinished = true;
            }));
        }
    }
}
