namespace TasksReturnsValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<DateTime> task=Task.Run( GetValue);

            // Console.WriteLine(task);  //Prints task object

            //Console.WriteLine(task.Result); //block thread until result is ready

            Console.WriteLine(task.GetAwaiter().GetResult());
        }

        private static DateTime GetValue()=>DateTime.Now;
       
    }
}
