using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double SubraniPari = double.Parse(Console.ReadLine());
            
            double ShirochinaNaPoda = double.Parse(Console.ReadLine());
            double DuljinaNaPoda = double.Parse(Console.ReadLine());
           
            double StranaNaTriugulnika = double.Parse(Console.ReadLine());
            double VisochinaNaTriugulnika = double.Parse(Console.ReadLine());
            
            double CenaNaEdnaPlochka = double.Parse(Console.ReadLine());
           
            double SumaZaMaistora = double.Parse(Console.ReadLine());
           
            double PloshttaNaPoda = 0;
            double PloshttaNaPlochka = 0;
            double NeobhodimiPlochki = 0;
            double ObshtaSuma = 0;
            double rezultat = ObshtaSuma - SubraniPari;
            double rezultat2 = SubraniPari - ObshtaSuma;
            

            PloshttaNaPoda = ShirochinaNaPoda * DuljinaNaPoda;
            PloshttaNaPlochka = (StranaNaTriugulnika * VisochinaNaTriugulnika) / 2;
            NeobhodimiPlochki = Math.Ceiling(((PloshttaNaPoda / PloshttaNaPlochka)) + 5);
            ObshtaSuma = NeobhodimiPlochki * CenaNaEdnaPlochka + SumaZaMaistora;
           
            if (rezultat >= 0)
            {
                Console.WriteLine("{0:f2} lv left.", rezultat);
            }
            else if (rezultat < 0)
            {
                Console.WriteLine("You'll need {0:f2} lv more.", rezultat2);
            }



        }
    }
}
