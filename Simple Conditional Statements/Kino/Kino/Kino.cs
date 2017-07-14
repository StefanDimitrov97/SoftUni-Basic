using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    class Kino
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int horizontal = int.Parse(Console.ReadLine());
            int vertical = int.Parse(Console.ReadLine());
            int mesta = horizontal * vertical;

            if (type == "Premiere")
            {
                Console.WriteLine("{0:f2} leva", mesta * 12);
            }
            else if (type == "Normal")
            {
                Console.WriteLine("{0:f2} leva", mesta* 7.5);
            }
            else if (type == "Discount")
            {
                Console.WriteLine("{0:f2} leva", mesta * 5);
            }
        }
    }
}
