using HumanStudentWorker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem1HumanStudentAndWorker.Models
{
    class Student : Human
    {
        private readonly List<string> facNumber = new List<string>();

        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set 
            {
                if (!Regex.IsMatch(value,@"^[a-zA-Z\d]{5,10}$"))
                {
                    throw new ArgumentException("Faulty number should contain only letters and numbers and length in the range [5...10]!");
                }

                if (facNumber.Contains(value))
                {
                    throw new DuplicateNameException("A student withj this faculty number already exists!");
                }

                this.facultyNumber = value;
                facNumber.Add(value);
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Faculty number: {0}\n", this.FacultyNumber);
        }
    }
}

