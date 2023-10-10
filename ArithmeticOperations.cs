using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13_net
{
    public delegate double ArithmeticOperation(double x, double y);


    public class ArithmeticOperations
    {

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        
        public static double PerformOperation(ArithmeticOperation operation, double x, double y)// Метод для выполнения операции через делегат
        {
            return operation(x, y);
        }
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        public static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        public static bool IsFibonacci(int n)
        {
            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }

        
        private static bool IsPerfectSquare(int x)// Метод для проверки наличия квадратного корня
        {
            int sqrt = (int)Math.Sqrt(x);
            return sqrt * sqrt == x;
        }
    }
}

