namespace TasksVSThreads;

internal class Program
{
    static void Main(string[] args)
    {
        var th = new Thread(() => Display("thread"));
        th.Start();

        Task.Run(() => Display("task"));
    }

    static void Display(string message)
    {
        ShowThreadInfo(Thread.CurrentThread);
        Console.WriteLine(message);
    }

  private static void ShowThreadInfo(Thread th)
    {
        Console.WriteLine($"TID: {th.ManagedThreadId} - IsPooledTread: {th.IsThreadPoolThread} - IsBackground:{th.IsBackground}");
    }
}
