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

        private void btnAddition_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 + zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "+";
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = zahl1 - zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "-";
        }

        private void btnMittelwert_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = (zahl1 + zahl2) /2;
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "~";
        }

        private void btnPotenz_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = Math.Pow(zahl1, zahl2);
            lblErgebnis.Text = Convert.ToString(ergebnis);
            lblOperator.Text = "^^";
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtOperand1.Text);
            double zahl2 = Convert.ToDouble(txtOperand2.Text);
            double ergebnis = 0;
            
            if (zahl1 < zahl2)
            {
                ergebnis = zahl2;
                lblOperator.Text = "<";
            }
            else if(zahl1> zahl2) {
               
                    ergebnis = zahl1;
                    lblOperator.Text = ">";
                }
            else
            {
                ergebnis = zahl1;
                lblOperator.Text = "=";
            }
            lblErgebnis.Text = Convert.ToString(ergebnis);
        }
    }
}
