using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Circle: Figure
    {
        public double Radius { get; set; }
        public Circle(double radius): base("Circle")
        {
            if (Exist(radius))
            {
                Radius = radius;
            }
        }
        public override double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        private bool Exist(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Radius is not positive");
            }
            return true;
        }
    }
}
