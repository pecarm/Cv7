using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7
{
    public abstract class Objekt2D : I2D, IComparable
    {
        public abstract double Plocha();

        public int CompareTo(object obrazec)
        {
            if (this.Plocha() > ((Objekt2D)obrazec).Plocha())
            {
                return 1;
            }
            else if (this.Plocha() < ((Objekt2D)obrazec).Plocha())
            {
                return -1;
            }
            else return 0;
        }
    }
}
