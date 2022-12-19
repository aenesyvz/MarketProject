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
    public partial class EnCokSatanUrunler : Form
    {
        private readonly ISaleService _saleService = new SaleManager();
        List<SaleProductDto> saleProductDtos;
        public EnCokSatanUrunler()
        {
            InitializeComponent();
        }

        private void EnCokSatanUrunler_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var res = _saleService.GetListSaleProductDesc();
            if (res.Success)
            {
                saleProductDtos = res.Data;
                dataGridView1.DataSource = saleProductDtos;
            }
        }
    }
}