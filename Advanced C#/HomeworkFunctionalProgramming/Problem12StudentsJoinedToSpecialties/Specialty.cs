using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12StudentsJoinedToSpecialties
{
    class Specialty
        {
            public Specialty
                (
                   
                    string Specialtys,
                    string ID
                )
            {
                this.Specialtys = Specialtys;
                this.ID = ID;
                
            }
            
            public string Specialtys{get;set;}
            public string ID {get; set;}
            
            
        }   
   
}
