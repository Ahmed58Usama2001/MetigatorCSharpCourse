namespace CARaceCondition;

class Program
{
    static void Main(string[] args)
    {
        var wallet = new Wallet("Ahmed", 50);

        Thread th1 = new Thread(() => wallet.Debit(40));
        Thread th2 = new Thread(() => wallet.Debit(30));

        th1.Start();
        th2.Start();

        th1.Join();
        th2.Join();


    }
}

class Wallet
{
    private readonly object _lock = new object();

    public Wallet(string name, int bitcoins)
    {
        Name = name;
        Bitcoins = bitcoins;
    }

    public string Name { get; private set; }
    public int Bitcoins { get; private set; }


    public void Debit(int amount)
    {
        lock (_lock)
        {
            if (Bitcoins >= amount)
            {
                Thread.Sleep(1000);
                Bitcoins -= amount;
            }
            Console.WriteLine(this);
        }
    }

    public void Credit(int amount)
    {
        Thread.Sleep(1000);
        Bitcoins += amount;

        Console.WriteLine(this);

    }



    public override string ToString()
    {
        return $"[{Name} -> {Bitcoins} Bitcoins]";
    }
}

