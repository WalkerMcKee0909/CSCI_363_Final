using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form_Login : Form {
        private bool isStudent, isProvider, isSuper;
        public Form_Login() {
            InitializeComponent();
            isStudent = isProvider = isSuper = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            Regex student = new Regex("[A-Za-z0-9]+@student", RegexOptions.IgnoreCase);
            Regex provider = new Regex("[A-Za-z0-9]+@provider", RegexOptions.IgnoreCase);
            Regex super = new Regex("[A-Za-z0-9]+@super", RegexOptions.IgnoreCase);



            if(student.IsMatch(textBox1.Text)) {
                isStudent = true;
            } else if(provider.IsMatch(textBox1.Text)) {
                isProvider = true;
            } else if(super.IsMatch(textBox1.Text)) {
                isSuper = true;
            } else {
                textBox1.BackColor = Color.LightCoral;
                return;
            }

            Form_Home form = new Form_Home(isStudent, isProvider, isSuper);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
                button3.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
                button2.BringToFront();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if(textBox1.BackColor == Color.LightCoral) {
                textBox1.BackColor = SystemColors.Window;
            }

            if(!string.IsNullOrEmpty(textBox2.Text)) {
                button1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(textBox1.Text)) {
                button1.Enabled = true;
            }
        }
    }
}
