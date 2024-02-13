namespace Finalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeSomeGarbage();
            Console.WriteLine($"Memory before collecting is {GC.GetTotalMemory(false):N0}");
            GC.Collect();
            Console.WriteLine($"Memory After collecting is {GC.GetTotalMemory(true):N0}");
        }

        static void MakeSomeGarbage()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new();
            }
        }
    }
}
