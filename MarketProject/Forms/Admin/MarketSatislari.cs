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
    public partial class MarketSatislari : Form
    {
        public MarketSatislari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SatisIslemleri satisIslemleri = new SatisIslemleri();
            satisIslemleri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatisTrendi satisTrendi = new SatisTrendi();
            satisTrendi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnCokSatanUrunler enCok = new EnCokSatanUrunler();
            enCok.Show();
        }
    }
}