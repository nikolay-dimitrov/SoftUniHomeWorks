using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12StudentsJoinedToSpecialties
{
    class Problem12StudentsJoinedToSpecialties
    {
        static void Main(string[] args)
        {
            var students = new List<StudentSpecialty>();
            students.Add(new StudentSpecialty("215314","Milena Kirova"));
            students.Add(new StudentSpecialty("203114", "Stefan Popov"));
            students.Add(new StudentSpecialty("203314", "Asya Manova"));
            students.Add(new StudentSpecialty("203914", "Diana Petrova"));
            students.Add(new StudentSpecialty("203814", "Ivan Ivanov"));

            var specialties = new List<Specialty>();
            specialties.Add(new Specialty("Web Developer", "203314"));
            specialties.Add(new Specialty("Web Developer", "203114)"));
            specialties.Add(new Specialty("PHP Developer", "203814"));
            specialties.Add(new Specialty("PHP Developer", "203914"));
            specialties.Add(new Specialty("QA Engineer", "203314"));
            specialties.Add(new Specialty("Web Developer", "203914"));

            var query =
                from student in students
                join specialti in specialties on student.ID equals specialti.ID
                select new { student.Name, specialti.Specialtys,student.ID};

            foreach (var group in query)
            {
                Console.WriteLine("{0} {1} {2}", group.Name,group.ID,group.Specialtys);
            }




        }
    }
}
