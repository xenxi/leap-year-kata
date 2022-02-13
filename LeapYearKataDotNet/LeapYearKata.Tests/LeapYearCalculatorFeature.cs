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
    }
}