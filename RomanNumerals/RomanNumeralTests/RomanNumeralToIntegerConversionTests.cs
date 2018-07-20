using System;
using Xunit;
using RomanNumerals.Core;

namespace RomanNumeralTests
{
    public class RomanNumeralToIntegerConversionTests
    {
        [Theory]
        [MemberData(nameof(RomanNumeralTestDataSource.RomanNumerals), MemberType = typeof(RomanNumeralTestDataSource))]
        public void TestConversionToInteger(int expectedResult, string input)
        {
            var converter = new Converter();
            var result = converter.Convert(input);
            Assert.Equal(expectedResult, result);
        }
        
        [Theory]
        [MemberData(nameof(RomanNumeralTestDataSource.RomanNumerals), MemberType = typeof(RomanNumeralTestDataSource))]
        public void TestConversionToRomanNumeral(int input, string expectedResult)
        {
            var converter = new Converter();
            var result = converter.Convert(input);
            Assert.Equal(expectedResult, result);
        }
    }
}