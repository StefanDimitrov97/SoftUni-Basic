using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string plod = Console.ReadLine();
            string razmer = Console.ReadLine();
            var broi = double.Parse(Console.ReadLine());
            


            if (plod == "Watermelon" && razmer == "small")
            {
                double smetka = broi * 56;

                 if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2}", smetka / 2);
                }
            }
            else if (plod == "Mango" && razmer == "small")
            {
                double smetka = broi * 36.66;
                if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2}", smetka / 2);
                }
                
            }
            else if (plod == "Pineapple" && razmer == "small")
            {
                double smetka = broi * 42.10;
                if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2}", smetka / 2);
                }
                
            }
            else if (plod == "Raspberry" && razmer == "small")
            {
               double smetka = broi * 20;
                if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2}", smetka / 2);
                }
                
            }
            else if (plod == "Watermelon" && razmer == "big")
            {
                double smetka = broi * 28.70;
                if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2}", smetka / 2);
                }
                
            }
            else if (plod == "Mango" && razmer == "big")
            {
                double smetka = broi * 19.60;
                if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2}", smetka / 2);
                }
            }
               
            
            else if (plod == "Pineapple" && razmer == "big")
            {
                double smetka = broi * 24.80;
                if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2}", smetka / 2);
                }
               
            }
            else if (plod == "Raspberry" && razmer == "big")
            {
                double smetka = broi * 15.20;
                if (smetka >= 400 && smetka <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
                }
                else if (smetka > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smetka / 2);
                }
               
            }

          //  if (smetka >= 400 && smetka <= 1000)
          //  {
          //     Console.WriteLine("{0:f2} lv.", smetka - (smetka * 0.15));
          //  }
          //  else if (smetka > 1000)
          //  {
          //      Console.WriteLine("{0:f2}", smetka / 2);
          //  }
          //



        }
    }
}
