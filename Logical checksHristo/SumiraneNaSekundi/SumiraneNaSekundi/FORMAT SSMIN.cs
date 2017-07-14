using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumiraneNaSekundi
{
    class SumiraneNaSekundi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete vremenata na 3mata suztezateli v secundi ot 1 do 59");
            double suz1 = double.Parse(Console.ReadLine());
            double suz2 = double.Parse(Console.ReadLine());
            double suz3 = double.Parse(Console.ReadLine());
            double second = suz1 + suz2 + suz3;
            var minute = TimeSpan.FromSeconds(second);
            Console.WriteLine(minute.ToString(@"mm\:ss"));









            //Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50). Да се напише програма,
            //която въвежда времената на състезателите и пресмята сумарното им време във формат минути:секунди;.
            //Секундите да се изведат с водеща нула vij uslovieto. Примери:
            //Подсказка:
            //Сумирайте трите числа и получете резултата в секунди. Понеже 1 минута = 60 секунди, ще трябва да
            //изчислите броя минути и броя секунди в диапазона от 0 до 59.
            //Ако резултатът е между 0 и 59, отпечатайте 0 минути + изчислените секунди.
            //Ако резултатът е между 60 и 119, отпечатайте 1 минута + изчислените секунди минус 60.
            //Ако резултатът е между 120 и 179, отпечатайте 2 минути + изчислените секунди минус 120.
            //Ако секундите са по-малко от 10, изведете водеща нула преди тях.
        }
    }
}
