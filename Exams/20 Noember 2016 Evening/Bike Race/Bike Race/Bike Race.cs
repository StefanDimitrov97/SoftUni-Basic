using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniors = double.Parse(Console.ReadLine());
            double seniors = double.Parse(Console.ReadLine());
            string area = Console.ReadLine();
            double sum = 0;
            double people = juniors + seniors;
            double tax = sum * 0.5;
            double sum1 = 0;

            if (area == "trail")
            {
                sum = ((juniors * 5.50) + (seniors * 7));
                sum1 = sum - (sum * 0.05);
            }
            else if (area == "downhill")
            {
                sum = ((juniors * 12.25) + (seniors * 13.75));
                sum1 = sum - (sum * 0.05);
            }
            else if (area == "road")
            {
                sum = ((juniors * 20) + (seniors * 21.50));
                sum1 = sum - (sum * 0.05);
            }

            else if (area == "cross-country")
            {
                sum = ((juniors * 20) + (seniors * 21.50));
                sum1 = sum - (sum * 0.05);
            }
            if (area == "cross-country")
            {
                sum1 = sum - (sum * 0.25);
            }
            Console.WriteLine("{0:f2}", sum1);
        }
    }
}
