using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//an if statement can be followed by an optional else satement,
//which executes when the boolean expression is false.

namespace LAB3 //BEN JUSTIN Z. ESPIRITU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // check the number if its divisible by 2, if yes its even.
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else //if not it odd.
            {
                Console.WriteLine($"{number} is an odd number.");
                Console.ReadKey();
            }
        }
    }
}
