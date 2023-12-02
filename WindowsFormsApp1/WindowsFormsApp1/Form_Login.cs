using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String errorMessage = "Username or Password is invalid";
            if (textBox1.Text == "Student")
            {
                if (textBox2.Text == "1234")
                {
                    this.Hide();
                    Form_Home home = new Form_Home();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    Login_Error_Message.Text = errorMessage;
                }

            }
            else if (textBox1.Text == "Faculty")
            {
                if (textBox2.Text == "1234")
                {
                    this.Hide();
                    Form_Home home = new Form_Home();
                    home.ShowDialog();
                
                    this.Close();
                }
                else
                {
                    Login_Error_Message.Text = errorMessage;
                }

            }
            else if (textBox1.Text == "Admin")
            {
                if (textBox2.Text == "1234")
                {
                    this.Hide();
                    Form_Home home = new Form_Home();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    Login_Error_Message.Text = errorMessage;
                }
            }
            else
            {
                Login_Error_Message.Text = errorMessage;
            }
        }
    }
}
