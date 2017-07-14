using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Starsss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
               Console.WriteLine();
            }
            
            for (int y = n - 1; y > 0; y--)
			{
                Console.Write(new string(' ', n - y));
                for (int k = 0; k < y; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
			}
            
        }
    }
}
