namespace Extension_Methods
{
    internal static class DateTimeHelper
    {
        public static bool IsWeekEnd(DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek==DayOfWeek.Friday;
        }

        public static bool IsWeekDay(DateTime value)
        {
            return !IsWeekEnd(value);
        }

    }
}
