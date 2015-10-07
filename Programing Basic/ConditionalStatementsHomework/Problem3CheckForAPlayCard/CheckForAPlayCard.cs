using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cardsign to designate the card:");
            string cardSight = Console.ReadLine();
            switch (cardSight)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "A":
                case "J":
                case "K":
                case "Q":
                    Console.WriteLine("yes");
                    break;

                default:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}
