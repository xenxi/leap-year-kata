namespace LeapYearKata
{
    public record Year
    {
        private readonly int _value;

        public Year(int yearNumber)
        {
            _value = yearNumber;
        }

        public bool IsLeap()
        {
            if (IsDivisibleBy(400))
                return true;

            return IsDivisibleBy(4) && IsNotDivisibleBy(100);
        }

        private bool IsNotDivisibleBy(int number) => !IsDivisibleBy(number);

        private bool IsDivisibleBy(int number) => _value % number == 0;
    }
}