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

namespace MarketProject.Forms.Admin
{
    public partial class MusteriOdemeListesi : Form
    {
        private readonly ICustomerPaymentService _customerPaymentService = new CustomerPaymentManager();
        List<CustomerPaymentDto> customerPaymentDtos;
        public MusteriOdemeListesi()
        {
            InitializeComponent();
        }

        private void MusteriOdemeListesi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var response = _customerPaymentService.GetListCustomerPayment();
            if (response.Success)
            {
                dataGridView1.DataSource = response.Data;
                customerPaymentDtos = response.Data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerPaymentDtos.Where(x => x.CustomerPhoneNumber == textBox1.Text.ToString()).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
