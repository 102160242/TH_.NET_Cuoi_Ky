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
    public partial class Import_ExportTSForm : Form
    {
        public delegate DataGridView dd();
        public dd getDGV;
        private bool isFinished;
        private bool isImportProgress;
        public Import_ExportTSForm()
        {
            InitializeComponent();
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
                if (exportWorker.IsBusy) exportWorker.CancelAsync();
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
                DataGridView dgv = getDGV();
                //Loop through each row and read value from each column.
                for (int i = -1; i < dgv.RowCount; i++)
                {
                    if (i != -1)
                        exportWorker.ReportProgress(((i + 1) / dgv.RowCount) * 100);
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
            }
            else
            {
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    exportWorker.RunWorkerAsync(argument: saveFileDialog.FileName);
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
    }
}
