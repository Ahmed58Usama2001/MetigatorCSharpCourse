namespace Extension_Methods
{
    internal static class DateTimeExtensions
    {
        public static bool IsWeekEnd(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek==DayOfWeek.Friday;
        }

        public static bool IsWeekDay(this DateTime value)
        {
            return !IsWeekEnd(value);
        }

    }
}
