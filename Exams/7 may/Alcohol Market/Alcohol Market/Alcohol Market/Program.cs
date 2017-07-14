using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfWhiskey = double.Parse(Console.ReadLine());
            double quantityOfBeer = double.Parse(Console.ReadLine());
            double quantityOfWine = double.Parse(Console.ReadLine());
            double quantityOfRakia = double.Parse(Console.ReadLine());
            double quantityOfWhiskey = double.Parse(Console.ReadLine());

            double priceOfRakia = priceOfWhiskey / 2;
            double priceOfWine = priceOfRakia - (priceOfRakia * 0.4);
            double priceOfBeer = priceOfRakia - (priceOfRakia * 0.8);

            double money = (priceOfWhiskey * quantityOfWhiskey) + (quantityOfBeer * priceOfBeer) + (quantityOfWine * priceOfWine) + (quantityOfRakia * priceOfRakia);
            Console.WriteLine("{0:f2}", money);
        }
    }
}
