using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            if (numberOne >= numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }

        }
    }
}
