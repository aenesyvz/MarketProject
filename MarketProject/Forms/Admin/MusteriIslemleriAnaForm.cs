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
    public partial class MusteriIslemleriAnaForm : Form
    {
        public MusteriIslemleriAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriIslemleri musteriIslem = new MusteriIslemleri();
            musteriIslem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriBorc musteriBorc = new MusteriBorc();
            musteriBorc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriOdemeListesi musteriOdemeListesi = new MusteriOdemeListesi();
            musteriOdemeListesi.Show();
        }
    }
}
