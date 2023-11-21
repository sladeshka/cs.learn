using System;

namespace A._1
{
    internal class Program
    {
        private static double Sqrt(double value)
        {
            double x = 1;
            double oldx;
            do
            {
                oldx = x;
                x = (x + value / x) / 2;
            }
            while (oldx != x);
            return x;
        }
        public static void Main()
        {

            double target = 2023;
            double x = Sqrt(target);
            Console.WriteLine(x);
            Console.WriteLine(x * x);
        }
    }
}