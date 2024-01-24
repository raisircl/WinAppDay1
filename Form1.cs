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
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToInt32(txtN1.Text) + Convert.ToInt32(txtN2.Text));
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToInt32(txtN1.Text) - Convert.ToInt32(txtN2.Text));
        }
    }
}
