using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmGameOver : Form
    {
        public frmGameOver(int score)
        {
            InitializeComponent();
            lblPunkte.Text = Convert.ToString(score);
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            
        }
    }
}
