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
    public partial class MusteriBorcDetay : Form
    {
        private readonly IDebtCustomerService _debtCustomerService = new DebtCustomerManager();
        private readonly ICustomerService _customerService = new CustomerManager();  
        private int _customerId;
        Customer customer;
        List<DebtCustomer> debtCustomers;
        DebtCustomer debtCustomer;
        public MusteriBorcDetay(int customerId)
        {
            InitializeComponent();
            _customerId= customerId;
        }

        private void MusteriBorcDetay_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var customerResponse = _customerService.GetById(_customerId);
            var response = _debtCustomerService.GetListByCustomerId( _customerId );
            if (response.Success && customerResponse.Success)
            {
                customer = customerResponse.Data;
                debtCustomers = response.Data;
                dataGridView1.DataSource = response.Data;

                textBox2.Text = customer.FirstName;
                textBox3.Text = customer.LastName;
                textBox4.Text = customer.PhoneNumber;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriBorcOdeme musteriBorcOdeme = new MusteriBorcOdeme(debtCustomer.Id);
            musteriBorcOdeme.ShowDialog();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());
            debtCustomer = _debtCustomerService.GetById(id).Data;
            textBox1.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
        }
    }
}