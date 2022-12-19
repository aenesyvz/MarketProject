using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketProject.Forms.Admin
{
    public partial class UrunEkleme : Form
    {
        private readonly ISupplierService _supplierService = new SupplierManager();
        private readonly IProductService _productService = new ProductManager();
        private readonly IDebtSupplierService _debtSupplierService = new DebtSupplierManager();
        private readonly IWaybillService _waybillService = new WaybillManager();

        List<Supplier> suppliers;
        Supplier supplier;
        float _kar = 1;
        public UrunEkleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (supplier == null)
            {
                MessageBox.Show("Lütfen önce tedarikçi seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Filter = "Text Files|*.txt";
                ofd.ShowDialog();

                string path = ofd.FileName;
                string[] lines = File.ReadAllLines(path, Encoding.GetEncoding("windows-1254"));
                MessageBox.Show("Seçilen dosya: " + ofd.FileName, "Dosya başarıyla seçildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ofd.Reset();
                foreach (var line in lines)
                {
                    var data = line.Split(' ');
                    var waybill = new Waybill();
                    // IrsaliyeId  Code ProductName fiyat miktar
                    waybill.WaybillId = Convert.ToInt32(data[0]);
                    waybill.ProductCode = data[1];
                    waybill.ProductName = data[2];
                    waybill.Price = (float)Convert.ToDouble(data[3]);
                    waybill.Amount = Convert.ToInt32(data[4]);
                    waybill.SupplierId = supplier.Id;
                    waybill.AddedDate = DateTime.Now;
                    
                    _waybillService.Add(waybill);


                    var product = _productService.GetByCode(waybill.ProductCode).Data;
                    if (product == null)
                    {
                        float change = waybill.Price;
                        var createdProduct = new Product()
                        {
                            Name =waybill.ProductName,
                            Code = waybill.ProductCode,
                            BarcodeNo = "855" + waybill.ProductCode + "555",
                            Amount = waybill.Amount,
                            UnitOfPrice =Convert.ToDecimal(change * _kar),
                            WayBillId = waybill.WaybillId,
                        };
                        _productService.Add(createdProduct);
                    }
                    else
                    {
                        product.Amount += waybill.Amount;
                        product.UnitOfPrice = Convert.ToDecimal(waybill.Price * _kar);
                        _productService.Update(product);
                    }

                    var debtSupplier = _debtSupplierService.GetBySupplierId(waybill.SupplierId).Data;
                    if (debtSupplier == null)
                    {
                        DebtSupplier createdDebtSupplier = new DebtSupplier()
                        {
                            SupplierId = waybill.SupplierId,
                            AddedDate = DateTime.Now,
                            AmountPaid = 0,
                            AmountOfDebt = (float)Convert.ToDouble(waybill.Amount * waybill.Price),
                            RemaingDebt = (float)Convert.ToDouble(waybill.Amount * waybill.Price),
                        };
                        _debtSupplierService.Add(createdDebtSupplier);
                    }
                    else
                    {
                        debtSupplier.AmountOfDebt += (float)Convert.ToDouble(waybill.Amount * waybill.Price);
                        debtSupplier.RemaingDebt += (float)Convert.ToDouble(waybill.Amount * waybill.Price);
                        _debtSupplierService.Update(debtSupplier);
                    }
                }
            }

        }

        //private void UrunStoklari_Load(object sender, EventArgs e)
        //{
        //    LoadData();
        //}
        private void LoadData()
        {
            var response = _supplierService.GetList();
            if (response.Success)
            {

                suppliers = response.Data;
                dataGridView1.DataSource = suppliers;
            }
            else
            {
                MessageBox.Show("Tedarikçiler getirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int select = dataGridView1.SelectedCells[0].RowIndex;
        //    int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());

        //    supplier = _supplierService.GetById(id).Data;
        //    textBox2.Text = dataGridView1.Rows[select].Cells[1].Value.ToString() + dataGridView1.Rows[select].Cells[2].Value.ToString();
        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void UrunEkleme_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());

            supplier = _supplierService.GetById(id).Data;
            textBox2.Text = dataGridView1.Rows[select].Cells[1].Value.ToString() + dataGridView1.Rows[select].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var response = _supplierService.GetByPhoneNumberLike(textBox3.Text);
            if (response.Success)
            {
                dataGridView1.DataSource = response.Data;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            LoadData();
        }
    }
}