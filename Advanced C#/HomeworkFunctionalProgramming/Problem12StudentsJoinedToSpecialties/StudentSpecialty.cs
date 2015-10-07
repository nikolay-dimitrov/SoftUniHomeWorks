using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12StudentsJoinedToSpecialties
{
    class StudentSpecialty
    {

        public StudentSpecialty(

            string ID,
            string Name

            )

        {
            this.ID = ID;
            this.Name = Name;
        }
        
        
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
