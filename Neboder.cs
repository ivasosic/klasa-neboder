using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neboder
{
    internal class Neboder
    {
        int brKatova = 0;
        double visina = 0;

        public int BrKatova { get => brKatova; set => brKatova = value; }
        public double Visina { get => visina; set => visina = value; }

        public Neboder(int brKatova, double visina)
        {
            this.Visina = visina;
            this.BrKatova = brKatova;
        }
        public Neboder()
        {
            this.Visina = visina;
            this.BrKatova = brKatova;
        }

        public override string ToString()
        {
            visina += 10;
            brKatova += 1;
            double avgKat = visina / brKatova;
            string str = "Visina: " + visina + "\nBroj katova: " + brKatova + "\nAvg visina kata: " + avgKat + " metara";
            return str;
        }
    }
}
