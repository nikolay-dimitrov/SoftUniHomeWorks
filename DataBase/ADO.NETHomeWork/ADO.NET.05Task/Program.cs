using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ADO.NET._05Task
{
    class Program
    {
        private const int OLE_METAFILEPICT_START_POSITION = 78;
        static void Main(string[] args)
        {
            byte[] image = null;
            SqlConnection dbCon = new SqlConnection(
            "Server=NIKOLAY-PC; " +
            "Database=Northwind; " +
            "Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmd = new SqlCommand("SELECT Picture FROM Categories", dbCon);
                SqlDataReader reader = cmd.ExecuteReader();

                var count = 0;
                string filePath;
                while (reader.Read())
                {
                    filePath = string.Format(@"..\..\pictures\CategoryPicture{0}.jpg", count);
                    image = (byte[])reader["Picture"];
                    WiriteImageFile(filePath, image);
                    count++;
                }
            }
        }

        private static void WiriteImageFile(string fileName, byte[] fileContents)
        {
            using (
                var ms = new MemoryStream(fileContents, OLE_METAFILEPICT_START_POSITION, fileContents.Length , OLE_METAFILEPICT_START_POSITION))
            {
                Image img = Image.FromStream(ms);
                img.Save(fileName);
            }
            
        }
    }
}
