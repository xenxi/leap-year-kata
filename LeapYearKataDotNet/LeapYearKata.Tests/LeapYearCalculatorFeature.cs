using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Tests
{
    public class LeapYearCalculatorFeature
    {
        private LeapYearCalculator calculator;

        [TestCase(2008)]
        [TestCase(2012)]
        [TestCase(2016)]
        public void be_leap_if_is_divisible_by_4_and_not_by_100(int yearNumber)
        {
            var calculator = new LeapYearCalculator();

            var isLeap = calculator.Isleap(yearNumber);

            isLeap.Should().BeTrue();
        }

        [TestCase(2000)]
        [TestCase(1600)]
        [TestCase(1200)]
        public void be_leap_if_is_divisible_by_400(int yearNumber)
        {
            var isLeap = calculator.Isleap(yearNumber);

            isLeap.Should().BeTrue();
        }

        [TestCase(1700)]
        [TestCase(1800)]
        [TestCase(1900)]
        public void not_be_leap_if_is_divisible_by_100_and_not_by_400(int yearNumber)
        {
            var isLeap = calculator.Isleap(yearNumber);

            isLeap.Should().BeFalse();
        }
        [SetUp]
        public void SetUp()
        {
            calculator = new LeapYearCalculator();
        }
    }
}