using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Rechenoperationen
    {

        public Rechenoperationen() { }

        public double Addieren(double zahl1, double zahl2)
        {
            return zahl1 + zahl2;
        }
        public double Subtrahieren(double zahl1, double zahl2)
        {
            return zahl1 - zahl2;
        }
        public double Multiplizieren (double zahl1, double zahl2)
        {
            return zahl1 * zahl2;
        }
        public double Dividieren(double zahl1, double zahl2)
        {
            return zahl1 / zahl2;
        }
        public double Mittelwert(double zahl1, double zahl2)
        {
            return (zahl1 + zahl2)/2;
        }
        public double Potenz(double zahl1, double zahl2)
        {
            return Math.Pow(zahl1, zahl2);
        }
        public double Maximum(double zahl1, double zahl2)
        {
            if(zahl1 < zahl2)
            {
                return zahl2;
            }
            return zahl1;
        }
    }
}
