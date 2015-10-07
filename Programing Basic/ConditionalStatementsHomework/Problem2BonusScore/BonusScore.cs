using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score");
            int score = int.Parse(Console.ReadLine());
            if ((score < 1)&&(score > 9))
                {
                    Console.WriteLine("Invalid Score");
                }

            switch (score)
            {
                case 1: score *= 10; Console.WriteLine(score);
                    break;
                case 2: score *= 10; Console.WriteLine(score);
                    break;
                case 3: score *= 10; Console.WriteLine(score);
                    break;
                case 4: score *= 100; Console.WriteLine(score);
                    break;
                case 5: score *= 100; Console.WriteLine(score);
                    break;
                case 6: score *= 100; Console.WriteLine(score);
                    break;
                case 7: score *= 1000; Console.WriteLine(score);
                    break;
                case 8: score *= 1000; Console.WriteLine(score);
                    break;
                case 9: score *= 1000;Console.WriteLine(score);
                    break;
                default: Console.WriteLine("Invalid Score");
                    break;
            }  

        }
    }
}
