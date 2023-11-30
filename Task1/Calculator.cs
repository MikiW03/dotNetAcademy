using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Exponentiate(double a, double b)
        {
            return Math.Pow(a, b);
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
