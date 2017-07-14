using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string napitka = Console.ReadLine();
            string city = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());

            if (napitka == "coffee" && city == "Sofia")
            {
                Console.WriteLine(kolichestvo * 0.50);
            }
            else if (napitka == "coffee" && city == "Plovdiv")
            {
                Console.WriteLine(kolichestvo * 0.40); 
            }
            else if (napitka == "coffee" && city == "Varna")
            {
                Console.WriteLine(kolichestvo * 0.45);
            }
            else if (napitka == "water" && city == "Sofia")
            {
                Console.WriteLine(kolichestvo * 0.80);
            }
            else if (napitka == "water" && city == "Plovdiv")
            {
                Console.WriteLine(kolichestvo * 0.70); 
            }
            else if (napitka == "water" && city == "Varna")
            {
                Console.WriteLine(kolichestvo * 0.70);  
            }
            else if (napitka == "beer" && city == "Sofia")
            {
                Console.WriteLine(kolichestvo * 1.20);
            }
            else if (napitka == "beer" && city == "Plovdiv")
            {
                Console.WriteLine(kolichestvo * 1.15);  
            }
            else if (napitka == "beer" && city == "Varna")
            {
                Console.WriteLine(kolichestvo * 1.10);
            }
            else if (napitka == "sweets" && city == "Sofia")
            {
                Console.WriteLine(kolichestvo * 1.45);
            }
            else if (napitka == "sweets" && city == "Plovdiv")
            {
                Console.WriteLine(kolichestvo * 1.30);
            }
            else if (napitka == "sweets" && city == "Varna")
            {
                Console.WriteLine(kolichestvo * 1.35);
            }
            else if (napitka == "peanuts" && city == "Sofia")
            {
                Console.WriteLine(kolichestvo * 1.60);
            }
            else if (napitka == "peanuts" && city == "Plovdiv")
            {
                Console.WriteLine(kolichestvo * 1.50);
            }
            else if (napitka == "peanuts" && city == "Varna")
            {
                Console.WriteLine(kolichestvo * 1.55);
            }
        }
    }
}
