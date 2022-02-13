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
            if (value % 4 == 0 && value % 100 != 0)
                return true;

            return value % 400 == 0;
        }
    }
}