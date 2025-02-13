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

        //tests for valid scalene triangle
        [Test]
        public void AnalyzeTriangle_SmallScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_AnotherSmallScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 6;
            int thirdSide = 7;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_MediumScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 9;
            int thirdSide = 12;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_LargeScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 15;
            int thirdSide = 20;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_RandomValidScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int firstSide = 8;
            int secondSide = 11;
            int thirdSide = 14;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        //tests for verifying a zero length of one or more slides
        [Test]
        public void AnalyzeTriangle_ZeroFirstSide_ReturnsInvalidTriangle()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 5;
            int thirdSide = 6;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_ZeroSecondSide_ReturnsInvalidTriangle()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 0;
            int thirdSide = 7;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_AllSidesZero_ReturnsInvalidTriangle()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        //tests to verify an invalid response (other than a zero length)
        [Test]
        public void AnalyzeTriangle_SumOfTwoSidesEqualsThirdSide_ReturnsInvalid()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 5;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_SumOfTwoSidesLessThanThirdSide_ReturnsInvalid()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 8;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AnalyzeTriangle_AllPositiveButInvalid_ReturnsInvalid()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 10;
            int thirdSide = 12;
            string expected = "INVALID!!";

            // Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
