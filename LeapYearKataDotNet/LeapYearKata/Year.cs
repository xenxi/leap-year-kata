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

            return IsDivisibleBy(4) && IsNotDivisibleBy(100);
        }

        private bool IsNotDivisibleBy(int number) => !IsDivisibleBy(number);

        private bool IsDivisibleBy(int number) => value % number == 0;
    }
}