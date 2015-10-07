using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            double weightOnTheMoon = (weight * 0.17);

            Console.WriteLine(weightOnTheMoon);
            
 
        }
    }
}
