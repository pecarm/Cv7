using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7
{
    class Extremy
    {
        public static T Nejvetsi<T>(T[] data) where T:IComparable
        {
            Array.Sort(data);
            return data[data.Length - 1];
        }

        public static T Nejmensi<T>(T[] data) where T:IComparable
        {
            Array.Sort(data);
            return data[0];
        }
    }
}
