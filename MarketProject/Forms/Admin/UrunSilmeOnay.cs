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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketProject.Forms.Admin
{
    public partial class UrunSilmeOnay : Form
    {
        private readonly IAuthService _authService = new AuthManager();
        public bool userToCheck = false;
        public UrunSilmeOnay()
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

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto()
            {
                UserName = textBox1.Text.ToString(),
                Password = textBox2.Text.ToString()
            };
            var response = _authService.Login(userForLoginDto);
            if (response.Success)
            {
                userToCheck = true;
            }
            userToCheck = false;
        }
    }
}
