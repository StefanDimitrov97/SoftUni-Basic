using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double numberOfNights = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string sex = Console.ReadLine();
            double smetki = 0;

            #region Сметки за брой ученици по пол умножени по цената за въведеният сезон

            if ((season == "Winter") && (sex == "girls"))
            {
                smetki = numberOfNights * numberOfStudents * 9.60;
            }
            else if ((season == "Winter") && (sex == "boys"))
            {
                smetki = numberOfNights * numberOfStudents * 9.60;
            }
            else if ((season == "Winter") && (sex == "mixed"))
            {
                smetki = numberOfNights * numberOfStudents * 10;
            }
            else if ((season == "Summer") && (sex == "girls"))
            {
                smetki = numberOfNights * numberOfStudents * 15;
            }
            else if ((season == "Summer") && (sex == "boys"))
            {
                smetki = numberOfNights * numberOfStudents * 15;
            }
            else if ((season == "Summer") && (sex == "mixed"))
            {
                smetki = numberOfNights * numberOfStudents * 20;
            }
            else if ((season == "Spring") && (sex == "girls"))
            {
                smetki = numberOfNights * numberOfStudents * 7.20;
            }
            else if ((season == "Spring") && (sex == "boys"))
            {
                smetki = numberOfNights * numberOfStudents * 7.20;
            }
            else if ((season == "Summer") && (sex == "mixed"))
            {
                smetki = numberOfNights * numberOfStudents * 9.50;
            }
            #endregion


            #region Тип спорт
            if ((season == "Winter") && (sex == "girls"))
            {
                Console.WriteLine("Gymnastics");
            }
            else if ((season == "Winter") && (sex == "boys"))
            {
                Console.WriteLine("Judo");
            }
            else if ((season == "Winter") && (sex == "mixed"))
            {
                Console.WriteLine("Ski");
            }
            else if ((season == "Spring") && (sex == "boys"))
            {
                Console.WriteLine("Tennis");
            }
            else if ((season == "Spring") && (sex == "girls"))
            {
                Console.WriteLine("Athletics");
            }
            else if ((season == "Spring") && (sex == "mixed"))
            {
                Console.WriteLine("Cycling");
            }
            else if ((season == "Summer") && (sex == "boys"))
            {
                Console.WriteLine("Football");
            }
            else if ((season == "Summer") && (sex == "girls"))
            {
                Console.WriteLine("Volleyball");
            }
            else if ((season == "Summer") && (sex == "mixed"))
            {
                Console.WriteLine("Swimming");
            }
            #endregion

            #region Отстъпка
            if (numberOfStudents >= 50)
            {
                smetki = smetki - (smetki * 0.50);
            }
            else if ((numberOfStudents >=20) || (numberOfStudents < 50))
            {
                smetki = smetki - (smetki * 0.15);
            }
            else if ((numberOfStudents >= 10) || (numberOfStudents < 20))
            {
                smetki = smetki - (smetki * 0.05);
            }
            #endregion

            Console.Write("{0:f2} lv" , smetki);
        }

    }
}
