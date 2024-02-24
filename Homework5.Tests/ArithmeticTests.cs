using System;
using Xunit;

namespace Homework5.Tests
{
    public class ArithmeticTests
    {
        [Theory]
        [InlineData(1, 2, 3, 4, 5, 15)]
        [InlineData(5, 4, 3, 2, 1, 15)]
        [InlineData(-5, 4, -3, 2, -1, -3)]
        [InlineData(-5, 4, -3, 0, -1, -5)]
        [InlineData(25, 50, 75, 100, 125, 375)]
        [InlineData(-25, -50, -75, -100, -125, -375)]
        public void SumTests(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, int expected)
        {
            Assert.Equal(expected, Arithmetic.Sum(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 3)]
        [InlineData(5, 4, 3, 2, 1, 3)]
        [InlineData(-5, 4, -3, 2, -1, -0.6)]
        [InlineData(-5, 4, -3, 0, -1, -1)]
        [InlineData(25, 50, 75, 100, 125, 75)]
        [InlineData(-25, -50, -75, -100, -125, -75)]
        public void AverageTests(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, double expected)
        {
            Assert.Equal(expected, Arithmetic.Average(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 120)]
        [InlineData(5, 4, 3, 2, 1, 120)]
        [InlineData(-5, 4, -3, 2, -1, -120)]
        [InlineData(-5, 4, -3, 0, -1, 0)]
        [InlineData(25, 50, 75, 100, 125, 1171875000)]
        [InlineData(-25, -50, -75, -100, -125, -1171875000)]
        public void ProductTests(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, double expected)
        {
            Assert.Equal(expected, Arithmetic.Product(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 1)]
        [InlineData(5, 4, 3, 2, 1, 1)]
        [InlineData(-5, 4, -3, 2, -1, -5)]
        [InlineData(-5, 4, -3, 0, -1, -5)]
        [InlineData(25, 50, 75, 100, 125, 25)]
        [InlineData(-25, -50, -75, -100, -125, -125)]
        public void SmallestNumberTests(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, double expected)
        {
            Assert.Equal(expected, Arithmetic.SmallestNumber(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 5)]
        [InlineData(5, 4, 3, 2, 1, 5)]
        [InlineData(-5, 4, -3, 2, -1, 4)]
        [InlineData(-5, 4, -3, 0, -1, 4)]
        [InlineData(25, 50, 75, 100, 125, 125)]
        [InlineData(-25, -50, -75, -100, -125, -25)]
        public void LargestNumberTests(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, double expected)
        {
            Assert.Equal(expected, Arithmetic.LargestNumber(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 5)]
        [InlineData(5, 4, 3, 2, 1, 5)]
        [InlineData(-5, 4, -3, 2, -1, 2)]
        [InlineData(-5, 4, -3, 0, -1, 1)]
        [InlineData(25, 50, 75, 100, 125, 5)]
        [InlineData(-25, -50, -75, -100, -125, 0)]
        public void CountOfNegativeIntegersTests(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, double expected)
        {
            Assert.Equal(expected, Arithmetic.CountOfPositiveIntegers(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 0)]
        [InlineData(5, 4, 3, 2, 1, 0)]
        [InlineData(-5, 4, -3, 2, -1, 3)]
        [InlineData(-5, 4, -3, 0, -1, 3)]
        [InlineData(25, 50, 75, 100, 125, 0)]
        [InlineData(-25, -50, -75, -100, -125, 5)]
        public void CountOfPositiveIntegersTests(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, double expected)
        {
            Assert.Equal(expected, Arithmetic.CountOfNegativeIntegers(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5, 0)]
        [InlineData(5, 4, 3, 2, 1, 0)]
        [InlineData(-5, 4, -3, 2, -1, 0)]
        [InlineData(-5, 4, -3, 0, -1, 1)]
        [InlineData(25, 50, 75, 100, 125, 0)]
        [InlineData(-25, -50, -75, -100, -125, 0)]
        public void CountOfPositiveIntegersCountOfZeroesTests(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, double expected)
        {
            Assert.Equal(expected, Arithmetic.CountOfZeroes(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
        }
    }
}
