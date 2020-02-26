using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I337Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to enter a sentence
            Console.WriteLine("Input a sentence");
            string sentence = Console.ReadLine().ToUpper();

            //convert the sentence into I337
            sentence = sentence.Replace('A', '@').Replace('E', '3').Replace("H", "|-|").Replace('S', '$').Replace('T', '7').Replace("U", "|_|");

            //create a variable that is the last character in the sentence
            char last = sentence[sentence.Length - 1];

            //use an if statement to add an ! if there isn't one already
            if (last == '!')
            {
                Console.WriteLine(sentence);
            }
            else
            {
                Console.WriteLine($"{sentence}!");
            }

            Console.ReadKey();
        }
    }
}
