using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate two random numbers, each between 1 and 50
            Random rand = new Random();
            int rand1 = rand.Next(1, 50);
            int rand2 = rand.Next(1, 50);

            //display the numbers in the console
            Console.WriteLine($"{rand1} + {rand2}?");
            double answer = Convert.ToDouble(Console.ReadLine());

            //create a variable for the correct answer
            double correct = rand1 + rand2;

            //use a while loop to prompt the user to try again until they are correct
            while (answer != correct)
            {
                Console.WriteLine("Sorry, please try again.");
                double guess = Convert.ToDouble(Console.ReadLine());
                //set the user's response equal to their last one so that it will stop when they are correct
                answer = guess;

                //use an if statement to congratulate them when they are correct
                if (guess == correct)
                {
                    Console.WriteLine("Congrats! You got the right answer.");
                    Console.ReadKey();
                }
            }

            Console.ReadKey();
        }
    }
}
