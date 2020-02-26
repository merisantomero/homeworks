using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToBurn
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to input how many calories they wish to burn
            Console.WriteLine("How many calories do you wish to burn in this workout session? >>");
            double calories = Convert.ToDouble(Console.ReadLine());

            //create a variable for the calories burned each minute, how many minutes have passed, and the calories burned
            const double calspermin = 3.9;
            int min = 1;
            double calsburned;

            //use a do loop to calculate how many calories are burned each minute until it reaches the user's response
            do
            {
                min = min + 1;
                calsburned = min * calspermin;
                Console.WriteLine($"After {min} minutes, you have burned {calsburned}.");
            } while (calsburned <= calories);

            Console.ReadKey();
        }
    }
}
