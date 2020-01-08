using System;
using System.Windows.Forms;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************");
            Console.WriteLine("Welcome to My rocking App");
            Console.WriteLine("*************");
            Console.BackgroundColor = ConsoleColor.Black;

            // Wait for Enter key to be pressed.
            Console.ReadLine();
            MessageBox.Show("All done!");
        }
    }
}
