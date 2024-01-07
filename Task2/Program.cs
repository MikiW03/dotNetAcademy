using System.Reflection;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            var consoleHandler = new ConsoleMenuHandler();
            consoleHandler.HandleUserInput();
        }
    }
}