using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Tests
{
    public class LeapYearCalculatorFeature
    {
        [TestCase(2000)]
        [TestCase(1600)]
        [TestCase(1200)]
        public void be_leap_if_is_divisible_by_400(int yearNumber)
        {
            var calculator = new LeapYearCalculator();

            var isLeap = calculator.Isleap(yearNumber);

            isLeap.Should().BeTrue();
        }

        [TestCase(1700)]
        [TestCase(1800)]
        [TestCase(1900)]
        public void not_be_leap_if_is_divisible_by_100_and_not_by_400(int yearNumber)
        {
            var calculator = new LeapYearCalculator();

            var isLeap = calculator.Isleap(yearNumber);

            isLeap.Should().BeFalse();
        }
    }
}