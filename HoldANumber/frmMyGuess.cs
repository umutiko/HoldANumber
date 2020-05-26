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
    public partial class frmMyGuess : Form
    {
        private int guess;
        Random randomNumber = new Random();
        public frmMyGuess(int min, int max)
        {
            InitializeComponent();
            guess = randomNumber.Next(min, max);
            lblNotification.Text =
                $"My mind for you {min} with {max} ı kept a number in between. Will you find ?";
        }

        private void frmMyGuess_Load(object sender, EventArgs e)
        {

        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtGuess.Text) == guess)
                {
                    MessageBox.Show("Congratulations!... You Win");
                    this.Close();
                }
                else
                {
                    lblNotification.Text = "Wrong Answer! Try Again";
                    txtGuess.Text = null;
                    txtGuess.Focus();
                }
            }
        }
    }
}