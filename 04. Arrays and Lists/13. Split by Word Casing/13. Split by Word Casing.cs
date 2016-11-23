using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var words = Console.ReadLine().Split(separators).ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var item in words)
            {
                int countUpper = 0;
                int countLower = 0;
                int countMixed = 0;

                CountUpperLowerMixedCases(item, ref countUpper, ref countLower, ref countMixed);
                GroupWords(lowerCase, mixedCase, upperCase, item, countUpper, countLower, countMixed);

            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }

        private static int CountUpperLowerMixedCases(string item, ref int countUpper, ref int countLower, ref int countMixed)
        {
            int i;
            for (i = 0; i < item.Length; i++)
            {
                if (!char.IsLetter(item[i]))
                {
                    countMixed++;
                    break;
                }
                else if (char.IsUpper(item[i])) countUpper++;
                else if (char.IsLower(item[i])) countLower++;
            }
            return i;
        }

        private static void GroupWords(List<string> lowerCase, List<string> mixedCase, List<string> upperCase, string item, int countUpper, int countLower, int countMixed)
        {
            if (countMixed > 0) mixedCase.Add(item);
            else if (countUpper == 0 && countLower > 0) lowerCase.Add(item);
            else if (countUpper > 0 && countLower == 0) upperCase.Add(item);
            else if (item != "") mixedCase.Add(item);
        }
    }
}
