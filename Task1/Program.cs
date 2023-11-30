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

                Console.Write("Enter the number: ");
                if (!double.TryParse(Console.ReadLine(), out double number1))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                };


                double number2 = 0;
                if (sign != "!")
                {
                    Console.Write("Enter the second number: ");
                    if (!double.TryParse(Console.ReadLine(), out number2))
                    {
                        Console.WriteLine("Invalid number!");
                        continue;
                    };
                }

                double result = 0;
                switch (sign)
                {
                    case "+":
                        result = Calculator.Add(number1, number2);
                        break;
                    case "-":
                        result = Calculator.Subtract(number1, number2);
                        break;
                    case "*":
                        result = Calculator.Multiply(number1, number2);
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            Console.WriteLine("You cannot divide by zero!");
                            continue;
                        }
                        result = Calculator.Divide(number1, number2);
                        break;
                    case "^":
                        if (number1 == 0 && number2 == 0)
                        {
                            Console.WriteLine("0^0 is undefined!");
                            continue;
                        }
                        result = Calculator.Exponentiate(number1, number2);
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
    }
}