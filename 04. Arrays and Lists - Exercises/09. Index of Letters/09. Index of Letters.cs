using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var alphabet = new char[26];
            SetAlphabetValues(alphabet);
            PrintIndex(input, alphabet);
        }
        
        private static void SetAlphabetValues(char[] alphabet)
        {
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
        }

        private static void PrintIndex(char[] input, char[] alphabet)
        {
            foreach (var item in input)
            {
                Console.WriteLine($"{item} -> {Array.IndexOf(alphabet, item)}");
            }
        }
    }
}
