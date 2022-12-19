using MarketProject.Business.Abstract;
using MarketProject.Business.Concrete;
using MarketProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject
{
    public partial class Form1 : Form
    {
        private readonly IAdminService _adminService = new AdminManager();
        List<Admin> admins;
        Admin admin;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin createdAdmin = new Admin()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Email = textBox3.Text,
                Password = textBox4.Text,
                UserName = textBox5.Text,
            };
            _adminService.Add(createdAdmin);
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin updatedAdmin = new Admin()
            {
                Id = admin.Id,
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Email = textBox3.Text,
                Password = textBox4.Text,
                UserName = textBox5.Text,
            };
            _adminService.Update(updatedAdmin);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _adminService.Delete(admin);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[select].Cells[0].Value.ToString());

            admin = _adminService.GetById(id).Data;
            textBox1.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
        }
        private void LoadData()
        {
            var res = _adminService.GetList();
            if (res.Success)
            {
                admins = res.Data;
                dataGridView1.DataSource = admins;
            }
            else
            {
                MessageBox.Show("BIKTIM");
            }
        }
    }
   
}
