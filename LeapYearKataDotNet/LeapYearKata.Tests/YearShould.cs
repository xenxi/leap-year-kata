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
    }
}