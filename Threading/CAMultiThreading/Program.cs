namespace CAMultiThreading;

class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.Name = "Main thread";
        Console.WriteLine($"Thread Name: {Thread.CurrentThread.Name}");
        //Console.WriteLine($"Thread Background?: {Thread.CurrentThread.IsBackground}");

        var wallet = new Wallet("Ahmed's wallet", 100);

        Thread thread1 = new Thread(wallet.RunRandomTransactions);
        thread1.Name = "T1";
        Console.WriteLine($"Thread Name: {thread1.Name}");
        //Console.WriteLine($"Thread Background?: {thread.IsBackground}");

        Console.WriteLine($"After declaration: {thread1.ThreadState}");

        thread1.Start();
        Console.WriteLine($"After start: {thread1.ThreadState}");
        thread1.Join();

        Thread thread2 = new Thread(wallet.RunRandomTransactions);
        thread2.Name = "T2";
        Console.WriteLine($"Thread Name: {thread2.Name}");
        //Console.WriteLine($"Thread Background?: {thread.IsBackground}");

        Console.WriteLine($"After declaration: {thread2.ThreadState}");

        thread2.Start();
        Console.WriteLine($"After start: {thread2.ThreadState}");

    }
}

class Wallet
{
    public Wallet(string name, int bitcoins)
    {
        Name = name;
        Bitcoins = bitcoins;
    }

    public string Name { get; private set; }
    public int Bitcoins { get; private set; }


    public void Debit(int amount)
    {
        Thread.Sleep(1000);
        Bitcoins -= amount;

        Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId} - {Thread.CurrentThread.Name}" +
                $", Processor Id: {Thread.GetCurrentProcessorId()}] -{amount}");
    }

    public void Credit(int amount)
    {
        Thread.Sleep(1000);
        Bitcoins += amount;

        Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId} - {Thread.CurrentThread.Name}" +
                $", Processor Id: {Thread.GetCurrentProcessorId()}] +{amount}");
    }

    public void RunRandomTransactions()
    {
        int[] amounts = { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20 }; // 80

        foreach (var amount in amounts)
        {
            var absValue = Math.Abs(amount);
            if (amount < 0)
                Debit(absValue);
            else
                Credit(absValue);
            
        }
    }

    public override string ToString()
    {
        return $"[{Name} -> {Bitcoins} Bitcoins]";
    }
}
