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
        public SatisTrendi()
        {
            InitializeComponent();
        }

        private void SatisTrendi_Load(object sender, EventArgs e)
        {
            // CHART baslangic komut
            chart1.Series["SatisTrendi"].Points.AddXY("tarih1", 15);  // normalde 15 yerine ilgili tarihin satış verisi
            chart1.Series["SatisTrendi"].Points.AddXY("tarih2", 5);
            chart1.Series["SatisTrendi"].Points.AddXY("tarih3", 15);
            chart1.Series["SatisTrendi"].Points.AddXY("tarih4", 25);
            chart1.Series["SatisTrendi"].Points.AddXY("tarih5", 55);
            chart1.Series["SatisTrendi"].Points.AddXY("tarih6", 95);
            chart1.Series["SatisTrendi"].Points.AddXY("tarih7", 45);

        }
    }
}