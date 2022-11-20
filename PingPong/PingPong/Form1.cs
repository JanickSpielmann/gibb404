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
        int xDirection = 5;
        int yDirection = 2;
        public frmPingPong()
        {
            InitializeComponent();
            picBall.Location = new Point(75, 25);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            if(picBall.Location.X >= 600-picBall.Width || picBall.Location.X <= 0)
            {
                xDirection = xDirection * -1;
            }
            else if (picBall.Location.Y >= 300-picBall.Height|| picBall.Location.Y <= 0)
            {
                yDirection = yDirection * -1;
            }
            picBall.Location = new Point(picBall.Location.X + xDirection, picBall.Location.Y + yDirection);
       
        }

        private void txtPunkte_TextChanged(object sender, EventArgs e)
        {
            int score = 0;
            if()
        }

        private void picSchlägerRechts_Click(object sender, EventArgs e)
        {

        }

        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
