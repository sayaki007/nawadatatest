using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawaDataTest.Test
{
    public class SortCharacter
    {
        public string procVowel(string param)
        {
            string vowels = "aeiou";
            string result = "";

            foreach (char c in param.ToLower())
            {
                if (vowels.Contains(c))
                {
                    result += c;
                }
            }

            return result;
        }

        public string procConsonant(string param)
        {
            string vowels = "aeiou";
            string result = "";

            foreach (char c in param.ToLower())
            {
                if (!vowels.Contains(c) && Char.IsLetter(c))
                {
                    result += c;
                }
            }

            return result;
        }

        public void Sorting()
        {
            Console.Write("Input one line of words (S) : ");
            string input = Console.ReadLine();

            string charVowel = procVowel(input);
            string charConsonant = procConsonant(input);

            Console.WriteLine("Vowel Characters : ");
            Console.WriteLine(charVowel);
            Console.WriteLine("Consonant Characters : ");
            Console.WriteLine(charConsonant);
        }
    }
}
