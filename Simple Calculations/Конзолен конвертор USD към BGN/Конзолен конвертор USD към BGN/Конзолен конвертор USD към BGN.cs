using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конзолен_конвертор_USD_към_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD: ");
            double usd = double.Parse(Console.ReadLine());

            double bg = usd * 1.79549;
            Console.WriteLine("BG: {0} BGN", Math.Round(bg,2));
            
            
            
            //Напишете програма за конвертиране на щатски долари (USD) в български лева (BGN). Закръглете резултата
            //до 2 цифри след десетичната запетая. Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.

        }
    }
}
