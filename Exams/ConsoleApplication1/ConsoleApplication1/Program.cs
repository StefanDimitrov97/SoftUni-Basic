using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

       
            double prednaStena = 2 * (x * x) - (1.2 * 2);
            double stranichniSteni2 = (2 * (x * y)) - (2 * (1.5 * 1.5));

            double pokriv = (x * y) * 2;
            double pokriv1 = ((x * h) / 2) * 2;

            double zelenaBoq = (prednaStena + stranichniSteni2) * 3.4;
            double chervenaBoq = (pokriv + pokriv1) * 4.3;

            Console.WriteLine("{0:f2}", zelenaBoq);
            Console.WriteLine("{0:f2}", zelenaBoq);
        }
    }
}
