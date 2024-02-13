using System.Diagnostics;

namespace CAProcessAndThred;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Process Id: {Process.GetCurrentProcess().Id}");
        Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"Processor Id: {Thread.GetCurrentProcessorId()}");
    }
}
