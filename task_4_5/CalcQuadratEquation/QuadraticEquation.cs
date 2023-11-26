using System;
using System.Collections.Generic;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a;
                double b;
                double c;
                double? x1;
                double? x2;
                Console.WriteLine("Please enter the first value:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second value:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the third value:");
                c = double.Parse(Console.ReadLine());
                int result = QuadraticEquation.calculate(a, b, c, out x1, out x2);
                if(result < 0) { 
                    Console.WriteLine($"Root equation with coefficients a = {a}, b = {b}, c = {a}, no result.");
                } else if(result == 0) {
                    Console.WriteLine($"Root equation with coefficients a = {a}, b = {b}, c = {a}, x1 = x2 = {x1}");
                } else {
                    Console.WriteLine($"Root equation with coefficients a = {a}, b = {b}, c = {a}, x1 = {x1} x2 = {x2}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    internal class QuadraticEquation
    {
        public static int calculate(in double a, in double b, in double c, out double? x1, out double? x2)
        {
            if(a == 0)
            {
                throw new Exception("This is not a quadratic equation");
            }
            else
            {
                double D = Math.Pow(b, 2) - 4 * a * c;
                if (D < 0) {
                    x1 = x2 = null;
                    return -1;
                } else if(D == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    return 0;
                } else
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    return 1;
                }
            }
        }
    }
}