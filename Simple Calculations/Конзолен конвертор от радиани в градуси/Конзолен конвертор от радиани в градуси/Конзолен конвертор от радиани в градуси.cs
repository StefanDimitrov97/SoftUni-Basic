using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конзолен_конвертор_от_радиани_в_градуси
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete ugul v radiani: ");
            double rad = double.Parse(Console.ReadLine());
            double deg = (rad * 180) / Math.PI;
            Console.WriteLine("Gradusi: {0}", Math.Round(deg));



            //Напишете програма, която чете ъгъл в радиани (rad) и го преобразува в градуси (deg). Потърсете в Интернет
            //подходяща формула. Числото π в C# програми е достъпно чрез Math.PI. Закръглете резултата до най-
            //близкото цяло число използвайки Math.Round().
        }
    }
}
