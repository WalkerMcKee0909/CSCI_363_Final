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
    public partial class Form_Home : Form
    {
        private bool isStudent, isProvider, isSuper;

        private void Form_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public Form_Home(bool isStudent, bool isProvider, bool isSuper) {
            InitializeComponent();
            this.isStudent = isStudent;
            this.isProvider = isProvider;
            this.isSuper = isSuper;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
