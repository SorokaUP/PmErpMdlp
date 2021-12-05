using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace PMMarkingUI.Forms
{
    public partial class frmImportExcelForCreateDocument : Form
    {
        public DataTable dtData { get; private set; }
        public frmImportExcelForCreateDocument(DataTable dtData)
        {
            InitializeComponent();
            this.dtData = dtData;
        }

        decimal d = 0;
        private void btnOk_Click(object sender, EventArgs e)
        {
            int colOBJECT_ID = (int)nudOBJECT_ID.Value - 1;
            int colCOST = (int)nudCOST.Value - 1;
            int colVAT_VALUE = (int)nudVAT_VALUE.Value - 1;

            OpenFileDialog ofdFile = new OpenFileDialog();
            ofdFile.Filter = "Excel 2007 (*.xlsx)|*.xlsx|Excel '97-2003 (*.xls)|.xls";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(ofdFile.FileName, FileMode.Open))
                    {
                        using (frmProccess process = new frmProccess())
                        {
                            IExcelDataReader edr = (ofdFile.FileName.IndexOf(".xlsx") > 0)
                                ? ExcelReaderFactory.CreateOpenXmlReader(stream) // OpenXml Excel file (2007 format; *.xlsx)
                                : ExcelReaderFactory.CreateBinaryReader(stream); // Binary Excel file ('97-2003 format; *.xls)
                                                                                 // Извлечение данных в память
                            DataSet result = edr.AsDataSet(); // Метод находится в NuGet: ExcelDataReader.DataSet
                                                              // Определяем таблицу

                            process.progressBarControl.Properties.Maximum = result.Tables[0].Rows.Count;
                            process.Show();
                            int colCount = result.Tables[0].Columns.Count;
                            foreach (DataRow edrRow in result.Tables[0].Rows)
                            {
                                DataRow row = dtData.NewRow();
                                row["OBJECT_ID"] = edrRow[colOBJECT_ID].ToString();
                                if (colCount - 1 >= colCOST)
                                {
                                    decimal.TryParse(edrRow[colCOST].ToString(), out d);
                                    row["COST"] = d;
                                }
                                if (colCount - 1 >= colCOST)
                                {
                                    decimal.TryParse(edrRow[colVAT_VALUE].ToString(), out d);
                                    row["VAT_VALUE"] = d;
                                }
                                dtData.Rows.Add(row);

                                process.progressBarControl.Position++;
                                Application.DoEvents();
                            }

                            process.Close();
                            MessageBox.Show("Excel файл успешно загружен.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
