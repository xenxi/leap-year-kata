namespace LeapYearKata
{
    public class LeapYearCalculator
    {
        public LeapYearCalculator()
        {
        }

        public bool Isleap(int yearNumber)
        {
            var year = new Year(yearNumber);

            return year.IsLeap();
        }
    }
}