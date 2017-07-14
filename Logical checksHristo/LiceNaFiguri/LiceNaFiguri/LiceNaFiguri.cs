using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceNaFiguri
{
    class LiceNaFiguri
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                double side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Lice: {0}", Math.Round(side1*side1),3);
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Lice: {0}", Math.Round(side1*side2),3);
            }
            else if (figure == "circle")
            {
                double side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Lice: {0}", Math.Round((side1 * 2) * 3.14),3);
            }
            else if (figure == "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Lice: {0}", Math.Round((side1 * side2) / 2),3);
            }
            //  V JUGLE DAVA POVECHE TOCHKI AKO NE SE ZAKRUGLQ DO 3TO CHISLO 
            // A V USLOVIETO PISHE CHE TRQBVA?
        }
    }
}
