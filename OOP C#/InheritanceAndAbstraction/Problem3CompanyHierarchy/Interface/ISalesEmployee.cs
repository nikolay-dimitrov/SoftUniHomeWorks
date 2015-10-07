using CompanyHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy.Interface
{
    interface ISalesEmployee
    {
        ISet<Sale> Sales { get; set; }

        void AddSales(ISet<Sale> sales);

        string ToString();
    }
}
