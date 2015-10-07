using CompanyHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy.Interface
{
    interface IDeveloper
    {
        ISet<Project> Projects { get; set; }

        void AddProjects(ISet<Project> projects);

        string ToString();
    }
}