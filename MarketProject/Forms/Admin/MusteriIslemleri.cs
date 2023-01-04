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
    public partial class MusteriIslemleri : Form
    {
        private readonly ICustomerService _customerService = new CustomerManager();
        List<Customer> customers;
        Customer customer;

        public MusteriIslemleri()
        {
            InitializeComponent();
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                PhoneNumber = textBox3.Text,
                AddedDate = DateTime.Now,
            };
            var response = _customerService.Add(customer);
            if (response.Success)
            {
                LoadData();
                MessageBox.Show("Müşteri Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu telefon numarasına sahip bir müşteri zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show("Veriler getirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Customer updatedCustomer = new Customer()
            {
                Id = customer.Id,
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                PhoneNumber = textBox3.Text,
                AddedDate = customer.AddedDate
            };
            var response = _customerService.Update(updatedCustomer);
            if (response.Success)
            {
                LoadData();
                MessageBox.Show("Müşteri Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu telefon numarasına sahip bir müşteri zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _customerService.Delete(customer);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());

            customer = _customerService.GetById(id).Data;
            textBox1.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Customer updatedCustomer = new Customer()
        //    {
        //        Id = customer.Id,
        //        FirstName = textBox1.Text,
        //        LastName = textBox2.Text,
        //        PhoneNumber = textBox3.Text,
        //        AddedDate = customer.AddedDate
        //    };
        //    _customerService.Update(updatedCustomer);
        //    LoadData();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    _customerService.Delete(customer);
        //    LoadData();
        //}

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{



        //}
    }
}