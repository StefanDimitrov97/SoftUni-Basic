using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double currency = double.Parse(Console.ReadLine());
            string vhodna = Console.ReadLine();
            string izhodna = Console.ReadLine();

            if ((vhodna == "USD") && (izhodna == "BGN"))
            {
                Console.WriteLine("{0:f2} BGN", currency * 1.79549);
            }
            else if ((vhodna == "USD") && (izhodna == "EUR"))
            {
                Console.WriteLine("{0:f2} EUR", currency / 1.95583);
            }
            else if ((vhodna == "USD") && (izhodna == "GBP"))
            {
                Console.WriteLine("{0:f2} ", currency / 1.95583);
            }


        }
    }
}
