using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Walker.Model;

namespace Walker.Tests.SecondaryAxisTests
{
    [TestClass]
    public class SecondaryAxisTests
    {
     
        [TestMethod]
        public void SecondaryAxisThrowsExceptionIfNotPerpediicularOrHorizontal()
        {
            Assert.ThrowsException<InvalidOperationException>(() => new SecondaryAxis(new Tube(5, 3, "Unknown"), new Tube(7, 10, "Unknown"), Factory.TubeFinder),
                    "Can't create secondary axis, given tubes aren't perpedicual or horizontal");

        }

        [TestMethod]
        public void MoveLeft()
        {
            SecondaryAxis axis = new SecondaryAxis(new Tube(1, 2, "Unknown"), new Tube(1, 5, "Unknown"), Factory.TubeFinder);
            axis = axis.MoveLeft();

            Assert.IsTrue(axis.Point1.X == 1);
            Assert.IsTrue(axis.Point1.Y == 1);
            Assert.IsTrue(axis.Point2.X == 4);
            Assert.IsTrue(axis.Point2.Y == 1);
        }

        [TestMethod]
        public void MoveRight()
        {
            SecondaryAxis axis = new SecondaryAxis(new Tube(1, 2, "Unknown"), new Tube(1, 5, "Unknown"), Factory.TubeFinder);
            axis = axis.MoveRight();

            Assert.IsTrue(axis.Point1.X == 3);
            Assert.IsTrue(axis.Point1.Y == 1);
            Assert.IsTrue(axis.Point2.X == 6);
            Assert.IsTrue(axis.Point2.Y == 1);
        }
    }
}
