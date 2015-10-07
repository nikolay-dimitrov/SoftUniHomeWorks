using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy.Interface
{
    interface ICustomer
    {
        decimal PurchasesAmmount { get; set; }

        void AddPurchasePrice(decimal purchasePrice);

        string ToString();
    }
}