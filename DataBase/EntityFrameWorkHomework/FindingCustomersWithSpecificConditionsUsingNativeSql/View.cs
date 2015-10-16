using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingCustomersWithSpecificConditionsUsingNativeSql
{
    class View
    {
        public string Customer { get; set; }

        public DateTime OrderYear { get; set; }

        public string ShipCountry { get; set; }

        public override string ToString()
        {
            return "Customer: " + this.Customer +
                   ", Order Year: " + this.OrderYear +
                   ", Ship Country: " + this.ShipCountry;
        }
    }
}
