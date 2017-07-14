using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double prodajbi = double.Parse(Console.ReadLine());
            if (city == "Sofia")
            {
                if (prodajbi >= 0 && prodajbi <= 500)
                {
                    Console.WriteLine(prodajbi * 0.05);
                }
                else if (prodajbi > 500 && prodajbi <= 1000)
                {
                    Console.WriteLine(prodajbi * 0.07);
                }
                else if (prodajbi > 1000 && prodajbi <= 10000)
                {
                    Console.WriteLine(prodajbi * 0.08);
                }
                else if (prodajbi > 10000)
                {
                    Console.WriteLine(prodajbi * 0.12);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (prodajbi >= 0 && prodajbi <= 500)
                {
                    Console.WriteLine(prodajbi * 0.045);
                }
                else if (prodajbi > 500 && prodajbi <= 1000)
                {
                    Console.WriteLine(prodajbi * 0.075);
                }
                else if (prodajbi > 1000 && prodajbi <= 10000)
                {
                    Console.WriteLine(prodajbi * 0.1);
                }
                else if (prodajbi > 10000)
                {
                    Console.WriteLine(prodajbi * 0.13);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (prodajbi >= 0 && prodajbi <= 500)
                {
                    Console.WriteLine(prodajbi * 0.055);
                }
                else if (prodajbi > 500 && prodajbi <= 1000)
                {
                    Console.WriteLine(prodajbi * 0.08);
                }
                else if (prodajbi > 1000 && prodajbi <= 10000)
                {
                    Console.WriteLine(prodajbi * 0.12);
                }
                else if (prodajbi > 10000)
                {
                    Console.WriteLine(prodajbi * 0.145);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
