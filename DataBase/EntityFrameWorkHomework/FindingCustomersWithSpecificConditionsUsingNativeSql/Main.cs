using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameWork.Data;

//Implement previous by using native SQL query and executing it through the DbContext.

namespace FindingCustomersWithSpecificConditionsUsingNativeSql
{
    class Mains
    {
        static void Main(string[] args)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            string nativeSqlQuery =
                "SELECT c.ContactName AS [Customer], o.OrderDate [Order Year],o.ShipCountry " +
                "FROM dbo.Orders o,dbo.Customers c " +
                "WHERE c.CustomerID = o.CustomerID AND YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'";
            using (var dataBase = new NorthwindEntities())
            {
                var customers = dataBase.Database.SqlQuery<View>(nativeSqlQuery);
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
    }
}
