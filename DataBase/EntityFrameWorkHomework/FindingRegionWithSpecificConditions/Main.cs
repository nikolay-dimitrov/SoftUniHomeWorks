using System;
using System.Linq;
using EntityFrameWork.Data;

//Write a method that finds all the sales by specified region and period (start / end dates).

namespace FindingRegionWithSpecificConditions
{
    class Mains
    {
        static void Main(string[] args)
        {
            const string region = "SP";
            var startDate = new DateTime(1995, 4, 9);
            var endDate = new DateTime(2001, 2, 1);

            using (var dataBase = new NorthwindEntities())
            {
                var sales = dataBase.Orders.Where(o => o.ShipRegion == region && o.OrderDate >= startDate && o.OrderDate <= endDate).ToList();
                foreach (var sale in sales)
                {
                    Console.WriteLine("{0} | {1}", sale.ShipRegion, sale.OrderDate);
                }
            }
        }
    }
}
