using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { 1, 3, 5, 7, 9 };
            string[] slova = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Kruh[] kruhy = new Kruh[5];
            Ctverec[] ctverce = new Ctverec[5];
            for (int i = 0; i < 5; i++)
            {
                kruhy[i] = new Kruh(i + 1);
                ctverce[i] = new Ctverec(i + 1);
            }

            Obdelnik[] obdelniky = new Obdelnik[5];
            Elipsa[] elipsy = new Elipsa[5];
            for (int i = 0; i < 5; i++)
            {
                obdelniky[i] = new Obdelnik(i + 1, 7 - i);
                elipsy[i] = new Elipsa(i + 1, 7 - i);
            }
            Trojuhelnik[] trojuhelniky = new Trojuhelnik[5];
            for (int i = 0; i < 5; i++)
            {
                trojuhelniky[i] = new Trojuhelnik(i + 3, i + 2, i + 1.5);
            }

            Objekt2D[] obrazce = new Objekt2D[] { new Trojuhelnik(7, 2, 8), new Ctverec(3), new Elipsa(3, 9), new Obdelnik(1, 2), new Kruh(9)};

            Console.WriteLine(Extremy.Nejvetsi<int>(cisla));
            Console.WriteLine(Extremy.Nejmensi<int>(cisla));
            Console.WriteLine(Extremy.Nejvetsi<string>(slova));
            Console.WriteLine(Extremy.Nejmensi<string>(slova));
            
            Console.WriteLine(Extremy.Nejvetsi<Kruh>(kruhy).ToString());
            Console.WriteLine(Extremy.Nejmensi<Kruh>(kruhy).ToString());
            Console.WriteLine(Extremy.Nejvetsi<Ctverec>(ctverce).ToString());
            Console.WriteLine(Extremy.Nejmensi<Ctverec>(ctverce).ToString());
            Console.WriteLine(Extremy.Nejvetsi<Obdelnik>(obdelniky).ToString());
            Console.WriteLine(Extremy.Nejmensi<Obdelnik>(obdelniky).ToString());
            Console.WriteLine(Extremy.Nejvetsi<Elipsa>(elipsy).ToString());
            Console.WriteLine(Extremy.Nejmensi<Elipsa>(elipsy).ToString());
            Console.WriteLine(Extremy.Nejvetsi<Trojuhelnik>(trojuhelniky).ToString());
            Console.WriteLine(Extremy.Nejmensi<Trojuhelnik>(trojuhelniky).ToString());

            Console.WriteLine(Extremy.Nejvetsi<Objekt2D>(obrazce).ToString());
            Console.WriteLine(Extremy.Nejmensi<Objekt2D>(obrazce).ToString());

            int[] linqVyber = cisla.Where(i => (i >= 4 && i <= 8)).ToArray();
            foreach (int cislo in linqVyber)
            {
                Console.WriteLine(cislo);
            }
        }
    }
}
