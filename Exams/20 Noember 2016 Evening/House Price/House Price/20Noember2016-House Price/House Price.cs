using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Noember2016_House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double TheSmallestRoom = double.Parse(Console.ReadLine());
            double Kitchen = double.Parse(Console.ReadLine());
            double PriceOfSquareMeter = double.Parse(Console.ReadLine());
            var Bathroom = TheSmallestRoom / 2;
            var SecondRoom = (TheSmallestRoom * 0.1) + TheSmallestRoom;
            var ThirdRoom = (SecondRoom * 0.1) + SecondRoom;
            var Total = (TheSmallestRoom + Kitchen + Bathroom + SecondRoom + ThirdRoom);
            var TotalArea = (Total * 0.05) + Total;

            var PriceOfApartament = TotalArea * PriceOfSquareMeter;
            Console.WriteLine("{0:f2}", PriceOfApartament);

        }
    }
}
