﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main(string[] args)
        {
            long decimalNumber, quotient;
            long i = 1, j, temp = 0;
            char[] hexadecimalNumber = new char[100];
            char temp1;
            Console.WriteLine("Enter a Decimal Number :");
            decimalNumber = long.Parse(Console.ReadLine());
            quotient = decimalNumber;
            while (quotient != 0)
            {
                temp = quotient % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadecimalNumber[i++] = temp1;
                quotient = quotient / 16;
            }
            Console.Write("Equivalent HexaDecimal Number is ");
            for (j = i - 1; j > 0; j--)
                Console.Write(hexadecimalNumber[j]);
            Console.Read();
 
        }
    }
}
