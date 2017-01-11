namespace RomanNumeralKata
{
    public class RomanNumeralCalculator
    {
        public string Calculate(int arabicNumber)
        {
            if (arabicNumber == 1)
            {
                return "I";
            }

            if (arabicNumber == 2)
            {
                return "II";
            }

            return "III";
        }
    }
}