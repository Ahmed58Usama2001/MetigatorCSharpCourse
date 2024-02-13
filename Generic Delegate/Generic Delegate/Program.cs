namespace Generic_Delegate;

internal class Program
{
    static void Main(string[] args)
    {
        #region Generic Delegate Try
        //Action<string> action = PrintName;
        //action("Ahmed");

        //Func<int, int, int> func = Add;
        //Console.WriteLine(func(3, 5));

        //Predicate<int> predicate = IsEven;
        //Console.WriteLine(predicate(1));
        #endregion

        IEnumerable<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintNumber(list1, n => n % 2 == 0, () => Console.WriteLine("My name is Ahmed"));


        IEnumerable<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintNumber(list2, n => n % 2 != 0, () => Console.WriteLine("My name is Ahmed"));

        IEnumerable<decimal> list3 = new List<decimal> { 1.225m, 2.532m, 3.2345m, 4, 5.532m, 6.32m, 7.352m, 8.325m, 9.532m };
        PrintNumber(list2, n => n >=5, () => Console.WriteLine("My name is Ahmed"));




    }

    //static void PrintName(string name) => Console.WriteLine(name);

    //static int Add(int x, int y) => x + y;

    //static bool IsEven(int n) => n % 2 == 0;

    static void PrintNumber<T>(IEnumerable<T> numbers,Predicate<T> filter,Action signature)
    {
        foreach (var number in numbers)
        {
            if (filter(number))
            {
                Console.WriteLine(number);
            }
        }
        signature();
    }

}
