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
    public partial class Form_Edit_TxtBx : Form
    {
        private string currentText;
        private Label tochange;
        public Form_Edit_TxtBx(string curntText, Label change)
        {
            InitializeComponent();
            this.currentText = curntText;
            newText.Text = currentText;
            this.tochange = change;
        }

        private void newText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tochange.Text = newText.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
