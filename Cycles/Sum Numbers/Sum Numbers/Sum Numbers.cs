using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum = sum + num;
            }
            Console.WriteLine(sum);



        }
    }
}
