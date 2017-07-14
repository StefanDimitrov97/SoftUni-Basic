using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sumA = 0;
            int sumB = 0;

            for (int i = 0; i < counter; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumA += num;
                }
                else
                    sumB += num;
            }
            if (sumA == sumB)
            {
                Console.WriteLine("Yes, sum = {0}", sumA);
            }
            else
                Console.WriteLine("No, diff = {0}", Math.Abs(sumA - sumB));

        }
    }
}
