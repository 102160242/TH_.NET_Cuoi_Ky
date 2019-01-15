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
        Phong_BLL P_BLL;
        NhaCC_BLL NCC_BLL;
        NhapXuat_BLL NX_BLL;
        NguoiQL_BLL NQL_BLL;
        public Import_ExportTSForm()
        {
            InitializeComponent();
            TS_BLL = new TaiSan_BLL();
            NSX_BLL = new NuocSX_BLL();
            LTS_BLL = new LoaiTS_BLL();
            P_BLL = new Phong_BLL();
            NCC_BLL = new NhaCC_BLL();
            NX_BLL = new NhapXuat_BLL();
            NQL_BLL = new NguoiQL_BLL();
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
            excel.DisplayAlerts = false;
            try
            {
                // Lay so luong phong
                DataGridView dgv = getDGV();
                int SLPhong = dgv.Rows.Count - 1;
                for (int k = 0; k < SLPhong; k++)
                {
                    label.Invoke(new Action(() =>
                    {
                        label.Text = "Đang xuất dữ liệu phòng " + dgv.Rows[k].Cells["TenPhong"].Value.ToString();
                    }));
                    if (k == 0)
                    {
                        worksheet = workbook.ActiveSheet;
                    }
                    else
                    {
                        worksheet = workbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Excel.Worksheet;
                    }

                    // Ten Phong
                    worksheet.Name = dgv.Rows[k].Cells["TenPhong"].Value.ToString();
                    int maPhong = Convert.ToInt32(dgv.Rows[k].Cells["MaPhong"].Value.ToString());
                    DataTable dt = P_BLL.export(maPhong);

                    // Add header
                    worksheet.Range[worksheet.Cells[1, 2], worksheet.Cells[1, 11]].Merge();
                    worksheet.Range[worksheet.Cells[1, 12], worksheet.Cells[1, 15]].Merge();
                    worksheet.Cells[1, 2] = "Ghi tăng";
                    worksheet.Cells[1, 2].EntireRow.Font.Bold = true;
                    worksheet.Cells[1, 2].EntireRow.Font.Size = 13;
                    worksheet.Cells[1, 12] = "Ghi giảm";
                    worksheet.Cells[1, 12].EntireRow.Font.Bold = true;
                    worksheet.Cells[1, 12].EntireRow.Font.Size = 13;

                    for (int i = 1; i <= dt.Columns.Count; i++)
                    {
                        worksheet.Cells[2, i] = dt.Columns[i - 1].ColumnName;
                        worksheet.Cells[2, i].EntireRow.Font.Bold = true;
                    }

                    //int cellRowIndex = 3;
                    //int cellColumnIndex = 1;
                    //Loop through each row and read value from each column.

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (exportWorker.CancellationPending)
                        {
                            e.Cancel = true; // Dung xuat du lieu neu bam nut Cancel
                            excel.Quit();
                            return;
                        }
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 3, j + 1] = dt.Rows[i][j];
                        }
                    }

                    int percent = (int)((float)(k + 1) / SLPhong * 100);
                    exportWorker.ReportProgress(percent);

                    //for (int i = -1; i < dgv.RowCount; i++)
                    //{
                    //    if (exportWorker.CancellationPending)
                    //    {
                    //        e.Cancel = true; // Dung xuat du lieu neu bam nut Cancel
                    //        excel.Quit();
                    //        return;
                    //    }
                    //    if (i != -1)
                    //    {
                    //        int percent = (int)((float)(i + 1) / dgv.RowCount * 100);
                    //        exportWorker.ReportProgress(percent);
                    //    }
                    //    for (int j = 0; j < dgv.Columns.Count; j++)
                    //    {
                    //        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                    //        if (cellRowIndex == 1)
                    //        {
                    //            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv.Columns[j].HeaderText;
                    //        }
                    //        else
                    //        {
                    //            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv.Rows[i].Cells[j].Value.ToString();
                    //        }
                    //        cellColumnIndex++;
                    //    }
                    //    cellColumnIndex = 1;
                    //    cellRowIndex++;
                    //}
                }
                //Getting the location and file name of the excel to save from user.
                /*SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;*/

                // if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // {
                excel.Columns.AutoFit();
                workbook.SaveAs(saveFileDialog.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
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
                //List<DTO.TaiSan> l = new List<DTO.TaiSan>();
                //l = TS_BLL.GetTaiSan();
                //List<string> abc = new List<string>();
                //foreach (DTO.TaiSan i in l)
                //{
                //    abc.Add(i.TenTS);
                //}
                for(int k = 1; k <= wb.Sheets.Count; k++)
                {
                    Excel._Worksheet sheet = wb.Sheets[k];
                    // Kiem tra xem ton tai Phong hay chua
                    Console.Write(sheet.Name.ToString());
                    string sheetName = sheet.Name.ToString();
                    int maPhong = P_BLL.getIDByName(sheetName);
                    if(maPhong == -1)
                    {
                        List<DTO.NguoiQL> list = NQL_BLL.GetNguoiQLById(1);
                        if (list.Count == 0)
                        {
                            NQL_BLL.addNguoiQL(new List<DTO.NguoiQL>
                            {
                                new DTO.NguoiQL
                                {
                                    //MaNguoiQL = 1,
                                    TenNguoiQL = "Admin",
                                    SoDT = "0123456789",
                                    NgaySinh = Convert.ToDateTime("1 Jan 1980"),
                                    GioiTinh = true
                                }
                            });
                        }
                        List<DTO.Phong> l = new List<DTO.Phong>();
                        l.Add(new DTO.Phong
                        {
                            TenPhong = sheet.Name,
                            MaNguoiQL = 1
                        });
                        P_BLL.addPhong(l);
                        maPhong = P_BLL.getIDByName(sheetName);
                    }
                    // mo sheet
                    //Excel._Worksheet sheet = wb.Sheets[1];

                    // tham chieu toi vung du lieu trong excel
                    Excel.Range range = sheet.UsedRange;
                    //doc du lieu
                    int rows = range.Rows.Count;
                    int cols = range.Columns.Count;

                    //doc dong tieu de 
                    DataTable dt = new DataTable();
                    DataRow dr;
                    for (int i = 1; i <= cols; i++)
                    {
                        string s = sheet.Cells[2, i].Value;
                        dt.Columns.Add(s);
                    }

                    //doc du lieu
                    for (int i = 3; i <= rows; i++)
                    {
                        if (importWorker.CancellationPending)
                        {
                            e.Cancel = true; // Dung xuat du lieu neu bam nut Cancel
                            app.Quit();
                            return;
                        }
                        label.Invoke(new Action(() =>
                        {
                            label.Text = "Đang đọc dữ liệu phòng " + sheetName + "(" + (i - 1) + "/" + rows + ")...";
                        }));
                        dr = dt.NewRow();
                        for (int j = 1; j <= cols; j++)
                        {
                            dr[j - 1] = sheet.Cells[i, j].Value;
                        }
                        dt.Rows.Add(dr);
                    }
                    // Import du lieu
                    foreach(DataRow row in dt.Rows)
                    {
                        if (row["Tên Tài Sản"].ToString() == "") break;
                        int maTS = TS_BLL.getIDByVariousFactors(row["Tên Tài Sản"].ToString(), row["Thông số kỹ thuật"].ToString(), row["Nước sản xuất"].ToString(), row["Loại tài sản"].ToString(), row["Nhà cung cấp"].ToString(), row["Đơn vị tính"].ToString(), Convert.ToInt32(row["Năm sản xuất"].ToString()));
                        if (maTS == -1)
                        {
                            int maNSX = NSX_BLL.getIDByName(row["Nước sản xuất"].ToString());
                            if (maNSX == -1)
                            {
                                List<DTO.NuocSX> list = new List<DTO.NuocSX>();
                                list.Add(new DTO.NuocSX
                                {
                                    TenNuocSX = row["Nước sản xuất"].ToString(),
                                });
                                NSX_BLL.addNSX(list);
                                maNSX = NSX_BLL.getIDByName(row["Nước sản xuất"].ToString());
                            }
                            int maLTS = LTS_BLL.getIDByName(row["Loại tài sản"].ToString());
                            if (maLTS == -1)
                            {
                                List<DTO.LoaiTS> list = new List<DTO.LoaiTS>();
                                list.Add(new DTO.LoaiTS
                                {
                                    TenLoaiTS = row["Loại tài sản"].ToString(),
                                });
                                LTS_BLL.addLoaiTS(list);
                                maLTS = LTS_BLL.getIDByName(row["Loại tài sản"].ToString());
                            }
                            List<DTO.TaiSan> l = new List<DTO.TaiSan>();
                            l.Add(new DTO.TaiSan
                            {
                                TenTS = row["Tên Tài Sản"].ToString(),
                                TSKT = row["Thông số kỹ thuật"].ToString(),
                                DVTinh = row["Đơn vị tính"].ToString(),
                                NamSX = Convert.ToInt32(row["Năm sản xuất"].ToString()),
                                MaNuocSX = maNSX,
                                MaLoaiTS = maLTS,
                            });
                            TS_BLL.addTS(l);
                            maTS = TS_BLL.getIDByVariousFactors(row["Tên Tài Sản"].ToString(), row["Thông số kỹ thuật"].ToString(), row["Nước sản xuất"].ToString(), row["Loại tài sản"].ToString(), row["Nhà cung cấp"].ToString(), row["Đơn vị tính"].ToString(), Convert.ToInt32(row["Năm sản xuất"].ToString()));
                        }

                        int maNCC = NCC_BLL.getIDByName(row["Nhà cung cấp"].ToString());
                        if (maNCC == -1)
                        {
                            List<DTO.NhaCC> list = new List<DTO.NhaCC>();
                            list.Add(new DTO.NhaCC
                            {
                                TenNhaCC = row["Nhà cung cấp"].ToString(),
                                DiaChi = "Việt Nam"
                            });
                            NCC_BLL.addNhaCC(list);
                            maNCC = NCC_BLL.getIDByName(row["Nhà cung cấp"].ToString());
                        }
                        NX_BLL.AddNhapXuat(new List<DTO.NhapXuat> {
                            new DTO.NhapXuat
                            {
                                MaTS = maTS,
                                MaNhaCC = maNCC,
                                MaPhong = maPhong,
                                NgayNhap = Convert.ToDateTime(row["Ngày Nhập"]),
                                SLNhap = Convert.ToInt32(row["SL Nhập"].ToString()),
                                NguyenGia = Convert.ToDouble(row["Thành tiền"].ToString()),
                                TinhTrang = "Mới",
                            }
                        });

                        if(row["Ngày Xuất"].ToString() != "")
                        {
                            List<DTO.NhapXuat> l = new List<DTO.NhapXuat>();
                            l.Add(new DTO.NhapXuat
                            {
                                MaTS = maTS,
                                MaNhaCC = maNCC,
                                MaPhong = maPhong,
                                NgayXuat = Convert.ToDateTime(row["Ngày Xuất"]),
                                SLXuat = Convert.ToInt32(row["SL Xuất"].ToString()),
                                NguyenGia = Convert.ToDouble(row["Thành tiền"].ToString()),
                                TinhTrang = row["Tình trạng"].ToString(),
                            });
                            NX_BLL.AddNhapXuat(l);
                        }
                    }
                    int percent = (int)((float)k / wb.Sheets.Count * 100);
                    importWorker.ReportProgress(percent);
                    //List<DTO.TaiSan> ladd = new List<DTO.TaiSan>();
                    //for (int i = 0; i <= rows; i++)
                    //{
                    //    if (importWorker.CancellationPending)
                    //    {
                    //        e.Cancel = true; // Dung xuat du lieu neu bam nut Cancel
                    //        app.Quit();
                    //        return;
                    //    }
                    //    int percent = (int)((float)(i + 1) / rows * 100);
                    //    importWorker.ReportProgress(percent);
                    //    if (NSX_BLL.getIDByName(dt.Rows[i]["TenNuocSX"].ToString()) == -1)
                    //    {
                    //        List<DTO.NuocSX> list = new List<DTO.NuocSX>();
                    //        list.Add(new DTO.NuocSX
                    //        {
                    //            TenNuocSX = dt.Rows[i]["TenNuocSX"].ToString(),
                    //        });
                    //        NSX_BLL.addNSX(list);
                    //    }
                    //    if (LTS_BLL.getIDByName(dt.Rows[i]["TenLoaiTS"].ToString()) == -1)
                    //    {
                    //        List<DTO.LoaiTS> list = new List<DTO.LoaiTS>();
                    //        list.Add(new DTO.LoaiTS
                    //        {
                    //            TenLoaiTS = dt.Rows[i]["TenLoaiTS"].ToString(),
                    //        });
                    //        LTS_BLL.addLoaiTS(list);
                    //    }
                    //    DTO.TaiSan ts = new DTO.TaiSan
                    //    {
                    //        TenTS = dt.Rows[i]["TenTS"].ToString(),
                    //        TSKT = dt.Rows[i]["TSKT"].ToString(),
                    //        DVTinh = dt.Rows[i]["DVTinh"].ToString(),
                    //        NamSX = Convert.ToInt32(dt.Rows[i]["NamSX"]),
                    //        MaNuocSX = NSX_BLL.getIDByName(dt.Rows[i]["TenNuocSX"].ToString()),
                    //        MaLoaiTS = LTS_BLL.getIDByName(dt.Rows[i]["TenLoaiTS"].ToString()),
                    //        GhiChu = dt.Rows[i]["GhiChu"].ToString()
                    //    };
                    //    if (!abc.Contains(ts.TenTS))
                    //    {
                    //        abc.Add(ts.TenTS);
                    //        TS_BLL.addTS(new List<DTO.TaiSan> { ts });
                    //    }
                    //}
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
            finally
            {
                app.Quit();
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
