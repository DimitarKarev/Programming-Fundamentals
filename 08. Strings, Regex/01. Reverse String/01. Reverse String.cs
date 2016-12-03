using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] reversedWord = ReverseString(word);

            Console.WriteLine(string.Join("", reversedWord));
        }

        private static char[] ReverseString(string word)
        {
            char[] reversedWord = word.ToCharArray();
            Array.Reverse(reversedWord);
            return reversedWord;
        }
    }
}
