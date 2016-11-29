using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            if (name.Equals("stop"))
            {
                return;
            }
            var email = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (!name.Equals("stop"))
            {
                string[] emailParts = email.Split('.').ToArray();

                GetEmails(name, email, emails, emailParts);

                name = Console.ReadLine();
                if (name.Equals("stop"))
                {
                    break;
                }
                email = Console.ReadLine();
            }
            PrintEmails(emails);
        }

        private static void GetEmails(string name, string email, Dictionary<string, string> emails, string[] emailParts)
        {
            if (!emailParts.Contains("us") && !emailParts.Contains("uk"))
            {
                emails[name] = email;
            }
        }

        private static void PrintEmails(Dictionary<string, string> emails)
        {
            foreach (var pair in emails)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
