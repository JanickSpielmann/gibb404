using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNemo
{
    public partial class frmFindeNemo : Form
    {
        
        List<Label> rechtecks = new List<Label>();
        private int geschwindigkeit = 10;

        public frmFindeNemo()
        {
            InitializeComponent();

        }

        private void tmrSpielablauf_Tick(object sender, EventArgs e)
        {
            

            for(int i = 0; i< rechtecks.Count; i++)
            {
                rechtecks[i].Location = new Point(rechtecks[i].Location.X, (rechtecks[i].Location.Y + geschwindigkeit));
                
            }






            // anpassen der Geschwindikeit inkl. % Balken
        }
        public void ErstellenVonReihen()
        {
            Random random = new Random();
            int rot = random.Next(1 - 4);
            while(untenRot)
            rechtecks.Add(ErstellenVonRechteck(Rechteck + i + j))
            
            Rechteck rechteck1 = new Rechteck(pnlSpielfeld.Location.X, pnlSpielfeld.Location.Y);
            Rechteck rechteck2 = new Rechteck((pnlSpielfeld.Location.X+(pnlSpielfeld.Width/4 * 1)), pnlSpielfeld.Location.Y);
            Rechteck rechteck3 = new Rechteck((pnlSpielfeld.Location.X + (pnlSpielfeld.Width / 4 * 2)), pnlSpielfeld.Location.Y);
            Rechteck rechteck4 = new Rechteck((pnlSpielfeld.Location.X + (pnlSpielfeld.Width / 4 * 3)), pnlSpielfeld.Location.Y);
            
            rechtecks.Add(rechteck1);
            rechtecks.Add(rechteck2);
            rechtecks.Add(rechteck3);
            rechtecks.Add(rechteck4);

            switch (rot)
            {
                case 1: 
                    rechteck1.farbe = 'r';
                    break;
                case 2:
                    rechteck2.farbe = 'r';
                    break;
                case 3:
                    rechteck3.farbe = 'r';
                    break;
                case 4:
                    rechteck4.farbe = 'r';
                    break;
            }

        }
        public Label ErstellenVonRechteck(string name,int xAchse, int yAchse)
        {
            Random random = new Random();
            Label rechteck = new Label();
            rechteck.Name = name;
            rechteck.Text = random.Next(1-20).ToString();
            return rechteck;
        }
    } 
}
