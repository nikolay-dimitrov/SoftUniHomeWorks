using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7Phonebook
{
    class Problem7Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> phoneBook = new Dictionary<string,string>();
            string input = Console.ReadLine();
            while (input!= "search")
            {
                string name = input.Split('-')[0];
                string phoneNumber = input.Split('-')[1];

                if (phoneBook.Keys.Contains(name))
                {
                    phoneBook[name] = phoneBook[name]  + " , " + phoneNumber;

                }
                else
                {
                    phoneBook.Add(name, phoneNumber);
                }
                input = Console.ReadLine();
                while (! input.Equals(string.Empty))
                {
                    if (phoneBook.Keys.Contains(input))
                    {
                        Console.WriteLine("{0} -> {1}",input,phoneBook[input]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input);
                    }
                    input = Console.ReadLine();
                }
            }
        }
    }
}
