using FluentAssertions;
using NUnit.Framework;

namespace RomanNumeralKata.Test
{
    [TestFixture]
    public class RomanNumeralCalculatorShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        public void ReturnRomanNumeral_WhenCalculatingRomanNumeral_GivenArabicNumber(int arabicNumber, string expectedRomanNumeral)
        {
            var romanNumeralCalculator = new RomanNumeralCalculator();

            var romanNumeral = romanNumeralCalculator.Calculate(arabicNumber);

            romanNumeral.Should().Be(expectedRomanNumeral);
        }
    }
}
