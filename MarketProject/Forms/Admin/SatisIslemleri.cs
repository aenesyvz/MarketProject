using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject.Forms.Admin
{
    public partial class SatisIslemleri : Form
    {
        private readonly ICustomerService _customerService = new CustomerManager();
        private readonly IProductService _productService = new ProductManager();
        private readonly ISaleService _saleService = new SaleManager();
        private readonly IDebtCustomerService _debtCustomerService = new DebtCustomerManager();
        private readonly ICreditSaleService _creditSaleService= new CreditSaleManager();
        List<Customer> customers;
        Customer customer;
        Product product;
        decimal totalPrice = 0;
        public SatisIslemleri()
        {
            InitializeComponent();
        }

        private void SatisIslemleri_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var response = _customerService.GetList();
            if (response.Success)
            {
                customers = response.Data;
                dataGridView1.DataSource = customers;
            }
            else
            {
                MessageBox.Show("Veriler Getirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());

            var response = _customerService.GetById(id);
            if (response.Success)
            {
                customer = response.Data;
                textBox1.Text = customer.PhoneNumber;
                MessageBox.Show("Müşteri seçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Müşteri bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var response = _productService.GetByBarcode(textBox2.Text);
            if (response.Success)
            {
                product = response.Data;
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {
                int amaount = Convert.ToInt32(textBox3.Text);
                if (product == null)
                {
                    MessageBox.Show("Ürün bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (product.Amount >= amaount)
                    {
                        string barcode = product.BarcodeNo;
                        //               0         1       2         3        4                   5                6
                        string temp = barcode + " => " + amaount + " X " + product.UnitOfPrice + " = " + amaount * product.UnitOfPrice;
                        totalPrice += product.UnitOfPrice * amaount;
                        listBox1.Items.Add(temp);
                        MessageBox.Show("Ürün Sepete Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Text = totalPrice.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yeterli miktarda ürün yok" + "Ürün miktarı" + product.Amount, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show("Ürün miktarını giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox3.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (var item in listBox1.Items)
            {
                string selectedItem = item.ToString();
                string[] prop = selectedItem.Split(' ');

                Product _product = _productService.GetByBarcode(prop[0]).Data;
                if (_product != null)
                {
                    _product.Amount -= Convert.ToInt32(prop[2]);
                    Sale sale = new Sale();

                    sale.AddedDate = DateTime.Now;
                    sale.ProductId = _product.Id;
                    sale.Amount = Convert.ToInt32(prop[2]);
                    sale.Price = Convert.ToDecimal(prop[6]);
                    _saleService.Add(sale);
                    //var res = _saleService.AddToMap(sale);
                    //int  j = res.Data.Id;
                    //MessageBox.Show(j.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _productService.Update(_product);
                }

            }
            listBox1.Items.Clear();
            totalPrice = 0;
            textBox4.Clear();
            MessageBox.Show("Satış İşlemi Gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (customer != null)
            {

                DebtCustomer debtCustomer = new DebtCustomer();
                debtCustomer.CustomerId = customer.Id;
                debtCustomer.AddedDate = DateTime.Now;
                debtCustomer.AmountOfDebt = totalPrice;
                debtCustomer.RemaingDebt = totalPrice;
                debtCustomer.AmountPaid = 0;


               int debtCustomerId =  _debtCustomerService.AddToMap(debtCustomer).Data.Id;

                foreach (var item in listBox1.Items)
                {
                    string selectedItem = item.ToString();
                    string[] prop = selectedItem.Split(' ');

                    Product _product = _productService.GetByBarcode(prop[0]).Data;
                    if (_product != null)
                    {
                        _product.Amount -= Convert.ToInt32(prop[2]);
                        Sale sale = new Sale();
                        CreditSale creditSale = new CreditSale();
                        sale.AddedDate = DateTime.Now;
                        sale.ProductId = _product.Id;
                        sale.Amount = Convert.ToInt32(prop[2]);
                        sale.Price = Convert.ToDecimal(prop[6]);
                        
                         var result = _saleService.AddToMap(sale);
                         creditSale.DebtCustomerId = debtCustomerId;
                         creditSale.CustomerId = customer.Id;
                         creditSale.SaleId = result.Data.Id;
                        _creditSaleService.Add(creditSale);
                        _productService.Update(_product);
                    }

                }


                listBox1.Items.Clear();
                totalPrice = 0;
                textBox4.Clear();
                MessageBox.Show("Satış İşlemi Gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen müşteri seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var response = _customerService.GetByPhoneNumber(textBox1.Text);
            if (response.Success)
            {
                dataGridView1.DataSource = response.Data;
            }
        }
    }
}