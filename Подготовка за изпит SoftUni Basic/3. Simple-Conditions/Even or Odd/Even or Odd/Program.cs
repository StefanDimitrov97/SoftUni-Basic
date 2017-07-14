using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = double.Parse(Console.ReadLine());

            if (chislo % 2 == 0)
            {
                Console.WriteLine("even");
            }
	        else
            {
                Console.WriteLine("odd");
	        }
        }
    }
}
