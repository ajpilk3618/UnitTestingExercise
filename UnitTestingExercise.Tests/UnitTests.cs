using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,1,1,3)]
        [InlineData(0,0,0,0)]
        [InlineData(10, 45, 4, 59)]
        [InlineData(3, 5, 8, 16)]
        [InlineData(-10, -5, 3, -12)]
        [InlineData(-7, 7, -7, -7)]
        [InlineData(-23, 0, 23, 0)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();

            //Act
            int actual = challenger.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 3, 9)]
        [InlineData(9, -9, 18)]
        [InlineData(4, 8, -4)]
        [InlineData(0,0,0)]
        [InlineData(16, 5, 11)]

        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();

            //Act
            int actual = challenger.Sub(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(2354, 0, 0)]
        [InlineData(-5, 5, -25)]
        [InlineData(-5, -5, 25)]
        [InlineData(34, 1, 34)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();

            //Act
            int actual = challenger.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(45, 5, 9)]
        [InlineData(15, 5, 3)]
        [InlineData(180, 12, 15)]
        [InlineData(60, 15, 4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();

            //Act
            int actual = challenger.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void PrintHello()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.PrintHello();
            //Assert
            Assert.Equal("Hello", actual);

        }

        [Fact]
        public void MyName()
        {
            //Arrange
            UnitTestMethods challenger = new UnitTestMethods();
            //Act
            string actual = challenger.MyName();
            //Assert
            Assert.Equal("AJ Pilkerton", actual);
        }
    }
}
