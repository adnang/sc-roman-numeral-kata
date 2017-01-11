using System;
using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class RomanNumeralCalculator
    {
        private readonly Dictionary<int, string> arabicToRoman = new Dictionary<int, string>
        {
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public string Calculate(int arabicNumber)
        {
            foreach (var arabic in arabicToRoman.Keys)
            {
                if (arabicNumber >= arabic)
                {
                    return arabicToRoman[arabic] + Calculate(arabicNumber - arabic);
                }
            }
                        
            return string.Empty;
        }
    }
}