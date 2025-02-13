using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTest
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void AnalyzeTriangle_Input3EqualSides_ReturnsEquilateral()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;
            string expected = "Equilateral triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));


        }
    }
}
