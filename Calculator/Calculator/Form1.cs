using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmTaschenrechner : Form
    {
        public frmTaschenrechner()
        {
            InitializeComponent();
        }

        Rechenoperationen rechnen = new Rechenoperationen();

        private void btnAddition_Click(object sender, EventArgs e)
        {

            lblErgebnis.Text = Convert.ToString(rechnen.Addieren(Convert.ToDouble(txtOperand1.Text), Convert.ToDouble(txtOperand2.Text)));
            lblOperator.Text = "+";

            /*double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 + zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "+"; */
        }
        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            lblErgebnis.Text = Convert.ToString(rechnen.Subtrahieren(Convert.ToDouble(txtOperand1.Text), Convert.ToDouble(txtOperand2.Text)));
            lblOperator.Text = "-";
        }
        private void btnMittelwert_Click(object sender, EventArgs e)
        {
            lblErgebnis.Text = Convert.ToString(rechnen.Potenz(Convert.ToDouble(txtOperand1.Text), Convert.ToDouble(txtOperand2.Text)));
            lblOperator.Text = "~";
        }
        private void btnPotenz_Click(object sender, EventArgs e)
        {
            lblErgebnis.Text = Convert.ToString(rechnen.Potenz(Convert.ToDouble(txtOperand1.Text), Convert.ToDouble(txtOperand2.Text)));
            lblOperator.Text = "^^";
        }
        private void btnMaximum_Click(object sender, EventArgs e)
        {
            lblErgebnis.Text = Convert.ToString(rechnen.Maximum(Convert.ToDouble(txtOperand1.Text), Convert.ToDouble(txtOperand2.Text)));
            lblOperator.Text = "";
        }
    }
}
