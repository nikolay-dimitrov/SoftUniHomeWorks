using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{

    public class Courses
    {
        private ICollection<Homework> homeWork;

        public Courses()
        {
            this.homeWork = new HashSet<Homework>();
        }
        public int CoursesId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Materials { get; set; }

        public int HomeworkId { get; set; }
        public int ParentId { get; set; }
        public virtual Courses Parent { get; set; }

        public virtual ICollection<Homework> Homework
        {
            get { return this.homeWork; }
            set { this.homeWork = value; }
        }
    }
}
