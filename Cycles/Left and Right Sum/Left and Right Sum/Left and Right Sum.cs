using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int SumA = 0;
            int SumB = 0;

            for (int i = 0; i < count; i++)
            {
                var num = int.Parse(Console.ReadLine());
                SumA += num;
            }
            for (int i = 0; i < count; i++)
            {
                var num = int.Parse(Console.ReadLine());
                SumB += num;
            }
            if (SumA == SumB)
            {
                Console.WriteLine("Yes, sum= {0}", SumA);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(SumA - SumB));
            }

        }
    }
}
