using _01Point3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DistanceCalculator
{
    public class DistanceCalcMain
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(1, 4, 1);
            Point3D point2 = new Point3D(-4, 10, 2);
            Console.WriteLine(DistanceCalc.CalculateDistance(point1, point2));
        }
    }
}
