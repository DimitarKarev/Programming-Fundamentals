using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitSymbols = new char[] { ' ', ',' };
            string[] bannedWords = Console.ReadLine().Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            text = FilterText(bannedWords, text);

            Console.WriteLine(text);
        }

        private static string FilterText(string[] bannedWords, string text)
        {
            foreach (var banWord in bannedWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }

            return text;
        }
    }
}
