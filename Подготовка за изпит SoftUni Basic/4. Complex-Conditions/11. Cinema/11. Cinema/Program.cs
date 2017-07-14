using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projekciq = Console.ReadLine();
            double red = double.Parse(Console.ReadLine());
            double kolona = double.Parse(Console.ReadLine());

            if (projekciq == "Premiere")
            {
                Console.WriteLine("{0:f2} leva", red * kolona * 12); 
            }
            else if (projekciq == "Normal")
            {
                Console.WriteLine("{0:f2} leva", red * kolona * 7.50);
            }
            else if (projekciq == "Discount")
            {
                Console.WriteLine("{0:f2} leva", red * kolona * 5);
            }
        }
    }
}
