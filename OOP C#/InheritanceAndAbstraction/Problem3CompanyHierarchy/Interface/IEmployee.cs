using Problem3CompanyHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy.Interface
{
    interface IEmployee
    {
        Department Department { get; set; }

        decimal Salary { get; set; }

        string ToString();
    }
}