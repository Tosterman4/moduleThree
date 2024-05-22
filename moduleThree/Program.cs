using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static moduleThree.daysOfWeek;

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

            dniNedeli dni = (dniNedeli) int.Parse(Console.ReadLine());

            Console.WriteLine($"Your favourite day of week is {dni}");


            Console.ReadKey();
        }
    }
}
