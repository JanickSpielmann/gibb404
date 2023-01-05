using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace StandardEreignisse
{
    
    public partial class frmWriter : Form
    {
        
        public frmWriter()
        {
            InitializeComponent();
        }
        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    txtAusgabe.Text += "linke Maustaste runter" + Environment.NewLine;
                    break;
               case MouseButtons.Right:
                  txtAusgabe.Text += "rechte Maustaste runter" + Environment.NewLine;
                break;
               case MouseButtons.Middle:
                    txtAusgabe.Text += "mittlere Maustaste runter" + Environment.NewLine;
                    break;
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtAusgabe.Text += "Doppelklick links" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtAusgabe.Text += "Doppelklick rechts" + Environment.NewLine;
                    break;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtAusgabe.Text += "Klick linke Maustaste" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtAusgabe.Text += "Klick rechte Maustaste" + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtAusgabe.Text += "Klick mittlere Maustaste" + Environment.NewLine;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            txtAusgabe.Text += "Taste runter" + Environment.NewLine;
            txtAusgabe.Text += (char) e.KeyValue + " gedrückt" + Environment.NewLine;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            txtAusgabe.Text += "Taste hoch" + Environment.NewLine;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    txtAusgabe.Text += "linke Maustaste hoch" + Environment.NewLine;
                    break;
                case MouseButtons.Right:
                    txtAusgabe.Text += "rechte Maustaste hoch" + Environment.NewLine;
                    break;
                case MouseButtons.Middle:
                    txtAusgabe.Text += "mittlere Maustaste hoch" + Environment.NewLine;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtAusgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
        frmInformationen info = new frmInformationen();
        info.Show();
        }
    }
}


