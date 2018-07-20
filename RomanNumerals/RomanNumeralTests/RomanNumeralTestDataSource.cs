using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace RomanNumeralTests
{
    public static class RomanNumeralTestDataSource
    {
        public static IEnumerable<object[]> RomanNumerals => GetTestData();
        
        private static IEnumerable<object[]> GetTestData()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
          
            var csvFile = Path.Combine(basePath, "../../../../", "roman-numerals-1-1000.csv");

            var lines = (File.ReadAllLines(csvFile) ?? new string[0]).ToArray();

            var rows = new Queue<string>(lines.ToArray());

            // Ignore the first header row
            rows.Dequeue();

            var numerals = rows.Select(r =>
            {
                var columns = r.Split(",");
                var value = Int32.Parse(columns[0]);
                var numeral = columns[1];

                return new object[]{value,numeral};
            }).ToArray();

            return numerals;
        }
    }
}