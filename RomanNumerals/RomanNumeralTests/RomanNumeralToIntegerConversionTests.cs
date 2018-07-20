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
        public void TestConversionToInteger(string input, int expectedResult)
        {
            var converter = new Converter();
            var result = converter.Convert(input);
            Assert.Equal(expectedResult, result);
        }
        
        [Theory]
        [InlineData(100000,"ↈ")]
        [InlineData(50000, "ↇ" )]
        [InlineData(10000, "ↂ")]
        [InlineData(5000,"ↁ")]
        [InlineData(1000, "ↀ")]
        [InlineData(1000, "M")]
        [InlineData(500,"D")]
        [InlineData(100, "C")]
        [InlineData(50, "L")]
        [InlineData(10, "X")]
        [InlineData(5, "V")]
        [InlineData(1, "I")]
        public void TestConversionToRomanNumeral(int input, string expectedResult)
        {
            var converter = new Converter();
            var result = converter.Convert(input);
            Assert.Equal(expectedResult, result);
        }
    }
}