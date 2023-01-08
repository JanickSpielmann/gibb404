using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNemo
{
    internal class Rechteck
    {
        public int[] position = new int[2]; //Position 0 = x, Position 1 = y
        public char farbe;

    public Rechteck(char farbe) { 
            this.farbe = farbe;
        }

    public void Bewege(int xAchse, int yAchse)
        {
            this.position[0] = xAchse;
            this.position[1] = yAchse;
        }


    }
}
