using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());


            if ((day == "Monday" || day == "Tuesday" || day == "Wednesday " || day == "Thursday " || day == "Friday") && fruit == "banana")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 2.50);
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday " || day == "Thursday " || day == "Friday") && fruit == "apple")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 1.20);
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday " || day == "Thursday " || day == "Friday") && fruit == "orange")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 0.85);
            }
            else if (((day == "Monday" || day == "Tuesday" || day == "Wednesday " || day == "Thursday " || day == "Friday") && fruit == "grapefruit"))
            {
                Console.WriteLine("{0:f2}", kolichestvo * 1.45);
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday " || day == "Thursday " || day == "Friday") && fruit == "kiwi")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 2.70);
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday " || day == "Thursday " || day == "Friday") && fruit == "pineapple")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 5.50);
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday " || day == "Thursday " || day == "Friday") && fruit == "grapes")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 3.85);
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "banana")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 2.70);
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "apple")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 1.25);
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "orange")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 0.90);
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "grapefruit")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 1.60);  
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "kiwi")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 3);
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "pineapple")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 5.60);
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "grapes")
            {
                Console.WriteLine("{0:f2}", kolichestvo * 4.20);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
