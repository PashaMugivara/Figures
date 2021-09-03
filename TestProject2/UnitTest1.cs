using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestProject
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void Test1()
		{
			var triangle = new Triangle(3, 4, 5);
			var isRectangular = triangle.Rectangular();
			Assert.IsTrue(isRectangular);
		}

		[TestMethod]
		public void Test2()
		{
			var triangle = new Triangle(3, 4, 5);
			double result = 6;
			var square = triangle.Square();
			Assert.AreEqual(result, square);
		}
		[TestMethod]
		public void Test3()
		{
			var triangle = new Triangle(2, 4, 5);
			double result = 3.799671;
			var square = Math.Round(triangle.Square(), 6);
			Assert.AreEqual(result, square);
		}
	}

	[TestClass]
	public class CircleTest
	{
		[TestMethod]
		public void Test1()
		{
			var circle = new Circle(5);
			double result = 78.539816;
			var square = Math.Round(circle.Square(), 6);
			Assert.AreEqual(result, square);
		}
	}
}
