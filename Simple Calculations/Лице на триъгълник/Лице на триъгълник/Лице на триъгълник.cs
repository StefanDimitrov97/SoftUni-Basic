using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лице_на_триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (side * h) / 2;

            Console.WriteLine("Triangle area = {0}", Math.Round(area, 2));

        }
    }
}
