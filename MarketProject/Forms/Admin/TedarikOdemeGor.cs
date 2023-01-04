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
    public partial class TedarikOdemeGor : Form
    {
        private readonly ISupplierPaymentService _supplierPaymentService = new SupplierPaymentManager();
        List<SupplierPaymentDto> supplierPaymentDtos;
        public TedarikOdemeGor()
        {
            InitializeComponent();
        }

        private void TedarikOdemeGor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var response = _supplierPaymentService.GetListSupplierPayment();
            if (response.Success)
            {
                dataGridView1.DataSource = response.Data;
                supplierPaymentDtos = response.Data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = supplierPaymentDtos.Where(x => x.SupplierPhoneNumber == textBox1.Text.ToString()).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
