using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitSymbols = { ',', ' ', '?', '!', '.' };
            string[] words = Console.ReadLine().Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes = new List<string>();

            GetPalindromes(words, palindromes);

            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", palindromes));
        }

        private static void GetPalindromes(string[] words, List<string> palindromes)
        {
            for (int word = 0; word < words.Length; word++)
            {
                string myString = words[word];
                bool palindrome = getStatus(myString);
                if (palindrome)
                {
                    palindromes.Add(myString);
                }
            }
        }

        public static bool getStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
