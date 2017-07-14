using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = int.Parse(Console.ReadLine()); // брой празници в годината (които не са събота и неделя)
            double h = int.Parse(Console.ReadLine()); // брой уикенди, в които Влади си пътува до роднияград.

            double weekendsInSofia = (48 - h) * 3 / 4;
            double holidays = p * 2/3;
            double normalGames = h + weekendsInSofia + holidays;
            double GamesPlusBonus15 = normalGames + (normalGames * 0.15);

            if (year == "leap")
	        {
		    Console.WriteLine("{0}", Math.Floor(GamesPlusBonus15));
	        }
            else if (year == "normal")
            {
                Console.WriteLine("{0}", Math.Floor(normalGames));
            }
        }
    }
}
