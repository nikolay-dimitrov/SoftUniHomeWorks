using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem1Persons
{
    class Person
    {
       
        private const string EmailPattern = @"(?<=\s|^)([A-Za-z0-9]*(?:[_.-][A-Za-z0-9]*)*@(?:[A-Za-z]*\-?[A-Za-z]*\.)*[A-Za-z]*\-?[A-Za-z]*)\b";

        private string name;
        private int age;
        private string email;

        
        public Person(string name, int age) 
            : this(name, age, null)
        {
            
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("age", "Age should be an integer between 1 and 100 inclusive.");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null && !Regex.IsMatch(value, EmailPattern))
                {
                    throw new ArgumentException(@"Email should contain ""@""", "email");
                }

                this.email = value;
            }
        }

        
        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nEmail Address: {2}",
                this.Name,
                this.Age,
                this.Email ?? "not set");
        }
    }
}
