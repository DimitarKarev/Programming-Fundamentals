using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "end")
            {
                string replaced = Replace(text);

                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }

        private static string Replace(string text)
        {
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";
            string replaced = Regex.Replace(text, pattern, replace);

            return replaced;
        }
    }
}
