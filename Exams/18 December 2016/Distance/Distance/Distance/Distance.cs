using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            double KmInHours = double.Parse(Console.ReadLine());
            double firstTimeInMin = double.Parse(Console.ReadLine());
            double secondTimeInMin = double.Parse(Console.ReadLine());
            double ThirtTimeInMin = double.Parse(Console.ReadLine());
            double RazstSPurvonachalnaSkorost = 0;
            double SledUvelichenie = 0;
            double SledUvelichenie1 = 0;
            double SledNamalenie = 0;
            double Obshto = 0;
            RazstSPurvonachalnaSkorost = KmInHours * (firstTimeInMin / 60);
            SledUvelichenie = KmInHours + (KmInHours * 0.1);
            SledUvelichenie1 = SledUvelichenie * (secondTimeInMin / 60);
            SledNamalenie = (SledUvelichenie - (SledUvelichenie * 0.05)) * (ThirtTimeInMin / 60);
            Obshto = RazstSPurvonachalnaSkorost + SledUvelichenie1 + SledNamalenie;
            Console.WriteLine("{0:f2}", Obshto);
        }
    }
}
