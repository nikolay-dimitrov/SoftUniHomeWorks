using System;
using System.Linq;
using EntityFrameWork.Data;
using System.Threading;

//Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers. Write a testing class.

namespace CreatingDataAccessObjectsClass
{
    class Mains
    {
        private static int affectedRows;
        static void Main(string[] args)
        {
            using (var dataBase = new NorthwindEntities())
            {
                Console.WriteLine("Executing queries...");
                Thread.Sleep(1000);
                InsertNewCustomersToDb();
                Thread.Sleep(1000);
                ModifyNewInsertedCustomer();
                Thread.Sleep(1000);

            }
            Console.WriteLine("-- Closing connection to the database...");
        }
        static void InsertNewCustomersToDb()
        {
            var dataBase = new NorthwindEntities();
            var newCustomer = new Customer
            {
                CustomerID = "AAAAA",
                CompanyName = "Lethal Corporation",
                ContactName = "Alfonso Salvarez",
                ContactTitle = "CEO",
                Address = "33 Pedro Almodovar Sq.",
                City = "Ciudad Real",
                Region = "BC",
                PostalCode = "11223",
                Country = "Spain",
                Phone = "030-0023002",
                Fax = "030-0023003"

            };
            dataBase.Customers.Add(newCustomer);
            affectedRows = dataBase.SaveChanges();
            Console.WriteLine("({0} row(s) affected)", affectedRows);
        }
        static void DeleteNewInsertedCustomer()
        {
            var dataBase = new NorthwindEntities();
            var customer = dataBase.Customers.First();
            dataBase.Customers.Remove(customer);
            affectedRows = dataBase.SaveChanges();
            Console.WriteLine("({0} row(s) affected)", affectedRows);

        }
        static void ModifyNewInsertedCustomer()
        {
            var dataBase = new NorthwindEntities();
            var customer = dataBase.Customers.First();
            customer.ContactTitle = "CEO";
            affectedRows = dataBase.SaveChanges();
            Console.WriteLine("({0} row(s) affected)", affectedRows);
        }
    }
}
