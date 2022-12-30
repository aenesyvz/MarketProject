using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Dtos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using word = Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace MarketProject.Forms.Admin
{
    public partial class TopluMusteriBorcRapor : Form
    {
        private readonly IDebtCustomerService _debtCustomerService = new DebtCustomerManager();

        List<CustomerTotalDebtDto> customerTotalDebts;
        public TopluMusteriBorcRapor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pdf raporu versin
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Word._Application word = new Microsoft.Office.Interop.Word.Application();
            Document doc = word.Documents.Add();
            Microsoft.Office.Interop.Word.Range rng = doc.Range(0, 0);
            Table wdTable = doc.Tables.Add(rng, dataGridView1.Rows.Count, dataGridView1.Columns.Count);
            wdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;
            wdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            try
            {

                    //orijinal

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        wdTable.Cell(i + 1, j + 1).Range.InsertAfter(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        doc.SaveAs(saveFileDialog1.FileName);
                        Process.Start("winword.exe", saveFileDialog1.FileName);
                    }
                }
            }
            catch (Exception ex) { 



                MessageBox.Show(ex.Message);
            }
            finally
            {
                word.Quit();
                word = null;
                doc = null;
            }
             // word raporu versin
        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            ExcelPackage package = new ExcelPackage();
            package.Workbook.Worksheets.Add("Worksheet1");

            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

            var columns = dataGridView1.Columns;

            for (int i = 0; i < columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = columns[i].HeaderText;
            }

            int rowIndex = 2;
            var rows = dataGridView1.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Cells[0] != null)
                {
                    for (int j = 0; j < rows[i].Cells.Count; j++)
                    {
                        worksheet.Cells[rowIndex, j + 1].Value = rows[i].Cells[j].Value;
                    }
                    rowIndex++;
                }


            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyasi| *.xlsx";
            saveFileDialog.ShowDialog();

            Stream stream = saveFileDialog.OpenFile();
            package.SaveAs(stream);
            stream.Close();

            MessageBox.Show("Excel Dosyasina basariyla kaydedildi.");
            // excel raporu versin
        }

        private void LoadData()
        {
            var response = _debtCustomerService.GetListCustomerTotalDebt();
            if (response.Success)
            {
                customerTotalDebts = response.Data;
                dataGridView1.DataSource = customerTotalDebts.Select(x => new { x.FirstName, x.LastName, x.AmountOfDebt, x.AmountPaid, x.RemaingDebt }).ToList();
                //MessageBox.Show(customerTotalDebts.Count.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Veriler getirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TopluMusteriBorcRapor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}