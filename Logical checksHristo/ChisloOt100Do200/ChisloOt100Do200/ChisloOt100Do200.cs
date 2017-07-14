using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisloOt100Do200
{
    class ChisloOt100Do200
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else
                Console.WriteLine("Between 100 and 200");



        }
    }
}
