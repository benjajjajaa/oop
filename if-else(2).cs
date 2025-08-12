using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB3 //BEN JUSTIN Z. ESPIRITU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());           
            if ( age>= 18)
            {
                Console.WriteLine($"You are an adult");
            }
            else 
            {
                Console.WriteLine($"You are a teen");
               
            }
                 Console.ReadKey();
        }
    }
}
