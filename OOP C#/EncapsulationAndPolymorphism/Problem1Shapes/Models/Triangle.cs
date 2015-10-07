using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Shapes.Models
{
    class Triangle : BasicShape
    {
        private double thirdSide;

        public Triangle(double firstSide,double secondSide,double thirdSide)
            :base(firstSide,secondSide)
        {
            this.ThirdSide = thirdSide;
        }

        public double ThirdSide

        {
            get
            {
                return this.thirdSide;
            }

            set 
            {
                this.thirdSide = value;
            }
        }

        public override double CalculateArea()
        {
 	        double p = (this.Width + this.Height + this.ThirdSide) /2;
            double area = Math.Sqrt(p * (p - this.Height) * (p - this.Width) * (p - this.ThirdSide));

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Width + this.Height + this.ThirdSide;
            return perimeter;
        }
    }
}
