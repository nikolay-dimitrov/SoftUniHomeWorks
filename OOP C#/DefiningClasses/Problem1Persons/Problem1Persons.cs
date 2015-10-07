using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Persons
{
    class Problem1Persons
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a name: ");
            var name = Console.ReadLine();
            Console.Write("Please, enter a a value for age: ");
            var age = ReadAge(); 
            Console.Write("Please, enter an email: ");
            var email = Console.ReadLine();

          
            try
            {
                var person1 = new Person(name, age);
                Console.WriteLine(person1);

               
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error: {0}\n{1}", e.GetType(), e.Message);
            }
        }

        public static int ReadAge()
        {
            var input = Console.ReadLine();

            try
            {
                var num = int.Parse(input);

                return num;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}\n{1}", e.GetType(), e.Message);
                Console.Write("Please enter a number: ");
                return ReadAge();
            }
        }
    }
}
