using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int someNumber = int.MaxValue;
            int sum = 1;

            for (int i = 0; i < someNumber; i++)
            {
                sum += sum;
            Console.WriteLine(sum);
            }
        }
    }
}