using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7
{
    class Kruh : Objekt2D
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Kruh(double r)
        {
            if ((r < 0)) throw new Exception("Kruh nelze sestrojit.");
            Radius = r;
        }

        public override double Plocha()
        {
            return (Math.PI * Radius * Radius);
        }

        public override string ToString()
        {
            return "Kruh (r = "+ Radius + ")";
        }
    }
}
