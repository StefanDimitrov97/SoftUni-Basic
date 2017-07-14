using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
           
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > maxNumber)
                {
                    maxNumber = num;
                }

            }

                Console.WriteLine(maxNumber);

        }
    }
}
