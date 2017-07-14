using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03333333333333
{
    class Program
    {
        static void Main(string[] args)
        {
            string plod = Console.ReadLine();
            string razmer = Console.ReadLine();
            double broi = double.Parse(Console.ReadLine());
            double smetka = 0.0;

            if (razmer == "small")
            {
                if (plod == "WaterMelon")
                {
                    smetka = broi * 56 * 2;
                }
                else if (plod == "Mango")
                {
                    smetka = broi * 36.66 * 2;
                }
                else if (plod == "Pineapple")
                {
                    smetka = broi * 42.10 * 2;
                }
                else if (plod == "Raspberry")
                {
                    smetka = broi * 20 * 2;
                }
                if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", smetka);
                }
            }
            else if (razmer == "big")
            {
                if (plod == "Watermelon")
                {
                    smetka = broi * 28.70 * 5;
                }
                else if (plod == "Mango")
                {
                    smetka = broi * 19.60 * 5;
                }
                else if (plod == "Pineapple")
                {
                    smetka = broi * 24.80 * 5;
                }
                else if (plod == " Raspberry")
                {
                    smetka = broi * 15.20 * 5;
                }
                if (smetka >= 400 && smetka < 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka >= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", smetka);
                }
            }
        }
    }
}
