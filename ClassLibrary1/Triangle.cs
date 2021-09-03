using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
	public class Triangle : Figure
	{
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }

		public Triangle(double a, double b, double c) : base("Triangle")
		{
			if (Exist(a, b, c))
			{
				SideA = a;
				SideB = b;
				SideC = c;
			}
		}

		public override double Square()
		{
			if (Rectangular())
            {
				if (SideA > SideB && SideA > SideC) { return SideB * SideC / 2.0; }
				else if (SideB > SideC) { return SideA * SideC / 2.0; }
				else { return SideA * SideB / 2.0; }
            }
			var p = (SideA + SideB + SideC) / 2.0;
			var square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
			return square;
		}

		private bool Exist(double a, double b, double c)
		{
			if (a <= 0 || b <= 0 || c <= 0)
			{
				throw new Exception("One of the sides is not positive");
			}

			if ((a > b + c) || (b > a + c) || (c > a + b))
			{
				throw new Exception("One of the sides is greater than the sum of the other two");
			}

			return true;
		}

		public bool Rectangular()
		{
			bool isRectangular = Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2)
							   || Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2)
							   || Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
			return isRectangular;
		}
	}
}
