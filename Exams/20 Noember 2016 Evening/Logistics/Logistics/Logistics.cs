using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            var AllTovari = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num <= 3)
                {
                   sum = num * 200;
                }
                else if (num <= 11)
                {
                   sum = num * 175;
                }
                else if (num > 11)
                {
                   sum = num * 120;
                }
                AllTovari = num;
            }
            var average = sum / AllTovari;
            Console.WriteLine(average);
        }
    }
}
