using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_random_numbers_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int min, max, die1, die2, min2, max2;
            string yn1, yn2, yn3;
            yn1 = "Y";
            yn2 = "Y";
            

            
            Console.WriteLine("Please pick a min & max number.");
            min = Convert.ToInt32(Console.ReadLine());
            max = Convert.ToInt32(Console.ReadLine());

            if (min < max)
            {
                while (yn1 == "Y" || yn1 == "y")
                {
                    Console.WriteLine("You got " + generator.Next(min, max) + ". Would you like a new number? (Y/N)?");
                    yn1 = Console.ReadLine();
                }
            }
            else if (max < min)
            {
                while (yn1 == "Y" || yn1 == "y")
                {
                    Console.WriteLine("You got " + generator.Next(max, min) + ". Would you like a new number? (Y/N)?");
                    yn1 = Console.ReadLine();
                }
            }
            while (yn2 == "Y" || yn2 == "y")
            {
                die1 = generator.Next(1, 7);
                die2 = generator.Next(1, 7);
                Console.WriteLine("You rolled some dice. The first dice reads " + die1 + ", and the second dice reads " + die2 + ". Together they equal " + (die1 + die2) + ". Do you want to roll again? (Y/N)");
                yn2 = Console.ReadLine();
            }
            Console.WriteLine(generator.NextDouble());
            Console.ReadLine();
        }
    }
}
