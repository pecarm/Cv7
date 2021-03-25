using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7
{
    class Ctverec : Objekt2D
    {
        private double sideA;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public Ctverec(double a)
        {
            if (a < 0) throw new Exception("Obdelnik nelze sestrojit.");
            SideA = a;
        }

        public override string ToString()
        {
            return "Obdelnik (a = " + SideA + ")";
        }

        public override double Plocha()
        {
            return SideA * SideA;
        }
    }
}
