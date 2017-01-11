using System;
using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class RomanNumeralCalculator
    {
        private readonly Dictionary<int, string> romanBy = new Dictionary<int, string>() 
        {
            {4, "IV"},
            {5, "V"},
            {6, "VI"},
            {7, "VII"}
        };

        public string Calculate(int arabicNumber)
        {
            if (arabicNumber < 4)
            {
                return new string('I', arabicNumber);
            }

            return romanBy[arabicNumber];
        }
    }
}