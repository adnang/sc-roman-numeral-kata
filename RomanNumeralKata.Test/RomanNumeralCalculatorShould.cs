using FluentAssertions;
using NUnit.Framework;

namespace RomanNumeralKata.Test
{
    [TestFixture]
    public class RomanNumeralCalculatorShould
    {
        [TestCase(1, "I")]
        public void ReturnRomanNumeral_WhenCalculatingRomanNumeral_GivenArabicNumber(int arabicNumber, string expectedRomanNumeral)
        {
            RomanNumeralCalculator romanNumeralCalculator = new RomanNumeralCalculator();
            string romanNumeral = romanNumeralCalculator.Calculate(arabicNumber);
            romanNumeral.Should().Be(expectedRomanNumeral);
        }
    }

    public class RomanNumeralCalculator
    {
        public string Calculate(int arabicNumber)
        {
            return "I";
        }
    }
}
