using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class StudentsInCourses
    {
        private ICollection<Students> students;

        private ICollection<Courses> courses;

        public StudentsInCourses()
        {
            this.students = new HashSet<Students>();
            this.courses = new HashSet<Courses>();
        }

        public int StudentsInCoursesId { get; set; }

        public virtual ICollection<Students> Students
        {
            get { return students; }
            set { students = value; }
        }

        public virtual ICollection<Courses> Courses
        {
            get { return courses; }
            set { courses = value; }
        }


    }
}
