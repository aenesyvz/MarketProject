using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Concrete;
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
    public partial class StokTakip : Form
    {
        private readonly IProductService _productService = new ProductManager();
        List<Product> products;
        Product product;
        public StokTakip()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void StokTakip_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var response = _productService.GetListLowStockProduct();
            if (response.Success)
            {
                products = response.Data;
                dataGridView1.DataSource = products;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());

            product = _productService.GetById(id).Data;
            textBox1.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();
        }
    }
}
