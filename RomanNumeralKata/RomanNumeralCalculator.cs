namespace RomanNumeralKata
{
    public class RomanNumeralCalculator
    {
        private readonly string[] romanNumbers = {"I", "II", "III"};

        public string Calculate(int arabicNumber)
        {
            var index = arabicNumber - 1;

            return romanNumbers[index];
        }
    }
}