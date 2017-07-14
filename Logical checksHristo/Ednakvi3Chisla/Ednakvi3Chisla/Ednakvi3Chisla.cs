using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ednakvi3Chisla
{
    class Ednakvi3Chisla
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if ((num1 == num2) && (num1== num3))
            {
                Console.WriteLine("yes");
            }
            else if ((num2 == num1) && (num2== num3))
            {
                Console.WriteLine("yes"); 
            }
            else if ((num3 == num2) && (num3 == num1))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
