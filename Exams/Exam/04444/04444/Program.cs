using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04444
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double nagradaZaEdnaTochka = double.Parse(Console.ReadLine());
            double chetenSum = 0.0;
            double nechetenSum = 0.0;
            double tochki = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double pozicii = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    chetenSum += pozicii;
                }
                else if (i % 2 != 0 )
	            {
		            nechetenSum += pozicii;
	            }
            }
            tochki = (chetenSum * 2) + nechetenSum;
            Console.WriteLine("The project prize was {0:f2} lv.", tochki * nagradaZaEdnaTochka);
        }

                
    
    }
}
