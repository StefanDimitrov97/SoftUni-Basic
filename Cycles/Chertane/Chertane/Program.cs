using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chertane
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                Console.Write(new string(' ', i));
                Console.WriteLine("{0}", new string('*'), i);
            }
             
            }
        }
    }


