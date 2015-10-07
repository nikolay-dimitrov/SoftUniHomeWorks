using CompanyHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy.Interface
{
    interface IManager
    {
        ISet<Employee> Employees { get; set; }

        void AddEmployees(ISet<Employee> employees);

        string ToString();
    }
}