using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конзолен_междувалутен_конвертор
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            if (first == "USD")
            {
                num *= 1.79549;
            }
            else if (first == "EUR")
            {
                num*=1.95583;
            }
            if (first == "GBP")
            {
                num *= 2.53405;
            }



            if (second == "USD")
            {
                num /= 1.79549;
            }
            else if (second == "EUR")
            {
                num /= 1.95583;
            }
            if (second == "GBP")
            {
                num /= 2.53405;
            }

            Console.WriteLine(Math.Round(num,2) + " " + second);
        }
    }
}