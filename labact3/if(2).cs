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


            Console.Write("Enter your BMI: ");
            double BMI = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("----------------------------------");


            if (BMI < 18.5)
            {
                Console.WriteLine("You are underweight");
            }
            if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("You are normal");
            }
            if (BMI >= 25)
            {
                Console.WriteLine("You are overweight");
            }


            Console.ReadLine();
        }
    }
}
