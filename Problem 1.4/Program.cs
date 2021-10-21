using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;

            Console.WriteLine("Please enter a letter: ");
            letter = Convert.ToChar(Console.ReadLine().ToLower());

            if (letter == 'a' || letter == 'e' ||
                letter == 'i' || letter == 'o' ||
                letter == 'u') 
            {
                Console.WriteLine(letter + " is a vowel");
            }

            else
            {
                Console.WriteLine(letter + " is a consonant");
            }

            Console.ReadLine();
        }
    }
}
