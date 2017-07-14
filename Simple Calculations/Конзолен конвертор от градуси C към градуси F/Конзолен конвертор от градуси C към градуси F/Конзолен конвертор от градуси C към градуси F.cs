using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конзолен_конвертор_от_градуси_C_към_градуси_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi temperatura v celzii: ");
            double Celsius = double.Parse(Console.ReadLine());
            
            double Fahrenheit = (Celsius * 1.8) + 32;
            Console.WriteLine("Temperatura v Fahrenheit: {0}", Math.Round(Fahrenheit, 2));



            //Напишете програма, която чете градуси по скалата на Целзий (°C) и ги преобразува до градуси по скалата на
            //Фаренхайт (°F). Потърсете в Интернет подходяща формула, с която да извършите изчисленията. Закръглете
            //резултата до 2 знака след десетичната точка.
        }
    }
}
