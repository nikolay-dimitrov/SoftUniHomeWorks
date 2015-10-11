using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2.Write a program that retrieves the name and description of all categories in the Northwind DB.

namespace ADO.NET._02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(
           "Server=NIKOLAY-PC; " +
           "Database=Northwind; " +
           "Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var nameOfCategories = (string)reader["CategoryName"];
                        var description = (string)reader["Description"];
                        Console.WriteLine("{0} {1}", nameOfCategories, description);
                    }
                }

            }

        }
    }
}
