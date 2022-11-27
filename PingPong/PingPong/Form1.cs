using Microsoft.VisualBasic.Devices;
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
        int score = 0;
        
        public frmPingPong()
        {
            InitializeComponent();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            ovsBall.Location = new Point(75, 25);
            picSchlägerRechts.Location = new Point(580, 50);
            score = 0;
            
            score = 0;
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {


            if ((ovsBall.Location.Y + (ovsBall.Height / 2) > picSchlägerRechts.Location.Y) && (ovsBall.Location.Y + (ovsBall.Height / 2) < (picSchlägerRechts.Location.Y + picSchlägerRechts.Height) + (ovsBall.Height / 2)))
            {
                if (ovsBall.Location.X >= picSchlägerRechts.Location.X - ovsBall.Width)
                {
                    xRichtung = xRichtung * -1;
                    score += 10;
                    ovsStatus.BackColor = Color.GreenYellow;
                }
            }
            if (ovsBall.Location.X >= pnlSpiel.Width - ovsBall.Width)
            {

                tmrSpiel.Stop();
                new frmGameOver(score).Show();
                this.Close();

                ovsStatus.BackColor = Color.Red;
            }
            else if (ovsBall.Location.X <= 0)
            {
                xRichtung = - xRichtung;
            }

            else if (ovsBall.Location.Y >= pnlSpiel.Height - ovsBall.Height || ovsBall.Location.Y <= 0)
            {
                yRichtung = -yRichtung;
            }
            ovsBall.Location = new Point(ovsBall.Location.X + xRichtung, ovsBall.Location.Y + yRichtung);
            picSchlägerRechts.Location = new Point(picSchlägerRechts.Location.X, (pnlSpiel.Height / vsbSchlägerRechts.Maximum * vsbSchlägerRechts.Value));
            txtPunkte.Text = Convert.ToString(score);

        }

        private void ovsStatus_Click(object sender, EventArgs e)
        {

        }

        private void frmPingPong_Load(object sender, EventArgs e)
        {

        }



        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Up:
                    ovsBall.Location = new Point(ovsBall.Location.X, ovsBall.Location.Y - 25);
                    break;
                case Keys.Left:
                    ovsBall.Location = new Point(ovsBall.Location.X + -25, ovsBall.Location.Y);
                    break;
                case Keys.Down:
                    ovsBall.Location = new Point(ovsBall.Location.X, ovsBall.Location.Y + 25);
                    break;
                case Keys.Right:
                    ovsBall.Location = new Point(ovsBall.Location.X + +25, ovsBall.Location.Y);
                    break;
                case Keys.H:
                    xRichtung = -xRichtung;
                    break;
                case Keys.V: 
                    yRichtung = -yRichtung;
                    break ;
                case Keys.P:
                    tmrSpiel.Stop();
                    break;
                case Keys.S:
                    tmrSpiel.Start();
                    break;

            }
            return true;

        }

        private void btnHoch_Click(object sender, EventArgs e)
        {
            ProcessDialogKey(Keys.Up);
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            ProcessDialogKey(Keys.Left);
        }

        private void btnRechts_Click(object sender, EventArgs e)
        {
            ProcessDialogKey(Keys.Right);
        }

        private void btnRunter_Click(object sender, EventArgs e)
        {
            ProcessDialogKey(Keys.Down);
        }

    }
}



