using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2,3,5,10)]
        [InlineData(12,10,3,25)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(7, 5, 2)]
        [InlineData(100, 4, 96)]
        public void Substract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            int actual = test.Substract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData(7, 5, 35)]
        [InlineData(100, 4, 400)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            int actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 5, 3)]
        [InlineData(62, 2, 31)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            int actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {

            //Arrange
            var test = new UnitTestMethods();

            //Act
            string actual = test.YourMethodName();

            //Assert
            Assert.Equal("MethodNotFound", actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            string actual = test.YourMethodName2();

            //Assert
            Assert.Equal("HereMyMethod", actual);
        }



    }
}
