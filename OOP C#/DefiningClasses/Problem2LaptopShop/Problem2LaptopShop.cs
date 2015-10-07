using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptopShop
{
    class Problem2LaptopShop
    {
        static void Main(string[] args)
        {
            var laptopWithFullInfo = new Laptop(
                "Lenovo Yoga 2 Pro",
                2259.00m,
                "Lenovo",
                "13.3 inches (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display)",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "128GB SSD",
                "Intel HD Graphics 4400",
                new Battery("Li-Ion", 4, 2550, 4.5));

            Console.WriteLine(laptopWithFullInfo);

            var laptopWithMandatoryInfoOnly = new Laptop("HP 250 G2", 699.00m);

            Console.WriteLine(laptopWithMandatoryInfoOnly);
        }
    }
}
