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
    public partial class frmPingPong : Form
    {
        int xRichtung = 5;
        int yRichtung = 2;
        public frmPingPong()
        {
            InitializeComponent();
            ovsBall.Location = new Point(75, 25);
            picSchlägerRechts.Location = new Point(590, 25);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            if(ovsBall.Location.X >= 600- ovsBall.Width || ovsBall.Location.X <= 0)
            {
                xRichtung = xRichtung * -1;
            }
            else if (ovsBall.Location.Y >= 300- ovsBall.Height || ovsBall.Location.Y <= 0)
            {
                yRichtung = yRichtung * -1;
            }
            ovsBall.Location = new Point(ovsBall.Location.X + xRichtung, ovsBall.Location.Y + yRichtung);
            picSchlägerRechts.Location = new Point(picSchlägerRechts.Location.X, vsbSchlägerRechts.Location.Y);

        }

        private void txtPunkte_TextChanged(object sender, EventArgs e)
        {
            int score = 0;
            
        }

        private void picSchlägerRechts_Click(object sender, EventArgs e)
        {

        }

        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
      
    }
}
