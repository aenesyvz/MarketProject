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
    public partial class UrunKarZararRapor : Form
    {
        private readonly IProductService _productService = new ProductManager();
        List<ProductProfitAndDamageDto> productProfitAndDamageList;
        public UrunKarZararRapor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // word raporu hazırlasın
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // excel raporu hazırlasın
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // pdf raporu hazırlasın
        }

        private void UrunKarZararRapor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var response = _productService.GetListProductProfitAndDamage();
            if (response.Success)
            {
                productProfitAndDamageList = response.Data;
                dataGridView1.DataSource = response.Data;
                chart1.DataSource = response.Data;
                chart1.Series["Series1"].XValueMember = "Barcode";
                chart1.Series["Series1"].YValueMembers = "Result";
            }
            else
            {
                MessageBox.Show("Veriler getirilemedi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}