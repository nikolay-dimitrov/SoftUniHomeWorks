using System;
using System.Linq;
using EntityFrameWork.Data;

namespace ExtendingEmployeeClass
{
    class Mains
    {
        static void Main(string[] args)
        {
            using (var dataBase = new NorthwindEntities())
            {
                foreach (var employee in dataBase.Employees.Include("Territories"))
                {
                    var correspondingTerritories = employee.Territories.Select(c => c.TerritoryID);
                    var correspondingTerritoriesAsString = string.Join(", ", correspondingTerritories);
                    Console.WriteLine("{0} -> Territory IDs: {1}", employee.FirstName, correspondingTerritoriesAsString);
                }
            }
        }
    }
}
