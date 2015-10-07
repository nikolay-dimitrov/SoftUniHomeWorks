using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CopyBinaryFile
{
    const string NImagePath = "../../image.jpg";
    const string DestinationPath = "../../result.jpg";

    static void Main()
    {
        using (var source = new FileStream(NImagePath, FileMode.Open))
        {
            using (var destination = new FileStream(DestinationPath, FileMode.Create))
            {
                byte[] buffer = new byte[100000];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    destination.Write(buffer, 0, readBytes);
                }
            }
        }
        System.Diagnostics.Process.Start(@"..\..\result.jpg");
    }

    public static Microsoft.Win32.SafeHandles.SafeFileHandle ImagePath { get; set; }
}
