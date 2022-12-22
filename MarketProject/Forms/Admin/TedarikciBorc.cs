using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketProject.Forms.Admin
{
    public partial class TedarikciBorc : Form
    {
        private readonly IDebtSupplierService _debtSupplierService = new DebtSupplierManager();
        List<SupplierTotalDebtDto> supplierTotalDebtDtos;
        SupplierTotalDebtDto supplierTotalDebtDto;
        int supplierId;
        public TedarikciBorc()
        {
            InitializeComponent();
        }

        private void TedarikciBorc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var response = _debtSupplierService.GetSupplierTotalDebt();
            if (response.Success)
            {
                supplierTotalDebtDtos = response.Data;
                dataGridView1.DataSource = supplierTotalDebtDtos;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());
            supplierId = id;

            supplierTotalDebtDto = _debtSupplierService.GetSupplierTotalDebtBySupplierId(id).Data;
            textBox1.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[select].Cells[6].Value.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TedarikciBorcDetay tedarikciBorcDetay = new TedarikciBorcDetay(supplierId);
            tedarikciBorcDetay.Show();
        }
    }
}