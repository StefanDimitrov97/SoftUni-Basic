using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdfsfsd
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double razstoqnieMetri = double.Parse(Console.ReadLine());
            var vremeSecZa1metur = double.Parse(Console.ReadLine());

            double prepluvanoRazstoqnie = razstoqnieMetri * vremeSecZa1metur;
            double dobavenoVreme = Math.Round((razstoqnieMetri / 15)) * 12.5; // !!!!!!!!???????????

            double allTime = prepluvanoRazstoqnie + dobavenoVreme; //
            var razlikataVrecordite = Math.Abs(allTime - recordSec);

            if (allTime <= recordSec)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", allTime);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", razlikataVrecordite);
            }


        }
    }
}

        }
    }
}
