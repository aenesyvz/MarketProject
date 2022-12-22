using MarketProject.Entities.Concrete;
using MarketProject.Forms.LoginScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject.Forms.Admin
{
    public partial class MainForm : Form
    {
        //constructor
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm;
        private Button currentButton;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelBeyaz.Controls.Add(childForm);
            this.panelBeyaz.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelBaslik.Text = childForm.Text;
        }

        private void btnMarketSatis_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new MarketSatislari(), sender);
        }

        private void btnUrunStok_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UrunIslemleri(), sender);
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MusteriIslemleriAnaForm(), sender);
        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TedarikciAnaEkran(), sender);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }
        private void Reset()
        {
            labelBaslik.Text = "ANA SAYFA";
            currentButton = null;
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RaporAlim(), sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}