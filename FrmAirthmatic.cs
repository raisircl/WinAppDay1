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
    public partial class FrmAirthmatic : Form
    {
        public FrmAirthmatic()
        {
            InitializeComponent();
        }

        private void btnOp_Click(object sender, EventArgs e)
        {

            // sender keep the reference of current object - which one clicked
            // sender is a reference of object class that is parent class of each class in .net 
            // we knows from c++ ref of parent can point to child class 
            Button btn=(Button)sender;
            if (btn.Text == "+")
            {
                lblResult.Text = Convert.ToString(Convert.ToInt32(txtN1.Text) + Convert.ToInt32(txtN2.Text));
            }
            else if (btn.Text == "-")
            {
                lblResult.Text = Convert.ToString(Convert.ToInt32(txtN1.Text) - Convert.ToInt32(txtN2.Text));
            }

        }
    }
}
