using System;

namespace RomanNumeralKata
{
    public class RomanNumeralCalculator
    {
        public string Calculate(int arabicNumber)
        {
            if (arabicNumber >= 10)
            {
                return "X";
            }

            if (arabicNumber >= 9)
            {
                return "IX";
            }

            if (arabicNumber >= 5)
            {
                return "V" + Calculate(arabicNumber - 5);
            }

            if (arabicNumber >= 4)
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