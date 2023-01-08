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
    public partial class TedarikciIslemleri : Form
    {
        private readonly ISupplierService _supplierService = new SupplierManager();
        List<Supplier> suppliers;
        Supplier supplier;

        public TedarikciIslemleri()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());

            supplier = _supplierService.GetById(id).Data;
            textBox1.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier addedSupplier = new Supplier()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                PhoneNumber = textBox3.Text,
                AddedTime = DateTime.Now,
            };
            var response = _supplierService.Add(addedSupplier);
            if (response.Success)
            {
                LoadData();
                MessageBox.Show("Tedarikçi Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier updatedSupplier = new Supplier()
            {
                Id = supplier.Id,
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                PhoneNumber = textBox3.Text,
                AddedTime = supplier.AddedTime
            };
            _supplierService.Update(updatedSupplier);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _supplierService.Delete(supplier);
            LoadData();
        }
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
                MessageBox.Show("Veriler getirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TedarikciIslemleri_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}