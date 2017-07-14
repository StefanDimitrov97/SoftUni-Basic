using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrushtanieSporedVuzrastIpol
{
    class ObrushtanieSporedVuzrastIpol
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine();

            if ((sex == "m") && (years >= 16))
            {
                Console.WriteLine("Mr.");
            }
            else if ((sex == "m") && (years < 16))
	{
        Console.WriteLine("Master");
	}
            if ((sex == "f") && (years >= 16))
            {
                Console.WriteLine("Ms.");
            }
            else if ((sex == "f") && (years < 16))
            {
                Console.WriteLine("Miss");
            }


        }
    }
}
