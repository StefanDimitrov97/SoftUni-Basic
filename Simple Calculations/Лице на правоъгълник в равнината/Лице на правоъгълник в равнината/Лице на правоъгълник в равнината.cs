using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лице_на_правоъгълник_в_равнината
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());


            double sideA = (Math.Abs(x1 - y1));
            double sideB = (Math.Abs(x2 - y2));
         Console.WriteLine("Strana A= {0}", sideA);
         Console.WriteLine("Strana B= {0}", sideB);
            double lice = sideA * sideB;
            double perimeter = 2 * (sideA + sideB);
            Console.WriteLine("Liceto na pravougulnika e: {0}", lice);
            Console.WriteLine("Perimetura na pravougulnika e: {0}", perimeter);
        }
    }
}
