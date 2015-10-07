using _01Point3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DistanceCalculator
{
    public class DistanceCalc
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double result = Math.Sqrt(
          (second.X - first.X) * (second.X - first.X) +
          (second.Y - first.Y) * (second.Y - first.Y) +
          (second.Z - first.Z) * (second.Z - first.Z));
            return result;
        }
    }
}
