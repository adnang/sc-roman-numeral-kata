using System;
using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class RomanNumeralCalculator
    {
        private readonly Dictionary<int, string> romanBy = new Dictionary<int, string>()
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {6, "VI"},
            {7, "VII"},
            {8, "VIII"},
            {9, "IX"}
        };

        public string Calculate(int arabicNumber)
        {
            if (arabicNumber >= 9)
            {
                return "IX";
            }

            if (arabicNumber >= 5)
            {
                return "V" + Calculate(arabicNumber - 5);
            }

            if (arabicNumber == 4)
            {
                return "IV" + Calculate(arabicNumber - 4);
            }

            if (arabicNumber >= 1)
            {
                return "I" + Calculate(arabicNumber - 1);
            }

            return string.Empty;
        }
    }
}