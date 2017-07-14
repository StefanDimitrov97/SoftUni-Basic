using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            var inSideX = ((x > x1) && (x < x2));
            var inSideY = ((y >= y1) && (y <= y2));
            
            // && moje da e i || ako ne trugne!!  // stana taka pri border

            var outSideX = ((x < x1) && (x > x2));
            var outSideY = ((y < y1) && (y > y2));

            var borderX = (((x == x1) || (x == x2)));
            var borderY = (((y == y1) || (y == y2)));

            if ((x == x1 || x == x2) && (y >= y1 && y <= y2)) ||
                (y == y1 || y == y2) && (x>= x1 && x <= x2))      
	{
		 Console.WriteLine("Border");
	}
            else
            {
                Console.WriteLine("Inside/Outside");
            }
        }
    }
}
