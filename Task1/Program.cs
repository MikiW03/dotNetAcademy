namespace task1
{
    internal class Program
    {
        static void Main()
        {
            string sign = "";
            while (sign != "q")
            {
                Console.Write("Enter the sign of the operation you want to perform (+, -, *, /, ^, ! or q to quit): ");
                sign = Console.ReadLine();
                if (sign == "q") break;
                if (sign != "+" && sign != "-" && sign != "*" && sign != "/" && sign != "^" && sign != "!")
                {
                    Console.WriteLine("Invalid sign!");
                    continue;
                }

                if (!GetNumberFromConsole(out double number1)) 
                { 
                    continue;
                }

                double number2 = 0;
                if (sign != "!")
                {
                    if (!GetNumberFromConsole(out number2))
                    {
                        continue;
                    }
                }

                double result = 0;
                switch (sign)
                {
                    case "+":
                        if (!Calculator.Add(number1, number2, out result))
                        {
                            continue;
                        }
                        break;
                    case "-":
                        if (!Calculator.Subtract(number1, number2, out result))
                        {
                            continue;
                        }
                        break;
                    case "*":
                        if (!Calculator.Multiply(number1, number2, out result))
                        {
                            continue;
                        };
                        break;
                    case "/":
                        if (!Calculator.Divide(number1, number2, out result))
                        {
                            continue;
                        }
                        break;
                    case "^":
                        if (!Calculator.Exponentiate(number1, number2, out result))
                        {
                            continue; 
                        }
                        break;
                    case "!":
                        if (number1 < 0)
                        {
                            Console.WriteLine("Factorial of a negative number is undefined!");
                            continue;
                        }
                        if (!IsInteger(number1))
                        {
                            Console.WriteLine("Factorial of a non-integer number is undefined!");
                            continue;
                        }
                        if(number1 > 65)
                        {
                            Console.WriteLine("This number is too big");
                            continue;
                        }
                        result = Calculator.Factorial((ulong)number1);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Result: " + result);
                Console.WriteLine("--------------------");
            }
        }

        public static bool IsInteger(double number)
        {
            return number % 1 == 0;
        }
        
        public static bool GetNumberFromConsole(out double number)
        {
            Console.Write("Enter the number: ");
            if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number!");
                return false;
            };
            return true;
        }
    }
}