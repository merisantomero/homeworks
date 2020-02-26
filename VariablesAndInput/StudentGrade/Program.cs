using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to enter their first name, last name, student id number, and overall grade percentages
            Console.WriteLine("What is your first name? >>");
            string first = Console.ReadLine();
            Console.WriteLine("What is your last name? >>");
            string last = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            double id = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for homeworks? >>");
            double homework = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participations? >>");
            double participation = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes? >>");
            double quizzes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your percentage grade for the midterm? >>");
            double midterm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your percentage grade for the final? >>");
            double final = Convert.ToDouble(Console.ReadLine());

            //create a variable as a real number that calculates their final grade
            double grade = (0.25 * homework + 0.1 * participation + 0.1 * quizzes + 0.25 * midterm + 0.3 * final) / 100;

            Console.WriteLine($"{first} {last} ({id}), your final grade is {grade.ToString("P")}.");
            Console.ReadKey();
        }
    }
}
