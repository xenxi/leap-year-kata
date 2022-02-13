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
            if (IsDivisibleBy(400))
                return true;

            return IsDivisibleBy(4) && !IsDivisibleBy(100);
        }

        private bool IsDivisibleBy(int number) => value % number == 0;
    }
}