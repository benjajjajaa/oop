using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labact3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade: ");
            int score = Convert.ToInt32(Console.ReadLine());


            if (score >= 90)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Your Grade is: A");
            }


            if (score < 90 && score >= 80)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Your Grade is: B");
            }


            if (score < 80 && score >= 70)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Your Grade is: C");
            }


            if (score < 70)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Your Grade is: F");
            }
            Console.ReadKey();
        }
    }
}
 