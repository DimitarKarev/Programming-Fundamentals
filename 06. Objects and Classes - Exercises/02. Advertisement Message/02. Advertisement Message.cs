using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesNumber = int.Parse(Console.ReadLine());

            string[] phrases, events, authors, towns;

            SetInputValues(out phrases, out events, out authors, out towns);

            Random number = new Random();

            PrintMessages(messagesNumber, phrases, events, authors, towns, number);
        }

        private static void SetInputValues(out string[] phrases, out string[] events, out string[] authors, out string[] towns)
        {
            phrases = new string[] {
                "Excellent product.","Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            events = new string[] {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            authors = new string[] {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            towns = new string[] {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
        }

        private static void PrintMessages(int messagesNumber, string[] phrases, string[] events, string[] authors, string[] towns, Random number)
        {
            for (int message = 0; message < messagesNumber; message++)
            {
                int phraseIndex, eventIndex, authorIndex, townIndex;

                GetRandomValues(phrases, events, authors, towns, number, out phraseIndex, out eventIndex, out authorIndex, out townIndex);

                Console.WriteLine(phrases[phraseIndex] + " " + events[eventIndex] + " " + authors[authorIndex] + " - " + towns[townIndex]);
            }
        }

        private static void GetRandomValues(string[] phrases, string[] events, string[] authors, string[] towns, Random number, out int phraseIndex, out int eventIndex, out int authorIndex, out int townIndex)
        {
            phraseIndex = number.Next(0, phrases.Length);
            eventIndex = number.Next(0, events.Length);
            authorIndex = number.Next(0, authors.Length);
            townIndex = number.Next(0, towns.Length);
        }
    }
}
