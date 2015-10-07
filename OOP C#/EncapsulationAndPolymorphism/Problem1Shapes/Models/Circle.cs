﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Shapes.Models
{
     class Circle : BasicShape
    {
        public Circle(double radius)
            : base(radius, 1)
        { 
        }
        public override double CalculateArea()
        {
            double area = Math.PI * this.Width * this.Height;
            return area;
        }
        public override double CalculatePerimeter()
        {
            double perimeter = Math.PI * this.Width * 2;
            return perimeter;
        }
    }
}
