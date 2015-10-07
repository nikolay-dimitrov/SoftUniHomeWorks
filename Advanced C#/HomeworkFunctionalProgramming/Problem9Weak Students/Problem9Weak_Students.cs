using Problem1ClassStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9Weak_Students
{
    class Problem9Weak_Students
    {
        static void Main(string[] args)
        {
            var students = new List<Students>();
            students.Add(new Students("Sara", "Mills", "smills0@marketwatch.com", 1, "02 832 432", new List<int> { 5, 3, 5, 6 }, 2, 25));
            students.Add(new Students("Daniel", "Carte", "dcarter1@abv.bg", 2, "+3592 891 956", new List<int> { 2, 3, 3, 4 }, 1, 16));
            students.Add(new Students("Aaron", "Gibson", "agibson2@abv.bg", 3, "052 541 896", new List<int> { 3, 3, 5, 5 }, 2, 37));
            students.Add(new Students("William", "Alexander", "walexander3@hexun.com", 4, "048 459 486", new List<int> { 5, 6, 6, 6 }, 1, 18));
            students.Add(new Students("Antonio", "Gonzalez", "agonzalez5@zdnet.com", 5, "+359 2 546 874", new List<int> { 5, 3, 3, 3 }, 1, 33));
            students.Add(new Students("Jonathan", "Gibson", "jgibsond@shareasale.com", 6, "031 546 589", new List<int> { 2, 2, 2, 2 }, 2, 24));

            var countThem = 
            from student in students
            where (student.marks.Min() == 2)
            select student;

            foreach (var student in countThem)
            {
                Console.WriteLine("{0} {1} {2}",student.FirstName,student.LastName,string.Join(" ",student.marks));
            }
        }
    }
}
