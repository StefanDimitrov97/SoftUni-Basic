using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProverkaZaOtlichnaOcenka
{
    class ProverkaZaOtlichnaOcenka
    {
        static void Main(string[] args)
        {
            double ocenka = double.Parse(Console.ReadLine());

            if (ocenka >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
