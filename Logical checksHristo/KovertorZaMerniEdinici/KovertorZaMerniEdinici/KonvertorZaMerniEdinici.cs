using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KovertorZaMerniEdinici
{
    class KonvertorZaMerniEdinici
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            if (first == "mm")
            {
                num /= 1000;
            }
            else if (first == "sm")
            {
                num /= 100;
            }
            else if (first == "mi")
            {
                num /= 0.000621371192;
            }
            else if (first == "in")
            {
                num /= 39.3700787;
            }
            else if (first == "km")
            {
                num /= 0.001;
            }
            else if (first == "ft")
            {
                num /= 3.2808399;
            }
            else if (first == "yd")
            {
                num /= 1.0936133;
            }



            if (second == "mm")
            {
                num *= 1000;
            }
            else if (second == "sm")
            {
                num *= 100;
            }
            else if (second == "mi")
            {
                num *= 0.000621371192;
            }
            else if (second == "in")
            {
                num *= 39.3700787;
            }
            else if (second == "km")
            {
                num *= 0.001;
            }
            else if (second == "ft")
            {
                num *= 3.2808399;
            }
            else if (second == "yd")
            {
                num *= 1.0936133;
            }

            Console.WriteLine(num);
        }
    }
}
