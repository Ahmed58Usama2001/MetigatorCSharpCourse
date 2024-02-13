namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1=new Money(10);
            Money m2=new Money(20);

            Money m3 = m1 + m2;

            Console.WriteLine(m3.Amount);
        }

        public class Money
        {
            private double amount;

            public double Amount => amount;

            public Money(double amount) 
            {
            this.amount = amount;            
            }


            public static Money operator +(Money lhs, Money rhs)
            {
                var value =lhs.Amount + rhs.Amount;

                return new Money(value);

            }


        }
    }
}
