using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05555
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('#', (n*4)+1));
            for (int i = 0; i < (2*n)+1; i++)
            {
                Console.Write(new string('.', i));
                for (int j = (2*n)+1; j > i; j--)
                {
                    
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            }
        }
    }
//}
