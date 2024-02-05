using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDay1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(rbMale.Checked)
            {
               DialogResult result= MessageBox.Show("Hello Mr.", "Salutation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
               if(result == DialogResult.Yes)
                {
                    MessageBox.Show("Benifits");
                } 
               else
                {
                    MessageBox.Show("Bye Bye...");
                }
            }
            else if(rbFemale.Checked) 
            {
                MessageBox.Show("Hello Ms.", "Salutation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to clear the form", "Confirmarion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                foreach(Control ctrl in panel1.Controls)
                {
                    if(ctrl.GetType() == typeof(TextBox))
                    {
                        ctrl.Text = "";
                    }
                   
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to close the form", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel=true;  
            }
        }
    }
}
