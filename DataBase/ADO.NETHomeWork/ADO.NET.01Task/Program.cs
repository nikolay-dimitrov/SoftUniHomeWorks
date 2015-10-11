using System;
using System.Data.SqlClient;

// 1.Write a program that retrieves from the Northwind sample database in MS SQL Server 
// the number of rows in the Categories table.

namespace ADO.NET._01Task
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
                SqlCommand command = new SqlCommand("Select COUNT(*) FROM Categories", dbCon);
                int numberRow = (int)command.ExecuteScalar();
                Console.WriteLine("RowCount in table Categories is : {0}",numberRow);
            }
        }
    }
}
