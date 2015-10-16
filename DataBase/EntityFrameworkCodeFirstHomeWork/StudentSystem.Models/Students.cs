using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Students
    {
        private ICollection<StudentsInCourses> stundetsInCourses;

        public Students()
        {
            this.stundetsInCourses = new HashSet<StudentsInCourses>();
        }
        public int StudentsId { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public int HomeworkId{ get; set; }

        public virtual Homework Homework { get; set; }

        public virtual ICollection<StudentsInCourses> StundetsInCourses
        {
            get { return this.stundetsInCourses; }
            set { this.stundetsInCourses = value; }
        }
    }
}
