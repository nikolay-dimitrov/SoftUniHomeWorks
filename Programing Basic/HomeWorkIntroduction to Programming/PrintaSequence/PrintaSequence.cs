using System;

    class PrintaSequence
{
        static void Main()
        {
            for (int i = 2; i <= 11; i ++)
        {
            if(i%2==0)
            {
                Console.Write(i+",");
            }
            else
            {
                Console.Write(-i+",");
            }
        }
        Console.WriteLine();
     }
 
}

 
