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
    public partial class SatisTrendi : Form
    {
        private readonly ISaleService _saleService = new SaleManager();
        List<SaleTrendByDateDto> saleTrendByDateDtos;
        public SatisTrendi()
        {
            InitializeComponent();
        }

        private void SatisTrendi_Load(object sender, EventArgs e)
        {
            LoadData();
          
            // CHART baslangic komut
            //chart1.Series["SatisTrendi"].Points.AddXY("tarih1", 15);  // normalde 15 yerine ilgili tarihin satış verisi
            //chart1.Series["SatisTrendi"].Points.AddXY("tarih2", 5);
            //chart1.Series["SatisTrendi"].Points.AddXY("tarih3", 15);
            //chart1.Series["SatisTrendi"].Points.AddXY("tarih4", 25);
            //chart1.Series["SatisTrendi"].Points.AddXY("tarih5", 55);
            //chart1.Series["SatisTrendi"].Points.AddXY("tarih6", 95);
            //chart1.Series["SatisTrendi"].Points.AddXY("tarih7", 45);

        }

        private void LoadData()
        {
            var response = _saleService.GetListSaleTrendByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            if (response.Success)
            {
                dataGridView1.DataSource = response.Data;
                chart1.DataSource = response.Data;
                chart1.Series["SatısTrendi"].XValueMember = "SaleDate";
                chart1.Series["SatısTrendi"].YValueMembers = "Sum";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var response = _saleService.GetListSaleTrendByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            if (response.Success)
            {
                dataGridView1.DataSource = response.Data;
                chart1.Series["SatısTrendi"].Points.Clear();
                chart1.DataSource = dataGridView1.DataSource;
                chart1.Series["SatısTrendi"].XValueMember = "SaleDate";
                chart1.Series["SatısTrendi"].YValueMembers = "Sum";
            }
        }
    }
}