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
        private bool isStudent, isProvider, isSuper, editEnabled, addEnabled;
        
        private void Form_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notes_Click(object sender, EventArgs e)
        {          
            if (editEnabled)
            {
                string currentText = Notes.Text;
                Form_Edit_TxtBx editForm = new Form_Edit_TxtBx(currentText, Notes);
                editForm.Show();
            }
            else if (addEnabled)
            {
                Form_Add_TxtBx addForm = new Form_Add_TxtBx(Notes);
                addForm.Show();
            }
        }

        private void IllnessHistory_Click(object sender, EventArgs e)
        {
            if (editEnabled)
            {
                string currentText = IllnessHistory.Text;
                Form_Edit_TxtBx editForm = new Form_Edit_TxtBx(currentText, IllnessHistory);
                editForm.Show();
            }
            else if (addEnabled)
            {
                Form_Add_TxtBx addForm = new Form_Add_TxtBx(IllnessHistory);
                addForm.Show();
            }
        }

        private void PrevMedHist_Click(object sender, EventArgs e)
        {
            if (editEnabled)
            {
                string currentText = PrevMedHist.Text;
                Form_Edit_TxtBx editForm = new Form_Edit_TxtBx(currentText, PrevMedHist);
                editForm.Show();
            }
            else if (addEnabled)
            {
                Form_Add_TxtBx addForm = new Form_Add_TxtBx(PrevMedHist);
                addForm.Show();
            }
        }

        private void SurgicalHist_Click(object sender, EventArgs e)
        {
            if (editEnabled)
            {
                string currentText = SurgicalHist.Text;
                Form_Edit_TxtBx editForm = new Form_Edit_TxtBx(currentText, SurgicalHist);
                editForm.Show();
            }
            else if (addEnabled)
            {
                Form_Add_TxtBx addForm = new Form_Add_TxtBx(SurgicalHist);
                addForm.Show();
            }
        }

        private void FamHistory_Click(object sender, EventArgs e)
        {
            if (editEnabled)
            {
                string currentText = FamHistory.Text;
                Form_Edit_TxtBx editForm = new Form_Edit_TxtBx(currentText, FamHistory);
                editForm.Show();
            }
            else if (addEnabled)
            {
                Form_Add_TxtBx addForm = new Form_Add_TxtBx(FamHistory);
                addForm.Show();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Color enabled = Color.Green;
            Color disabled = Color.Black;
            Label[] editableLabels = { Notes, FamHistory, SurgicalHist, PrevMedHist, IllnessHistory };
            if (addEnabled)
            {
                addEnabled = false;
                EditButton.Enabled = true;
                for (int i = 0; i < editableLabels.Length; i++)
                {
                    editableLabels[i].ForeColor = disabled;
                }
            }
            else
            {
                addEnabled = true;
                EditButton.Enabled = false;
                for (int i = 0; i < editableLabels.Length; i++)
                {
                    editableLabels[i].ForeColor = enabled;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox2.Text)) {
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!button1.Enabled)
            {
                button1.Enabled = true;
            }

            if(string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(!button1.Enabled)
            {
                button1.Enabled = true;
            }

            if(string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Login form = new Form_Login();
            form.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color enabled = Color.Red;
            Color disabled = Color.Black;
            Label[] editableLabels = { Notes, FamHistory, SurgicalHist, PrevMedHist, IllnessHistory };
            if (editEnabled)
            {
                editEnabled = false;
                Add.Enabled = true;
                for (int i = 0; i < editableLabels.Length; i++)
                {
                    editableLabels[i].ForeColor = disabled;
                }
            }
            else
            {
                Add.Enabled = false;
                editEnabled = true;
                for (int i = 0; i < editableLabels.Length; i++)
                {
                    editableLabels[i].ForeColor = enabled;
                }
            }

        }

        public Form_Home(bool isStudent, bool isProvider, bool isSuper) {
            InitializeComponent();
            this.isStudent = isStudent;
            this.isProvider = isProvider;
            this.isSuper = isSuper;
            this.editEnabled = false;
            this.addEnabled = false;

            if (this.isStudent)
            {
                EditButton.Enabled = false;
                Add.Enabled = false;
            }
            else if (this.isProvider)
            {
                EditButton.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
