using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100) % 10;
        if (thirdDigit == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}