using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Class27.Tests
{
    public class FizzBuzzWoofTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void ThreePrintsFizz(int input)
        {
            // Arrange

            // Act
            var sut = new FizzBuzzWoof();
            var result = sut.GetFizzBuzzWoof(input);

            // Assert
            Assert.Equal("Fizz", result);
        }
    }
}
