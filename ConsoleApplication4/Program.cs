using System;

namespace ConsoleApplication4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text");
            Console.WriteLine("After input finish enter '#'");

            var userList = InputHandler.GetList();

            InputHandler.DisplayListFirstLetters(userList);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
