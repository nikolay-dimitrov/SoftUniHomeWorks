using System;
using System.Data.SqlClient;
/* 4.Write a method that adds a new product in the products table in the Northwind database.
Use a parameterized SQL command.*/
namespace ADO.NET._04Task
{
    class Program
    {
        static  void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(
            "Server=NIKOLAY-PC; " +
            "Database=Northwind; " +
            "Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO Products  
              (ProductName, SupplierID, CategoryID, QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) VALUES  
              (@name,@supplierId,@categoryId,@quantityPerUnit,@unitPrice,@unitInStock,@unitsOnOrder,@recordLevel,@discontinued)", dbCon);
                command.Parameters.AddWithValue("@name", "From C#");
                command.Parameters.AddWithValue("@supplierId", 1);
                command.Parameters.AddWithValue("@categoryId", 1);
                command.Parameters.AddWithValue("@quantityPerUnit", "2 bags" );
                command.Parameters.AddWithValue("@unitPrice", 234.5);
                command.Parameters.AddWithValue("@unitInStock", 1000);
                command.Parameters.AddWithValue("@unitsOnOrder", 50);
                command.Parameters.AddWithValue("@recordLevel", 12);
                command.Parameters.AddWithValue("@discontinued", 0);
                command.ExecuteNonQuery();
                Console.WriteLine("The record has been added!");
            }
        }
      
    }
}
