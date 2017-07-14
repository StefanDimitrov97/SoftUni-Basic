using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Magnolia = double.Parse(Console.ReadLine()) * 3.25;
            double Hyacinths = double.Parse(Console.ReadLine()) * 4;
            double Rose = double.Parse(Console.ReadLine()) * 3.50;
            double Cactus = double.Parse(Console.ReadLine()) * 8;
            double Gift = double.Parse(Console.ReadLine());
            double Sum = Magnolia + Hyacinths + Rose + Cactus;
            double TotalSumWithTax = Sum - (Sum * 0.05);
            double Money = Gift - TotalSumWithTax;
            
           
            if (TotalSumWithTax >= Gift)
            {
             Console.WriteLine("She is left with {0} leva.", Math.Abs(Math.Floor(Gift - TotalSumWithTax) + 1));
            }
            else if (TotalSumWithTax <= Gift)
            {
            Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(Money));
                
            }
            

            // 90 от 100 точки !!
        }
    }
}
