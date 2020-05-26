using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoldANumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMyGuess_Click(object sender, EventArgs e)
        {
            frmMyGuess frm = new frmMyGuess(Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtMax.Text));
            frm.ShowDialog();
        }

        private void btnPcGuess_Click(object sender, EventArgs e)
        {
            frmPcGuess frmPc = new frmPcGuess(Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtMax.Text));
            frmPc.ShowDialog();
        }
    }
}
