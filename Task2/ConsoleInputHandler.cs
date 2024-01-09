using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ConsoleInputHandler
    {
        public int GetIntFromConsole(string message)
        {
            while (true)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                var isInputCorrect = int.TryParse(input, out var number);
                if (isInputCorrect)
                {
                    return number;
                }
                Console.WriteLine("Wrong input!");
            }
        }

        public uint GetPositiveIntFromConsole(string message)
        {
            while (true)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                var isInputCorrect = uint.TryParse(input, out var number);
                if (isInputCorrect)
                {
                    return number;
                }
                Console.WriteLine("Wrong input!");
            }
        }

        public DateTime GetFutureDateFromConsole(string message)
        {
            while (true)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                var isInputCorrect = DateTime.TryParse(input, out var date);
                if(date < DateTime.Now)
                {
                    isInputCorrect = false;
                }
                if (isInputCorrect)
                {
                    return date;
                }
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
