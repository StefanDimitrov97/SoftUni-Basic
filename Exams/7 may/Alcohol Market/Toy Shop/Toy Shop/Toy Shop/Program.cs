using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfExcursion = double.Parse(Console.ReadLine());
            double numberOfPuzzle = double.Parse(Console.ReadLine());
            double numberOfDolls = double.Parse(Console.ReadLine());
            double numberOfBear = double.Parse(Console.ReadLine());
            double numberOfMinions = double.Parse(Console.ReadLine());
            double numberOfTrucks = double.Parse(Console.ReadLine());

            double sumOfNumbers = numberOfBear + numberOfDolls + numberOfMinions + numberOfPuzzle + numberOfTrucks;

            double puzzle = 2.60;
            double dolls = 3;
            double bear = 4.10;
            double minion = 8.20;
            double truck = 2;

            double moneyFromSales = (numberOfPuzzle * puzzle) + (numberOfDolls * dolls) + (numberOfBear * bear) + (numberOfMinions * minion) + (numberOfTrucks * truck);

            if (sumOfNumbers >= 50)
            {
                moneyFromSales = moneyFromSales - (moneyFromSales * 0.25);
            }

            moneyFromSales = moneyFromSales - (moneyFromSales * 0.10);

            if (moneyFromSales >= priceOfExcursion)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", moneyFromSales - priceOfExcursion);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", Math.Abs(moneyFromSales - priceOfExcursion));
            }
        }
    }
}
