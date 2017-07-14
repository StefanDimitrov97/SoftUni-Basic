using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());// broi praznici
            double h = double.Parse(Console.ReadLine());// broi yikendi do rodniq grad 
          
            double praznici = p *(2.0/3);
            double BroiIgriVrodniqGrad = h;
            double weeksInSofia = (48 - h) * (3.0 / 4);
            double allGames = praznici + BroiIgriVrodniqGrad + weeksInSofia;

            if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(allGames));
            }
            else if (year == "leap")
            {
                Console.WriteLine(Math.Truncate((allGames * 15 / 100) + allGames));
            }


        }
    }
}
