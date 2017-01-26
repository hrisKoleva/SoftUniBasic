using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsCurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();

        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertCurrency();

        }

        private void ConvertCurrency()
        {
            double coefficient = 1.95583;
            double amountBGN = (double)numericUpDownAmount.Value;
            double amountEUR = amountBGN / coefficient;

            this.labelResult.Text = string.Format("{0} BGN = {1} EUR", amountBGN, Math.Round(amountEUR, 2));
        }
    }
}
