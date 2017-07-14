using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_tochki
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = int.Parse(Console.ReadLine());
            double bonus = 0;
            


            if (chislo <= 100)
            {
                Console.WriteLine("Bonus tochkite sa: {0}", bonus +=5);  
            }
            else if (chislo <= 999)
            {
                Console.WriteLine("Bonus tochkite sa +20%: {0}", bonus = (chislo*0.2));
            }
            
            else if (chislo >= 1000)
            {
                Console.WriteLine("Bonus tochkite sa +10%: {0}", bonus = (chislo*0.1));
            }
            
            if (chislo % 2 == 0) // samo if !!! za da go izpulnqva pri vs sluchai !!
            {
                Console.WriteLine("Dopulnitelna bonus 1 tochka za chetno chislo:", bonus +=1);
            }
            Console.WriteLine("Sumata ot bonusite: {0}", bonus);

        }
    }
}
