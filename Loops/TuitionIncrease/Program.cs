using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables for the original tuition, the percentage increase, and the amount of years
            double tuition = 12000;
            double percent = 0.05;
            const int years = 7;

            //use a for loop to output the tuition until the 7 years are over
            for (int i = 1; i <= years; i++)
            {
                //create a variable that calculates the new tuition
                double newtuition = tuition + (percent * tuition);
                //output the new tuition as a currency after each year
                Console.WriteLine($"The tuition after year {i} will be {newtuition.ToString("C0")}.");
                //set the tuition equal to the new one for each year
                tuition = newtuition;
            }

            Console.ReadKey();
        }
    }
}