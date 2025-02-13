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
        //test for valid equilateral triangle
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

        //tests for valid isosceles triangle
        [Test]
        public void AnalyzeTriangle_TwoEqualSidesAtBeginning_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 3;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_TwoEqualSidesAtEnd_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 6;
            int thirdSide = 6;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_LargeIsoscelesTriangle_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 15;
            string expected = "Isosceles triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
