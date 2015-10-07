using System;
using System.Text;

namespace PrintTheASCllTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            for (byte counter = 0; counter < 255; counter++)
            {
                Console.WriteLine((char)counter);
            }

        }
    }
}


