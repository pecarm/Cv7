using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7
{
    class Trojuhelnik : Objekt2D
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public Trojuhelnik(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0) || (a + b < c) || (a + c < b) || (b + c < a)) throw new Exception("Trojuhelnik nelze sestrojit.");
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override string ToString()
        {
            return "Trojuhelnik (a = " + SideA + ", b = " + SideB + ", c = " + SideC + ")";
        }

        public override double Plocha()
        {
            double p = (SideA + SideB + SideC) / 2;
            return (Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)));
        }
    }
}
