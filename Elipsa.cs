using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7
{
    class Elipsa : Objekt2D
    {
        private double semiAxisA;
        private double semiAxisB;

        public double SemiAxisA
        {
            get { return semiAxisA; }
            set { semiAxisA = value; }
        }

        public double SemiAxisB
        {
            get { return semiAxisB; }
            set { semiAxisB = value; }
        }

        public Elipsa(double a, double b)
        {
            if ((a < 0) || (b < 0)) throw new Exception("Elipsu nelze sestrojit.");
            SemiAxisA = a;
            SemiAxisB = b;
        }
        public override double Plocha()
        {
            return (Math.PI * SemiAxisA * SemiAxisB);
        }

        public override string ToString()
        {
            return "Elipsa (poloosa a = " + SemiAxisA + ", poloosa b = " + SemiAxisB + ")";
        }
    }
}
