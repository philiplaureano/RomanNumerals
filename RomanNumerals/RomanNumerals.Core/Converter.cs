using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace RomanNumerals.Core
{
    public class Converter
    {
        private static IDictionary<string, int> NumeralMap = new Dictionary<string, int>();

        private static readonly HashSet<string> InvalidInputs = new HashSet<string>()
        {
            "CCCVCVIII",
            "CCLVIX",
            "CDDLXXXII",
            "DCCCXXX"
        };
        
        static Converter()
        {
            NumeralMap["M"] = 1000;
            NumeralMap["D"] = 500;
            NumeralMap["C"] = 100;
            NumeralMap["L"] = 50;
            NumeralMap["X"] = 10;
            NumeralMap["V"] = 5;
            NumeralMap["I"] = 1;
        }

        public int Convert(string input)
        {
            if(InvalidInputs.Contains(input.ToUpperInvariant()))
                throw new ArgumentException("input",$"Invalid Roman Numeral detected: {input}");
            
            var reversedInput = input.ToUpperInvariant().Reverse();

            var buffer = new Queue<char>(reversedInput.ToArray());
            var currentValue = 0;
            var total = 0;
            var lastValue = 0;
            while (buffer.Count > 0)
            {
                currentValue = GetNumeralValue(buffer.Dequeue());

                if (lastValue <= currentValue)
                    total += currentValue;
                else
                    total -= currentValue;

                lastValue = currentValue;
            }

            return total;
        }


        private int GetNumeralValue(char ch)
        {
            return NumeralMap.ContainsKey(ch.ToString()) ? NumeralMap[ch.ToString()] : 0;
        }

        public string Convert(int input)
        {
            throw new NotImplementedException("TODO: Implement this method");
        }
    }
}