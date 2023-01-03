using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Concrete;
using MarketProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private readonly ISaleService _saleService = new SaleManager();
        private readonly IAuthService _authService = new AuthManager();
        private readonly ICustomerPaymentService _customerPaymentService = new CustomerPaymentManager();
        List<CreditSaleDto> creditSaleDtos;
        CreditSaleDto creditSaleDto;
        DebtCustomer debtCustomer;
        Product product;

        int selectedSale;
        int _debCustomerId;
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
                    CustomerPayment customerPayment = new CustomerPayment()
                    {
                        CustomerId= debtCustomer.CustomerId,
                        DebtCustomerId = _debCustomerId,
                        Payment = Convert.ToDecimal(textBox5.Text.ToString()),
                        AddedPayment = DateTime.Now
                    };
                    _customerPaymentService.Add(customerPayment);
                    LoadData();
                    textBox5.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunSilmeOnay urunSilmeOnay = new UrunSilmeOnay();
            urunSilmeOnay.ShowDialog();
   
            if(urunSilmeOnay.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Dikkat", "Kendinizi onaylamadığınız için satış silinmeyecektir");
                return;
            }

            DebtCustomer updatedDebtCustomer = new DebtCustomer()
            {
                Id = _debCustomerId,
                AddedDate = debtCustomer.AddedDate,
                CustomerId = debtCustomer.CustomerId,
                AmountPaid = debtCustomer.AmountPaid >= Convert.ToDecimal(textBox8.Text.ToString()) ? debtCustomer.AmountPaid - Convert.ToDecimal(textBox8.Text.ToString()) : 0,
                AmountOfDebt = debtCustomer.AmountOfDebt >= Convert.ToDecimal(textBox8.Text.ToString()) ? debtCustomer.AmountOfDebt - Convert.ToDecimal(textBox8.Text.ToString()) : 0,
                RemaingDebt = debtCustomer.RemaingDebt >= Convert.ToDecimal(textBox8.Text.ToString()) ? debtCustomer.RemaingDebt - Convert.ToDecimal(textBox8.Text.ToString()) : 0
            };
            _debtCustomerService.Update(updatedDebtCustomer);

            Product updatedUpdated = new Product()
            {
                Id = product.Id,
                BarcodeNo = product.BarcodeNo,
                Amount = product.Amount + Convert.ToInt32(textBox9.Text),
                Code = product.Code,
                Name = product.Name,
                UnitOfPrice = product.UnitOfPrice,
                WayBillId = product.WayBillId
            };
            _productService.Update(updatedUpdated);
          
            var sale = _saleService.GetById(selectedSale);
            if (sale == null)
            {
                MessageBox.Show("Hata", "Satış bulunamadı");
                return;
            }

            _saleService.Delete(sale.Data);
            var creditSale = _creditSaleService.GetById(selectedSale);
            _creditSaleService.Delete(creditSale.Data);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());
            product = _productService.GetById(id).Data;
            selectedSale = Convert.ToInt32(dataGridView1.Rows[select].Cells[2].Value.ToString());
            textBox6.Text = dataGridView1.Rows[select].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.Rows[select].Cells[8].Value.ToString();
            textBox8.Text = dataGridView1.Rows[select].Cells[10].Value.ToString();
            textBox9.Text = dataGridView1.Rows[select].Cells[11].Value.ToString();
        }
    }
}
