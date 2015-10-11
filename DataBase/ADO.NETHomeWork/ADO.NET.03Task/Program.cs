using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 3.Write a program that retrieves from the Northwind database all product categories and the names of the products 
in each category. Can you do this with a single SQL query (with table join)? */

namespace ADO.NET._03Task
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
                SqlCommand command = new SqlCommand("SELECT c.CategoryName,p.ProductName FROM Categories c,Products p WHERE c.CategoryID = p.CategoryID", dbCon);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var nameOfCategories = (string)reader["CategoryName"];
                        var description = (string)reader["ProductName"];
                        Console.WriteLine("{0} {1}", nameOfCategories, description);
                    }
                }
            }
        }
    }
}
