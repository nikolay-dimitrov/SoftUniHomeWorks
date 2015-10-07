using Problem3CompanyHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy.Interface
{
    interface IProject
    {
        string Name { get; set; }

        string Details { get; set; }

        DateTime StartDate { get; set; }

        ProjectState State { get; set; }

        void CloseProject();
    }
}