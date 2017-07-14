using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Периметър_и_лице_на_кръг
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete stoinost na radiosa na okrujnostta: ");
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Liceto na okrujnostta e: {0}", area);
            Console.WriteLine("Perimetura na okrujnostta e: {0}", perimeter);

            // Периметър и лице на кръг
            //Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг /
            //окръжност с радиус r.
            //За изчисленията можете да използвате следните формули:
            //area = Math.PI * r * r
            //perimeter = 2 * Math.PI * r
        }
    }
}
