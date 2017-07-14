using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double broiSladkari = double.Parse(Console.ReadLine());
            double broiTorti = double.Parse(Console.ReadLine());
            double broiGofreti = double.Parse(Console.ReadLine());
            double broiPalachniki = double.Parse(Console.ReadLine());

            double torti = broiTorti * 45;
            double gofreti = broiGofreti * 5.80;
            double palachinki = broiPalachniki * 3.20;
            double allSumInOneDay = (torti + gofreti + palachinki) * broiSladkari;

            double sumForAllDays = allSumInOneDay * days;

            double sumaSledRazhodi = sumForAllDays - (sumForAllDays / 8);

            Console.WriteLine("{0:f2}", sumaSledRazhodi);
        }
    }
}
