using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers with a space between them:");
            string[] num = Console.ReadLine().Split();
            int resultOdd = 1;
            int resultEven= 1;
            for (int i = 0; i < num.Length; i = i + 2)
            {
                 resultOdd *= Convert.ToInt32(num[i]);
                
            }
               
            for (int i = 1; i < num.Length; i = i + 2)
            {
                 
                 resultEven *= Convert.ToInt32(num[i]);
                
            }
            
            if (resultOdd == resultEven)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", resultOdd);
                
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", resultOdd);
                Console.WriteLine("even_product = {0}", resultEven);
            }
        }
    }
}
   
