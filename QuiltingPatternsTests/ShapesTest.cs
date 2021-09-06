using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuiltingPatterns;
using System;
using System.Collections.Generic;

namespace QuiltingPatternsTests
{
    [TestClass]
    public class ShapesTest
    {
        [TestMethod]
        public void rectangleTest()
        {
            // Arrange
            List<decimal> sides = new List<decimal>() { 4.5m, 5.5m };

            // Act
            rectangle testRectangle = new rectangle(sides, "Green");

            // Assert
            Assert.AreEqual("Your shape is a Green Rectangle, and the area is 24.75.\r\n", testRectangle.ToString());
        }

        [TestMethod]
        public void squareTest()
        {
            // Arrange
            List<decimal> sides = new List<decimal>() { 4.5m };

            // Act
            square testSquare = new square(sides, "Blue");

            // Assert
            Assert.AreEqual("Your shape is a Blue Square, and the area is 20.25.\r\n", testSquare.ToString());
        }

        [TestMethod]
        public void triangleTest()
        {
            // Arrange
            List<decimal> sides = new List<decimal>() { 4.5m, 5m, 8.3m };

            // Act
            triangle testTriangle = new triangle(sides, "Red");

            // Assert
            Assert.AreEqual("Your shape is a Red Triangle, and the area is 9.573.\r\n", testTriangle.ToString());
        }

    }
}
