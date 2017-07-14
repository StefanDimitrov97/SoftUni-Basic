using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();


            if (age >= 16 && sex == "m" )
            {
                Console.WriteLine("Mr.");
            }
            else if (age < 16 && sex == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16 && sex == "f")
            {
                Console.WriteLine("Ms.");
            }
            else if (age < 16 && sex == "f")
            {
                Console.WriteLine("Miss");
            }

        }
    }
}
