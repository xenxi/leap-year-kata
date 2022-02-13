namespace LeapYearKata
{
    public class LeapYearCalculator
    {
        public bool Isleap(int yearNumber)
        {
            var year = new Year(yearNumber);

            return year.IsLeap();
        }
    }
}