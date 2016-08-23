using System;
using System.Collections.Generic;

namespace ConsoleApplication4
{
    public class InputHandler
    {
        public static List<string> GetList()
        {
            List<string> userList = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "#")
                {
                    userList.Add(input);
                }
                else
                {
                    break;
                }
            }
            return userList;
        }

        public static void DisplayListFirstLetters(List<string> list)
        {
            Console.WriteLine();

            foreach (var item in list)
            {
                try
                {
                    Console.WriteLine(item.Substring(0, 1));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    // DoNothing
                }
            }
        }
    }
}
