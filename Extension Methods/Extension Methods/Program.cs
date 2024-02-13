namespace Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DateTime Example
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine($"Date Time now is: {dateTime}");

            //dateTime.AddDays(4);

            //Console.WriteLine($"Today is: {dateTime.DayOfWeek}");

            ////Console.WriteLine($"Is WeekDay? {DateTimeHelper.IsWeekDay(dateTime)}");
            ////Console.WriteLine($"Is WeekEnd? {DateTimeHelper.IsWeekEnd(dateTime)}");  

            //Console.WriteLine($"Is WeekDay? {DateTimeExtensions.IsWeekDay(dateTime)}");
            //Console.WriteLine($"Is WeekEnd? {DateTimeExtensions.IsWeekEnd(dateTime)}");

            //Console.WriteLine($"Is WeekDay? {dateTime.IsWeekDay()}");
            //Console.WriteLine($"Is WeekEnd? {dateTime.IsWeekEnd()}");
            #endregion

            #region Pizza Example (Chaining)
            Pizza p = new Pizza();

            //p = PizzaExtensions.AddDough(PizzaExtensions.AddSauce(PizzaExtensions.AddCheeze(PizzaExtensions.AddToppings(p, "black olives", 3.5m), true)), "thin");

            p.AddDough("thin")
              .AddSauce()
              .AddCheeze(true)
              .AddToppings("black olives", 3.5m);

            Console.WriteLine(p);
            #endregion

        }
    }
}
