using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models

{

    public class Homework
    {
        private ICollection<Students> students;

        private ICollection<Courses> courses;

        public Homework()
        {
            this.students = new HashSet<Students>();
            this.courses = new HashSet<Courses>();
        }

        public int HomeWorkId { get; set; }

        public DateTime? TimeSent { get; set; }

        public string Content { get; set; }

        public int CoursesId { get; set; }

        public virtual ICollection<Students> Students
        {
            get { return students; }
            set { students = value; }
        }

        public virtual ICollection<Courses> Courses
        {
            get { return Courses; }
            set { Courses = value; }
        }

    }
}