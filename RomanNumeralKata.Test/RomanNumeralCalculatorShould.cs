using FluentAssertions;
using NUnit.Framework;

namespace RomanNumeralKata.Test
{
    [TestFixture]
    public class RomanNumeralCalculatorShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(20, "XX")]
        [TestCase(18, "XVIII")]
        [TestCase(50, "L")]
        [TestCase(40, "XL")]
        [TestCase(70, "LXX")]
        [TestCase(19, "XIX")]
        [TestCase(98, "XCVIII")]
        [TestCase(846, "DCCCXLVI")]
        public void ReturnRomanNumeral_WhenCalculatingRomanNumeral_GivenArabicNumber(int arabicNumber, string expectedRomanNumeral)
        {
            var romanNumeralCalculator = new RomanNumeralCalculator();

            var romanNumeral = romanNumeralCalculator.Calculate(arabicNumber);

            romanNumeral.Should().Be(expectedRomanNumeral);
        }
    }
}
