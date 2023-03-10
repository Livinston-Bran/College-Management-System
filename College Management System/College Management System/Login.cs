using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

    
        private void Login_Load(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            count = count + 1;

            if (count > 3)
            {
                MessageBox.Show("Sorry Invalid User Attempt !!");
                this.Close();
            }

            if (username.Equals("admin") && password.Equals("12345"))
            {
                MainForm Mform = new MainForm();
                Mform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect !");
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
