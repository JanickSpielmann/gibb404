using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardEreignisse
{
    public partial class frmInformationen : Form
    {

        public frmInformationen()
        {
            InitializeComponent();
        }
        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmWriter writer = new frmWriter();
            writer.Show();
        }
    }
}
