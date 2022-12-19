using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MarketProject.Forms.Admin
{
    public partial class BorcIslemleri : Form
    {
        public BorcIslemleri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriBorc musteriBorc = new MusteriBorc();
            musteriBorc.Show();
        }
    }
}