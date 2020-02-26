using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to input their grade percentages for their Accounting, Marketing, Economics, and MIS courses
            Console.WriteLine("Input your Accounting grade percentage.");
            double acct = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your Marketing grade percentage.");
            double mkt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your Economics grade percentage.");
            double econ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input your MIS grade percentage.");
            double mis = Convert.ToDouble(Console.ReadLine());

            //output what letter grade they earned for each course & assign number
            if (acct >= 90)
            {
                Console.WriteLine("Your letter grade for Accounting is A.");
                acct = 4;
            }
            else if (acct >= 80)
            {
                Console.WriteLine("Your letter grade for Accounting is B.");
                acct = 3;
            }
            else if (acct >= 70)
            {
                Console.WriteLine("Your letter grade for Accounting is C.");
                acct = 2;
            }
            else if (acct >= 60)
            {
                Console.WriteLine("Your letter grade for Accounting is D.");
                acct = 1;
            }
            else
            {
                Console.WriteLine("Your letter grade for Accounting is F.");
                acct = 0;
            }
            if (mkt >= 90)
            {
                Console.WriteLine("Your letter grade for Marketing is A.");
                mkt = 4;
            }
            else if (mkt >= 80)
            {
                Console.WriteLine("Your letter grade for Marketing is B.");
                mkt = 3;
            }
            else if (mkt >= 70)
            {
                Console.WriteLine("Your letter grade for Marketing is C.");
                mkt = 2;
            }
            else if (mkt >= 60)
            {
                Console.WriteLine("Your letter grade for Marketing is D.");
                mkt = 1;
            }
            else
            {
                Console.WriteLine("Your letter grade for Marketing is F.");
                mkt = 0;
            }
            if (econ >= 90)
            {
                Console.WriteLine("Your letter grade for Economics is A.");
                econ = 4;
            }
            else if (econ >= 80)
            {
                Console.WriteLine("Your letter grade for Economics is B.");
                econ = 3;
            }
            else if (econ >= 70)
            {
                Console.WriteLine("Your letter grade for Economics is C.");
                econ = 2;
            }
            else if (econ >= 60)
            {
                Console.WriteLine("Your letter grade for Economics is D.");
                econ = 1;
            }
            else
            {
                Console.WriteLine("Your letter grade for Economics is F.");
                econ = 0;
            }
            if (mis >= 90)
            {
                Console.WriteLine("Your letter grade for MIS is A.");
                mis = 4;
            }
            else if (mis >= 80)
            {
                Console.WriteLine("Your letter grade for MIS is B.");
                mis = 3;
            }
            else if (mis >= 70)
            {
                Console.WriteLine("Your letter grade for MIS is C.");
                mis = 2;
            }
            else if (mis >= 60)
            {
                Console.WriteLine("Your letter grade for MIS is D.");
                mis = 1;
            }
            else
            {
                Console.WriteLine("Your letter grade for MIS is F.");
                mis = 0;
            }

            //create a variable that calculates their GPA
            double GPA = (acct + mkt + econ + mis) / 4;

            //output their overall GPA for the semester
            Console.WriteLine($"Your overall GPA for the semester is {GPA}");

            Console.ReadKey();
        }
    }
}
