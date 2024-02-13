using System.Collections;

namespace StackAndQueue;

public class Program
{
    static void Main(string[] args)
    {
        #region Stack Example
        //Stack<Command> redo = new Stack<Command>();
        //Stack<Command> undo = new Stack<Command>();

        //string line;

        //while (true)
        //{
        //    Console.Write("Url ('exit' to quit): ");
        //    line = Console.ReadLine().ToLower();

        //    if (line == "exit")
        //        break;

        //    else if (line == "back")
        //    {
        //        if (undo.Count > 0)
        //        {
        //            var item = undo.Pop();
        //            redo.Push(item);
        //        }
        //        else
        //            continue;
        //    }

        //    else if (line == "forward")
        //    {
        //        if (redo.Count > 0)
        //        {
        //            var item = redo.Pop();
        //            undo.Push(item);
        //        }
        //        else
        //            continue;
        //    }

        //    else
        //        undo.Push(new Command(line));

        //    Console.Clear();

        //    Print("Back", undo);
        //    Print("Forward", redo);
        //}
        #endregion




    }

    static void Print(string name, Stack<Command> commands)
    {
        Console.WriteLine($"{name} history");
        Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
        foreach (var u in commands)
        {
            Console.WriteLine($"\t{u}");
        }
        Console.BackgroundColor = ConsoleColor.Black;
    }
}
