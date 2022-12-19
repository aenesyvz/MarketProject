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
    public partial class TedarikciAnaEkran : Form
    {
        public TedarikciAnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TedarikciIslemleri tedarikciIslem = new TedarikciIslemleri();
            tedarikciIslem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TedarikciBorc tedarikciBorc = new TedarikciBorc();
            tedarikciBorc.Show();
        }
    }
}