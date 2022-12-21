using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject.Forms.Admin
{
    public partial class MusteriBorcOdeme : Form
    {
        private readonly IProductService _productService = new ProductManager();
        private readonly ICreditSaleService _creditSaleService = new CreditSaleManager();
        private readonly IDebtCustomerService _debtCustomerService = new DebtCustomerManager();
        List<CreditSaleDto> creditSaleDtos;
        CreditSaleDto creditSaleDto;
        DebtCustomer debtCustomer;
        Product product;

        private int _debCustomerId;
        public MusteriBorcOdeme(int debtCustomerId)
        {
            InitializeComponent();
            _debCustomerId = debtCustomerId;
        }

        private void MusteriBorcOdeme_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var response = _creditSaleService.GetListByDebtCustomerId(_debCustomerId);
            if (response.Success)
            {
                creditSaleDtos = response.Data;
                dataGridView1.DataSource = response.Data;
                debtCustomer = _debtCustomerService.GetById(_debCustomerId).Data;
                textBox1.Text = debtCustomer.AddedDate.ToString();
                textBox2.Text = debtCustomer.AmountOfDebt.ToString();
                textBox3.Text = debtCustomer.AmountPaid.ToString();
                textBox4.Text = debtCustomer.RemaingDebt.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text != null && textBox5.Text.ToString() != "")
            {
                if(Convert.ToInt32(textBox5.Text.ToString()) > debtCustomer.RemaingDebt){
                    MessageBox.Show("Girdiğiniz tutar kalan borçtan büyüktür", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DebtCustomer updatedDebtCustomer = new DebtCustomer()
                    {
                        Id = _debCustomerId,
                        AddedDate = debtCustomer.AddedDate,
                        CustomerId = debtCustomer.CustomerId,
                        AmountOfDebt = debtCustomer.AmountOfDebt,
                        AmountPaid = debtCustomer.AmountPaid + Convert.ToInt32(textBox5.Text.ToString()),
                        RemaingDebt = debtCustomer.RemaingDebt - Convert.ToInt32(textBox5.Text.ToString())
                    };
                    _debtCustomerService.Update(updatedDebtCustomer);
                    LoadData();
                    textBox5.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş başarılı");
            DebtCustomer updatedDebtCustomer = new DebtCustomer()
            {
                Id = _debCustomerId,
                AddedDate = debtCustomer.AddedDate,
                CustomerId = debtCustomer.CustomerId,
                AmountPaid=0,
                AmountOfDebt = debtCustomer.AmountOfDebt - Convert.ToDecimal(textBox8.Text.ToString()),
                RemaingDebt = debtCustomer.RemaingDebt - Convert.ToDecimal(textBox8.Text.ToString())
            };
            _debtCustomerService.Update(updatedDebtCustomer);
            Product updatedUpdated = new Product()
            {
                Id = product.Id,
                BarcodeNo = product.BarcodeNo,
                Amount = product.Amount + Convert.ToInt32(textBox7.Text),
            };
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());
            product = _productService.GetById(id).Data;

            textBox6.Text = dataGridView1.Rows[select].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.Rows[select].Cells[8].Value.ToString();
            textBox8.Text = dataGridView1.Rows[select].Cells[10].Value.ToString();
        }
    }
}
