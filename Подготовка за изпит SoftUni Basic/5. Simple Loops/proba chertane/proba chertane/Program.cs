using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba_chertane
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(new string(' ', n-j));
                    Console.Write("* ");
                    Console.Write(new string('*', j - 1));
                }
                Console.WriteLine();
            }

           // #region sreda
           // for (int i = 1; i <= n; i++)
           // {
           //     Console.Write("* ");
           //
           // }
           // #endregion


        }
    }
}
