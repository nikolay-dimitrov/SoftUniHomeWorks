﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter an integer:");
             int n = int.Parse(Console.ReadLine());
             for (int i = 1; i <= n; i++)
             {
                 Console.WriteLine(i);
             }
          }
    }
}
