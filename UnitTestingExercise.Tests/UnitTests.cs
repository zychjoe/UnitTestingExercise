using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(0, 0, 3, 3)]
        [InlineData(-1, -8, 9, 0)]
        [InlineData(400, 40, 4, 444)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var methods = new UnitTestMethods();


            //Act
            var actual = methods.Add(num1, num2, num3);

            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(100, 50, 50)]
        [InlineData(100, -50, 150)]
        [InlineData(10, 10, 0)]
        [InlineData(0, 50, -50)]
        [InlineData(10, 0, 10)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var methods = new UnitTestMethods();

            //Act
            var actual = methods.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(1 , 5, 5)]
        [InlineData(10, 0, 0)]
        [InlineData(0, 5, 0)]
        [InlineData(10, 1, 10)]
        [InlineData(10, 5, 50)]
        [InlineData(10, 50, 500)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var methods = new UnitTestMethods();

            //Act
            var actual = methods.Multiply(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(100, 10, 10)]
        [InlineData(125, 5, 25)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var methods = new UnitTestMethods();

            //Act
            var actual = methods.Divide(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void IsTrueCodersAwesome()
        {
            //Arrange
            var methods = new UnitTestMethods();

            //Act
            var actual = methods.IsTrueCodersAwesome();

            //Assert
            Assert.Equal(true, actual);

        }

        [Fact]
        public void GiveMeAJ()
        {
            //Arrange
            var methods = new UnitTestMethods();

            //Act
            var actual = methods.GiveMeAJ();

            //Assert
            Assert.Equal("J", actual);
        }
    }
}
