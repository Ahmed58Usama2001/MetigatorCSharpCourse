namespace Enumerators_Iterators
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region Equals()  

            //Employee e1 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Salary = 5000m,
            //    Department = "Web"
            //};

            //Employee e2 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Salary = 5000m,
            //    Department = "Web"
            //};

            //Employee e3 = e1;

            //Console.WriteLine(e1==e2);
            //Console.WriteLine(e1==e3);
            //Console.WriteLine(e1.Equals(e2));
            #endregion

            #region Enumerator - Yield
            //FiveIntegers fe=new FiveIntegers(1,2,3,4,5);

            //foreach (var item in fe)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region IComparable

            var temps= new List<Temperature>();
            Random rndm = new Random();

            for (int i = 0; i < 100; i++)
            {
                temps.Add(new Temperature(rndm.Next(-20, 55)));
            }

            temps.Sort();

            foreach (var item in temps)
            {
                Console.WriteLine(item.Value);
            }

            #endregion
        }
    }

}
