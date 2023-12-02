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
    public partial class Form_Add_TxtBx : Form
    {
        private Label tochange;
        public Form_Add_TxtBx(Label change)
        {
            InitializeComponent();
            this.tochange = change;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tochange.Text += "\n" + newText.Text;
            this.Close();
        }
    }
}
