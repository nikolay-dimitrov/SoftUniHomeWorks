using Problem1ClassStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10StudentsEnrolledIn2014
{
    class Problem10StudentsEnrolledIn2014
    {
        static void Main(string[] args)
        {
            var students = new List<Students>();
            students.Add(new Students("Sara", "Mills", "smills0@marketwatch.com", "112314", "02 832 432", new List<int> { 5, 3, 5, 6 }, 2, 25));
            students.Add(new Students("Daniel", "Carte", "dcarter1@abv.bg", "245615", "+3592 891 956", new List<int> { 2, 3, 3, 4 }, 1, 16));
            students.Add(new Students("Aaron", "Gibson", "agibson2@abv.bg", "387915", "052 541 896", new List<int> { 3, 3, 5, 5 }, 2, 37));
            students.Add(new Students("William", "Alexander", "walexander3@hexun.com", "412314", "048 459 486", new List<int> { 5, 6, 6, 6 }, 1, 18));
            students.Add(new Students("Antonio", "Gonzalez", "agonzalez5@zdnet.com", "545614", "+359 2 546 874", new List<int> { 5, 3, 3, 3 }, 1, 33));
            students.Add(new Students("Jonathan", "Gibson", "jgibsond@shareasale.com", "684614", "031 546 589", new List<int> { 2, 2, 2, 2 }, 2, 24));

            var stundentsIn14 =
                from stundent in students
                where (stundent.facultyNumber.EndsWith("14"))
                select stundent;

            foreach (var student in stundentsIn14)
            {
                Console.WriteLine("{0} {1} {2}",student.FirstName,student.LastName,string.Join(" ",student.marks));
            }

        }
    }
}
