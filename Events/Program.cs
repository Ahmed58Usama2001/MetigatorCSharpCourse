namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock=new Stock("Amazon");
            stock.Price = 100;

            stock.OnPriceChanged += PriceChangedHandler; //Subscribe

            stock.ChangePriceBy(-0.02m);
            stock.ChangePriceBy(0.03m);
            stock.ChangePriceBy(0);

            stock.OnPriceChanged -= PriceChangedHandler;
            stock.ChangePriceBy(-0.02m);
            stock.ChangePriceBy(0.03m);

        }

        private static void PriceChangedHandler(Stock stock, decimal oldPrice)
        {
            string result;
            if(stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = "up";
            }
            else if (stock.Price<oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result = "down";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                result = "stable";
            }
            Console.WriteLine($"{stock.Name}: {stock.Price}-{result}");

        }
    }


    public delegate void PriceChangeHandler(Stock stock, decimal oldPrice); //the Channel which i publish and subscribe

    public class Stock
    {
        private string name;
        private decimal price;

        public string Name=>this.name;

        public decimal Price { get => this.price; set => price = value; }

        public event PriceChangeHandler OnPriceChanged;  //publisher

        public Stock(string _name)
        {
            this.name = _name;
        }

        public void ChangePriceBy(decimal percent)
        {
            decimal oldPrice=this.price;
            this.price +=Math.Round(percent*this.price,2);

            if(OnPriceChanged!= null)
                OnPriceChanged(this,oldPrice); //Firing Event
        }
    }

}