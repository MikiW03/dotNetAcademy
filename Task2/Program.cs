using System.Reflection;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            var car1 = new Cargo("Volvo", "FH16", 2019, "White", 100_000, "AB1234CD");
            var car2 = new Cargo("Mercedes", "FH16", 2019, "White", 100_000, "AB1234CD");

            Console.WriteLine(car1);
            Console.WriteLine(car2);
        }
    }
}