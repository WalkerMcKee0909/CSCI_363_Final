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



            if(student.IsMatch(usernameField.Text)) {
                isStudent = true;
            } else if(provider.IsMatch(usernameField.Text)) {
                isProvider = true;
            } else if(super.IsMatch(usernameField.Text)) {
                isSuper = true;
            } else {
                usernameField.BackColor = Color.LightCoral;
                return;
            }

            Form_Home form = new Form_Home(isStudent, isProvider, isSuper);
            form.Show();
            this.Hide();
        }

        private void showButton_Click(object sender, EventArgs e) {
            if(passwordField.PasswordChar == '*') {
                passwordField.PasswordChar = '\0';
                hideButton.BringToFront();
            }
        }

        private void hideButton_Click(object sender, EventArgs e) {
            if(passwordField.PasswordChar == '\0') {
                passwordField.PasswordChar = '*';
                showButton.BringToFront();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if(usernameField.BackColor == Color.LightCoral) {
                usernameField.BackColor = SystemColors.Window;
            }

            if(!string.IsNullOrEmpty(passwordField.Text)) {
                loginButton.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(usernameField.Text)) {
                loginButton.Enabled = true;
            }
        }
    }
}
