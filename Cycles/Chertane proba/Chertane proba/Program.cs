using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chertane_proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', n));
            Console.WriteLine(" |");
            for (int i = 1; i <= n; i++)
			{
			    Console.Write(new string(' ', n - 1));
                Console.Write(new string('*', i));
                Console.Write(" ");
                Console.Write("|");
                Console.Write(" ");
                Console.WriteLine(new string('*',i));
			}
        }
    }
}
