using System;
using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class RomanNumeralCalculator
    {
        private readonly Dictionary<int, string> arabicToRoman = new Dictionary<int, string>
        {
            { 1000, "C" },
            { 500, "D" },
            { 100, "C" },
            { 90, "XC" },
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
            foreach (var keyArabic in arabicToRoman.Keys)
            {
                if (arabicNumber >= keyArabic)
                {
                    var remainingArabic = arabicNumber - keyArabic;
                    return RomanFrom(keyArabic) + Calculate(remainingArabic);
                }
            }
                        
            return string.Empty;
        }

        private string RomanFrom(int arabic)
        {
            return arabicToRoman[arabic];
        }
    }
}