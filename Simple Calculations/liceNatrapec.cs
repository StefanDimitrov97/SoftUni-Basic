using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstiPresmqtaniqHristo1
{
    class liceNatrapec
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi purvata osnova: ");
        double b1 = double.Parse(Console.ReadLine()); // osnova

        Console.Write("Vuvedi vtorata osnova: ");
        double b2 = double.Parse(Console.ReadLine());  // osnova

        Console.Write("Vuvedi visochinata: ");
        double h = double.Parse(Console.ReadLine()); // visochina

        Console.Write("Liceto e ravno na: ");
        double lice = (b1 + b2) * h / 2;
        Console.WriteLine(lice);
        
        // Лице на трапец
        //Напишете програма, която чете от конзолата три числа b1, b2 и h и пресмята лицето на трапец с основи b1 и
        //b2 и височина h. Формулата за лице на трапец е (b1 + b2) * h / 2.
        //На фигурата по-долу е показан трапец със страни 8 и 13 и височина 7. Той има лице (8 + 13) * 7 / 2 = 73.5.
        }
    }
}
