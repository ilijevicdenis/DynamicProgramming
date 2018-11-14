using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Walker.Model;

namespace Walker.Tests.PolarCoordinateTests
{
    [TestClass]
    public class CartesianCoordinate2PolarConversion
    {
        [TestMethod]
        public void CartesianCoordinateIsConvertedToPolar()
        {
            var testPoint = new PolarPoint(new Point(new Tube(2, 1 , "Unknown")));
            Assert.IsTrue(Math.Round(testPoint.R, 3) == 2.236);
            Assert.IsTrue(Math.Round(testPoint.Degree,3) == 26.565);
        }

        [TestMethod]
        public void PolarCoordinateIsConvertedTo()
        {
            var testPoint = new PolarPoint(new Point(new Tube(2, 1, "Unknown")));
            var cartessianPoint = Point.FromPolarPoint(testPoint);

            Assert.IsTrue(cartessianPoint.X == 1);
            Assert.IsTrue(cartessianPoint.Y == 2);

        }
    }
}
