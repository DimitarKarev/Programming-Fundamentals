using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            var command = input[0];

            while (!command.Equals("END"))
            {
                if (command.Equals("A"))
                {
                    AddNewContact(input, phonebook);
                }
                else if (command.Equals("S"))
                {
                    PrintContact(input, phonebook);
                }
                else if (command.Equals("ListAll"))
                {
                    ListAllContacts(phonebook);
                }
                input = Console.ReadLine().Split().ToArray();
                command = input[0];
            }
        }

        
        private static void AddNewContact(string[] input, SortedDictionary<string, string> phonebook)
        {
            string contact = input[1];
            var number = input[2];

            phonebook[contact] = number;
        }

        private static void PrintContact(string[] input, SortedDictionary<string, string> phonebook)
        {
            string contact = input[1];
            if (phonebook.ContainsKey(contact))
            {
                Console.WriteLine("{0} -> {1}", contact, phonebook[contact]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", contact);
            }

        }
        private static void ListAllContacts(SortedDictionary<string, string> phonebook)
        {
            foreach (var contact in phonebook)
            {
                Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
            }
        }
    }
}
