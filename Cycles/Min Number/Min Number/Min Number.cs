using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int MinNumber = int.MaxValue;
            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < MinNumber)
                {
                    MinNumber = n;
                }
            }
            Console.WriteLine(MinNumber);
        }
    }
}
