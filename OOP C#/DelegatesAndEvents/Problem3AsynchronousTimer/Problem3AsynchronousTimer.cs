using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


namespace Problem3AsynchronousTimer
{
    internal class Problem3AsynchronousTimer
    {
        private static readonly Encoding EncodingOEMUnitedStates = Encoding.GetEncoding(437);

        // adds a random ASCII symbols, "Ticks" times, at a "T" milliseconds interval
        public static void PasswordGenerator(int x)
        {
            string character = EncodingOEMUnitedStates.GetString(new byte[] {(byte) x});
            Console.Write(character);
        }

        public static void Main()
        {
            // generates a random password
            AsyncTimer passGenerator = new AsyncTimer(PasswordGenerator, 16, 1000);
            passGenerator.ExecuteAction();

            AsyncTimer addNewLine = new AsyncTimer(AddNewLine, 1, 20000);
            addNewLine.ExecuteAction();
        }

        public static void AddNewLine(int x)
        {
            Console.WriteLine();
        }
    }
}