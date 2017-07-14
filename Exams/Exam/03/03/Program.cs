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
                double smallWatermelon = broi * 56;
                if (smallWatermelon >= 400 && smallWatermelon <= 1000) // !!!!! ?????
                {
                    Console.WriteLine("{0:f2} lv.", smallWatermelon - (smallWatermelon * 0.15));
                }
                else if (smallWatermelon > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smallWatermelon / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv." , smallWatermelon);
                }


            }
            else if (plod == "Mango" && razmer == "small")
            {
                double smallMango = broi * 36.66;
                if (smallMango >= 400 && smallMango <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smallMango - (smallMango * 0.15));
                }
                else if (smallMango > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smallMango / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", smallMango);
                }
            }
            else if (plod == "Pineapple" && razmer == "small")
            {
                double smallPineapple = broi * 42.10;
                if (smallPineapple > 400 && smallPineapple < 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smallPineapple - (smallPineapple * 0.15));
                }
                else if (smallPineapple > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smallPineapple / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", smallPineapple);
                }
            }
            else if (plod == "Raspberry" && razmer == "small")
            {
                double smallRaspberry = broi * 20;
                if (smallRaspberry >= 400 && smallRaspberry <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smallRaspberry - (smallRaspberry * 0.15));
                }
                else if (smallRaspberry > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", smallRaspberry / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", smallRaspberry);
                }
            }
            else if (plod == "Watermelon" && razmer == "big")
            {
                double bigWatermelon = broi * 28.70;
                if (bigWatermelon >= 400 && bigWatermelon <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", bigWatermelon - (bigWatermelon * 0.15));
                }
                else if (bigWatermelon > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", bigWatermelon / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", bigWatermelon);
                }
            }
            else if (plod == "Mango" && razmer == "big")
            {
                double bigMango = broi * 19.60;
                if (bigMango >= 400 && bigMango <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", bigMango - (bigMango * 0.15));
                }
                else if (bigMango > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", bigMango / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", bigMango);
                }
            }
            else if (plod == "Pineapple" && razmer == "big")
            {
                double bigPineapple = broi * 24.80;
                if (bigPineapple >= 400 && bigPineapple <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", bigPineapple - (bigPineapple * 0.15));
                }
                else if (bigPineapple > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", bigPineapple / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", bigPineapple);
                }
            }
            else if (plod == "Raspberry" && razmer == "big")
            {
                double bigRaspberry = broi * 15.20;
                if (bigRaspberry >= 400 && bigRaspberry <= 1000)
                {
                    Console.WriteLine("{0:f2} lv.", bigRaspberry - (bigRaspberry * 0.15));
                }
                else if (bigRaspberry > 1000)
                {
                    Console.WriteLine("{0:f2} lv.", bigRaspberry / 2);
                }
                else
                {
                    Console.WriteLine("{0:f2} lv.", bigRaspberry);
                }
            }



        }
    }
}
