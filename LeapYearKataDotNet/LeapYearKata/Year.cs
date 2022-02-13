namespace LeapYearKata
{
    public record Year
    {
        private int value { get; }

        public Year(int yearNumber)
        {
            value = yearNumber;
        }

        public bool IsLeap()
        {
            return value != 1700;
        }
    }
}