using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1ClassStudent
{

    class Students
    {
        public Students(

             string FirstName,
             string LastName,
             string email,
             string facultyNumber,
             string phone,
             IList<int> marks,
             int groupNumber,
             int age
            )
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = email;
            this.facultyNumber = facultyNumber;
            this.phone = phone;
            this.marks = marks;
            this.groupNumber = groupNumber;
            this.age = age;
        }



        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string facultyNumber { get; set; }

        public string phone { get; set; }

        public IList<int> marks { get; set; }

        public int groupNumber { get; set; }
        public int age { get; set; }


    }
}
