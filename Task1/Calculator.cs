using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Calculator
    {
        public static bool Add(double a, double b, out double result)
        {
            result = a + b;
            return true;
        }

        public static bool Subtract(double a, double b, out double result)
        {
            result = a - b;
            return true;
        }

        public static bool Multiply(double a, double b, out double result)
        {
            result = a * b;
            return true;
        }

        public static bool Divide(double a, double b, out double result)
        {
            if (b == 0)
            {
                Console.WriteLine("You cannot divide by zero!");
                result = 0;
                return false;
            }
            result = a / b;
            return true;
        }

        public static bool Exponentiate(double a, double b, out double result)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("0^0 is undefined!");
                result = 0;
                return false;
            }
            result = Math.Pow(a, b);
            return true;
        }

        public static ulong Factorial(ulong a)
            {
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return a * Factorial(a - 1);
        }
        }
    }
}
