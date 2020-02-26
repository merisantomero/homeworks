using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to input their lucky number
            Console.WriteLine("Input your lucky number.");
            string lucky = Console.ReadLine();

            //create a variable as a true/false input user's response output luckynumber as an integer
            bool number = Int32.TryParse(lucky, out int luckynumber);

            //use an if statement for if the user's response is a valid number
            if (number == false)
            {
                Console.WriteLine($"Sorry, but I am unable to run the FizzBuzz process due to {luckynumber} not being a valid number.");
                Console.ReadKey();
            }
            else
            {
                //use an if statement for if the number is divisible by 3 or 5, etc
                if (luckynumber % 3 == 0 && luckynumber % 5 == 0)
                {
                    Console.WriteLine($"{luckynumber} FizzBuzz");
                }
                else if (luckynumber % 3 == 0)
                {
                    Console.WriteLine($"{luckynumber} Fizz");
                }
                else if (luckynumber % 5 == 0)
                {
                    Console.WriteLine($"{luckynumber} Buzz");
                }
                else
                {
                    Console.WriteLine(luckynumber);
                }
                
                Console.ReadKey();
            }
        }
    }
}
