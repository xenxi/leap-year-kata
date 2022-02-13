using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Tests
{
    public class YearShould
    {
        [TestCase("2000")]
        [TestCase("2008")]
        public void be_leap(int yearNumber)
        {
            var year = new Year(yearNumber);

            var isLeap = year.IsLeap();

            isLeap.Should().BeTrue();
        }

        [TestCase("1700")]
        [TestCase("1800")]
        public void not_be_leap(int yearNumber)
        {
            var year = new Year(yearNumber);

            var isLeap = year.IsLeap();

            isLeap.Should().BeFalse();
        }
    }
}