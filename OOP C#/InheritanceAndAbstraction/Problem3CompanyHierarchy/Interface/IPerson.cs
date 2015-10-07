using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy.Interface
{
    interface IPerson
    {
        string ID { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string ToString();
    }
}