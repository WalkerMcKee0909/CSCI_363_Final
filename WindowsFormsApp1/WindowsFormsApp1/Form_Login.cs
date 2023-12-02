using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form_Login : Form {
        private bool isAdmin;
        public Form_Login() {
            InitializeComponent();
            isAdmin = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            if(textBox1.Text.ToUpper() == "ADMIN" || textBox1.Text.ToUpper() == "SUPER") {
                isAdmin = true;
            }

            Form_Home form = new Form_Home(isAdmin);
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
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
