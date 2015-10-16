using System.Linq;
using EntityFrameWork.Data;
using System;

//Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

namespace FindingCustomersWithSpecificConditions
{
    class Mains
    {
        static void Main(string[] args)
        {
            using (var dataBase = new NorthwindEntities())
            {
                var customers = dataBase.Customers.Where(c => c.Orders.Any(x => x.OrderDate != null && (x.OrderDate.Value.Year == 1997 && x.ShipCountry == "Canada"))).ToList();
                foreach (var item in customers)
                {
                    Console.WriteLine(customers);
                }
            }
        }
    }
}
