using System;
using System.Data.OleDb;
using System.Configuration;

/* 6.Create an Excel file with 2 columns: name and score:
Write a program that reads your MS Excel file through the OLE DB data provider and displays 
the name and score row by row. */
namespace ADO.NET._06Task
{
    class Program
    {
        static void Main(string[] args)
        {
                OleDbConnection dbCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["ExamsExcel"].ConnectionString);
                dbCon.Open();
                using (dbCon)
                {
                    OleDbCommand command = new OleDbCommand("SELECT * FROM [Exams$]", dbCon);
                    var reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        var name = reader["Name"];
                        var score = reader["Score"];

                        Console.WriteLine("Name: {0}, Score: {1}", name, score);
                    }
                }
            }
        }
}