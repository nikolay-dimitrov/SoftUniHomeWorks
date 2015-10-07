using Problem1ClassStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11StudentsByGroups
{
    class Problem11StudentsByGroups
    {
        static void Main(string[] args)
        {
            var students = new List<Students>();
            students.Add(new Students("Sara", "Mills", "smills0@marketwatch.com", "112314", "02 832 432", new List<int> { 5, 3, 5, 6 }, 2, 25,"HQS"));
            students.Add(new Students("Daniel", "Carte", "dcarter1@abv.bg", "245615", "+3592 891 956", new List<int> { 2, 3, 3, 4 }, 1, 16,"OOP"));
            students.Add(new Students("Aaron", "Gibson", "agibson2@abv.bg", "387915", "052 541 896", new List<int> { 3, 3, 5, 5 }, 2, 37,"HQS"));
            students.Add(new Students("William", "Alexander", "walexander3@hexun.com", "412314", "048 459 486", new List<int> { 5, 6, 6, 6 }, 1, 18,"Java Script"));
            students.Add(new Students("Antonio", "Gonzalez", "agonzalez5@zdnet.com", "545614", "+359 2 546 874", new List<int> { 5, 3, 3, 3 }, 1, 33,"OOP"));
            students.Add(new Students("Jonathan", "Gibson", "jgibsond@shareasale.com", "684614", "031 546 589", new List<int> { 2, 2, 2, 2 }, 2, 24,"Java Script"));

            var gropedStudents =
                from student in students
                group student by student.GroupName;

            foreach (var stundetGroup in gropedStudents)
            {
                Console.WriteLine("Group Name : {0},Number of Students : {1}",stundetGroup.Key,stundetGroup.Count());
                foreach (var student in stundetGroup)
                {
                    Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
                }
                Console.WriteLine();
            }
        }
    }
}
