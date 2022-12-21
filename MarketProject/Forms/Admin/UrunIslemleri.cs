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
    public partial class UrunIslemleri : Form
    {
        public UrunIslemleri()
        {
            InitializeComponent();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            UrunEkleme urunEkleme = new UrunEkleme();
            urunEkleme.Show();
        }

        private void btnStokGor_Click(object sender, EventArgs e)
        {
            UrunStokGor urunStokGor = new UrunStokGor();
            urunStokGor.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokTakip stokTakip = new StokTakip();
            stokTakip.Show();
        }
    }
}