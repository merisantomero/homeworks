using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to input a sentence
            Console.WriteLine("Input a sentence.");
            string sentence = Console.ReadLine();

            //set variables for the amount of variables and consonants equal to zero
            int vowels = 0;
            int consonants = 0;

            //use a foreach loop that goes through each of the characters in the sentence
            foreach (char letter in sentence.ToLower())
            {
                //use an if statement to see if the letter is a vowel
                if ("aeiou".Contains(letter))
                {
                    vowels = vowels + 1;
                }
                else
                {
                    consonants = consonants + 1;
                }
            }

            Console.WriteLine($"There were {vowels} vowels in the sentence.");
            Console.WriteLine($"There were {consonants} consonants in the sentence.");

            Console.ReadKey();
        }
    }
}
