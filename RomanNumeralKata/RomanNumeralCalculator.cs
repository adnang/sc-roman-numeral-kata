using System;

namespace RomanNumeralKata
{
    public class RomanNumeralCalculator
    {
        private readonly string[] romanNumbers =
        {
            "I", "II", "III", "IV", "V"
        };

        public string Calculate(int arabicNumber)
        {
            if (arabicNumber < 4)
            {
                return new string('I', arabicNumber);
            }

            var index = arabicNumber - 1;
            return romanNumbers[index];
        }
    }
}