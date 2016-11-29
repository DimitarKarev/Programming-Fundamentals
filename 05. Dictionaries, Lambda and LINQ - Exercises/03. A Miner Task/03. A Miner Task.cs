using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> element = new Dictionary<string, int>();
            string input = Console.ReadLine();
            if (input == "stop")
            {
            return;
            }
            int quantity = int.Parse(Console.ReadLine());

            while (true)
            {
                GetElementAndQuantity(element, input, quantity);

                input = Console.ReadLine();

                if (input.Equals("stop"))
                {
                    break;
                }

                quantity = int.Parse(Console.ReadLine());
            }
            foreach (var item in element)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }

        private static void GetElementAndQuantity(Dictionary<string, int> element, string input, int quantity)
        {
            if (element.ContainsKey(input))
            {
                element[input] += quantity;
            }
            else
            {
                element.Add(input, quantity);
            }
        }
    }
}
