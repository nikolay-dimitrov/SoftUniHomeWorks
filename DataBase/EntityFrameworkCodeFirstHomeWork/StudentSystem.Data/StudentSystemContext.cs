using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
   public class StudentSystemContext: DbContext
    {
        public StudentSystemContext()
            :base ("StudentDataBaseHomeWork")
        {
        }

        public DbSet<Courses> Courses { get; set; }

        public DbSet<Homework> Homework { get; set; }

        public DbSet<Students> Students { get; set; }

        public DbSet<StudentsInCourses> StudentsInCourses { get; set; }



    }
}
