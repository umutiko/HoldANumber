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
    public partial class frmPcGuess : Form
    {
        Random randomNumber = new Random();
        private int guess;
        private string[] messages = { "is it possible ?", "you kept it for sure", "maybe" };

        public frmPcGuess(int min, int max)
        {
            InitializeComponent();
            for (int i = min; i <= max; i++)
            {
                listBox1.Items.Add(i);
            }
            Guess();
        }

        private void Guess()
        {
            if (listBox1.Items.Count == 0)
            {
                lblNotification.Text = "LİE !!!";
                return;
            }
            guess = randomNumber.Next(0, listBox1.Items.Count - 1);
            lblNotification.Text = $"{listBox1.Items[guess]} {messages[randomNumber.Next(0, 2)]}";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Win ");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[guess]);
            Guess();
        }
    }
}
