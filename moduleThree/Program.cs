using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduleThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Rinat";
            byte age = 22;
            bool pet = true;
            float shoeSize = 41.5F;

            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"My age is {age}");
            Console.WriteLine($"Do i have a pet? That's {pet}");
            Console.WriteLine($"My shoe size is {shoeSize}");

            Console.ReadKey();
        }
    }
}
