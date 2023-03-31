using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_5
{
	internal class Triangle
	{
		private double x1, y1, x2, y2, x3, y3;

		public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			this.x1 = x1;
			this.y1 = y1;
			this.x2 = x2;
			this.y2 = y2;
			this.x3 = x3;
			this.y3 = y3;
		}

		public double Area()
		{
			double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
			double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
			double s = (side1 + side2 + side3) / 2;
			return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
		}
	}
}
