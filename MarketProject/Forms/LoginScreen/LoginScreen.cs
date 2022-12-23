
using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Dtos;
using MarketProject.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MarketProject.Forms.LoginScreen
{
    public partial class LoginScreen : Form
    {
        private readonly IAuthService _authService = new AuthManager();
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcı adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı adı";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Şifre")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
                textBox4.PasswordChar = '*';
            }
        }

        char? none = null;
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Şifre";
                textBox4.ForeColor = Color.Silver;
                textBox4.PasswordChar = Convert.ToChar(none);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto()
            {
                UserName = textBox1.Text.ToString(),
                Password = textBox4.Text.ToString()
            };

            var response = _authService.Login(userForLoginDto);
            if (response.Success)
            {
                textBox1.Text = "";
                textBox4.Text = "";
                this.DialogResult= DialogResult.OK;
               this.Close();

               
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı adı veya şifre giriniz!", "DİKKAT",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}