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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject.Forms.Admin
{
    public partial class TedarikciBorcDetay : Form
    {
        private readonly IDebtSupplierService _debtSupplierService = new DebtSupplierManager();
        private readonly ISupplierService _supplierService = new SupplierManager();
        private readonly ISupplierPaymentService _supplierPaymentService = new SupplierPaymentManager();
        Supplier supplier;
        List<DebtSupplier> debtSuppliers;
        DebtSupplier debtSupplier;

        private int _supplierId;

        public TedarikciBorcDetay(int supplierId)
        {
            InitializeComponent();
            _supplierId = supplierId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null){
                if(Convert.ToInt32(textBox1.Text) > debtSupplier.RemaingDebt)
                {
                    MessageBox.Show("Ödeyeceğiniz tutar kalan borçtan büyük olduğundan işlem gerçekleştirilmeyek!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DebtSupplier updatedDebtSupplier = new DebtSupplier()
                {
                    Id = debtSupplier.Id,
                    SupplierId = debtSupplier.SupplierId,
                    AddedDate = debtSupplier.AddedDate,
                    AmountOfDebt = debtSupplier.AmountOfDebt,
                    AmountPaid = debtSupplier.AmountPaid + Convert.ToInt32(textBox1.Text),
                    RemaingDebt = debtSupplier.RemaingDebt - Convert.ToInt32(textBox1.Text),
                };
                _debtSupplierService.Update(updatedDebtSupplier);
                SupplierPayment supplierPayment = new SupplierPayment()
                {
                    SupplierId = debtSupplier.SupplierId,
                    DebtSupplierId = debtSupplier.Id,
                    Payment = Convert.ToDecimal(textBox1.Text),
                    AddedPayment = DateTime.Now
                };
                _supplierPaymentService.Add(supplierPayment);
                LoadData();
                textBox5.Text ="";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen ödenecek olan tutara sayı giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TedarikciBorcDetay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());


            debtSupplier = _debtSupplierService.GetById(id).Data;
            textBox5.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
         

        }
        private void LoadData()
        {
            var responseSupplier = _supplierService.GetById(_supplierId);
            var responseDebtSupplier = _debtSupplierService.GetListBySupplierId(_supplierId);
            if (responseSupplier.Success && responseDebtSupplier.Success)
            {
                supplier = responseSupplier.Data;
                textBox2.Text = supplier.FirstName;
                textBox3.Text = supplier.LastName;
                textBox4.Text = supplier.PhoneNumber;

                debtSuppliers = responseDebtSupplier.Data;
                dataGridView1.DataSource = debtSuppliers;
            }
            else
            {
                MessageBox.Show("Tedarikçi bilgileri getirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
