using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Tests
{
    public class YearShould
    {
        [Test]
        public void be_leap_for_2000()
        {
            var year = new Year(2000);

            var isLeap = year.IsLeap();

            isLeap.Should().BeTrue();
        }

        [Test]
        public void not_be_leap_for_1700()
        {
            var year = new Year(1700);

            var isLeap = year.IsLeap();

            isLeap.Should().BeFalse();
        }

        [Test]
        public void not_be_leap_for_1800()
        {
            var year = new Year(1800);

            var isLeap = year.IsLeap();

            isLeap.Should().BeFalse();
        }
    }
}