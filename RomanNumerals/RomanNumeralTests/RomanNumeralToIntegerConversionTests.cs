using System;
using Xunit;
using RomanNumerals.Core;

namespace RomanNumeralTests
{
    public class RomanNumeralToIntegerConversionTests
    {
        [Theory]
        [InlineData("ↈ", 100000)]
        [InlineData("ↇ", 50000)]
        [InlineData("ↂ", 10000)]
        [InlineData("ↁ", 5000)]
        [InlineData("ↀ", 1000)]
        [InlineData("M", 1000)]
        [InlineData("D", 500)]
        [InlineData("C", 100)]
        [InlineData("L", 50)]
        [InlineData("X", 10)]
        [InlineData("V", 5)]
        [InlineData("I", 1)]
        public void TestConversion(string input, int expectedResult)
        {
            var converter = new Converter();
            var result = converter.Convert(input);
            Assert.Equal(expectedResult, result);
        }
    }
}