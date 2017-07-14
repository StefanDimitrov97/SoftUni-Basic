using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string sex = Console.ReadLine();
            double numberOfStudents = double.Parse(Console.ReadLine());
            double numberOfNights = double.Parse(Console.ReadLine());
            double money = 0;

            if (season == "Winter" && (sex == "boys" || sex == "girls"))
            {
                money += 9.60;
            }
            else if (season == "Winter" && (sex == "mixed"))
            {
                money += 10;
            }
            else if (season == "Spring" && (sex == "boys" || sex == "girls"))
            {
                money += 7.20;
            }
            else if (season == "Spring" && (sex == "mixed"))
            {
                money += 9.50;
            }
            else if (season == "Summer" && (sex == "boys" || sex == "girls"))
            {
               money += 15; 
            }
            else if (season == "Summer" && (sex == "mixed"))
            {
                money += 20;
            }


            #region  money
            if (numberOfStudents >= 50)
            {
                money = money - (money * 0.5);
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                 money = money - (money * 0.15);
            }
            else if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                 money = money - (money * 0.05);
            }
            #endregion

            if (season == "Winter" && sex == "girls")
            {
                Console.WriteLine("Gymnastics");
            }
            else if (season == "Spring" && sex == "girls")
            {
                Console.WriteLine("Athletics");
            }
            else if (season == "Summer" && sex == "girls")
            {
                Console.WriteLine("Volleyball");
            }
            else if (season == "Winter" && sex == "boys")
            {
                Console.WriteLine("Judo");
            }
            else if (season == "Spring" && sex == "boys")
            {
                Console.WriteLine("Tennis"); 
            }
            else if (season == "Summer" && sex == "boys")
            {
                Console.WriteLine("Football"); 
            }
            else if (season == "Winter" && sex == "mixed")
            {
                Console.WriteLine("Ski");
            }
            else if (season == "Spring" && sex == "mixed")
            {
                Console.WriteLine("Cycling"); 
            }
            else if (season == "Summer" && sex == "mixed")
            {
                Console.WriteLine("Swimming");
            }

            Console.Write("{0:f2} lv.", numberOfNights * money);



        }
    }
}
