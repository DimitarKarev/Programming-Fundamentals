using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> words = GetShortWords(separators);

            Console.WriteLine(string.Join(", ", words));

        }

        private static List<string> GetShortWords(char[] separators)
        {
            return Console.ReadLine().ToLower()
                                     .Split(separators)
                                     .Where(w => w != "")
                                     .Where(w => w.Length < 5)
                                     .OrderBy(w => w).Distinct()
                                     .ToList();
        }
    }
}
