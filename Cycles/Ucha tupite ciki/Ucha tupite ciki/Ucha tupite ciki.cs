using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucha_tupite_ciki
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var MinNumber = int.MaxValue;
            for (int i =0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < MinNumber)
                {
                    MinNumber = num;
                }
                Console.WriteLine(MinNumber);
            }

        }
    }
}
