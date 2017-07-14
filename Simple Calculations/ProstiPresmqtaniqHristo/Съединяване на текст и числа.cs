using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstiPresmqtaniqHristo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = Console.ReadLine();
            var town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2} years old person from {3}", firstName, lastName, age, town);


            //Напишете C# програма, която прочита от конзолата име, фамилия, възраст и град и печата съобщение от
            //следния вид: “You are &lt;firstName&gt; &lt;lastName&gt;, a &lt;age&gt;-years old person from &lt;town&gt;”.
        }
    }
}
