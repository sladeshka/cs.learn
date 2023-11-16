using System;
using System.Data;

namespace Triangle
{
    internal class Program
    {
        public struct Triangle
        {
            public static string Side = "Сторона";
            public static string Area = "Площадь";


        }
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Please enter the perimeter value");
            //    var temp = Console.ReadLine();
            //    double Perimeter = double.Parse(temp);
            //    double p = Perimeter / 2;
            //    double l = Perimeter / 3, a = l, b = l, c = l;
            //    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //    l = Math.Round(l, 2);
            //    S = Math.Round(S, 2);
            //    Console.WriteLine(@$"
            //        Сторона Площадь 
            //        {l} {S}");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine($"An format exception was thrown: {e.Message}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("An exception was thrown: {0}", e.Message);
            //}
            // refactoring
            try
            {
                Console.WriteLine("Please enter the perimeter value");
                double Perimeter = double.Parse(Console.ReadLine());
                double l = Perimeter / 3, 
                       p = Perimeter / 2, 
                       S = Math.Sqrt(p * Math.Pow((p - l), 3));
                Console.WriteLine($"{Triangle.Side,7} | {Triangle.Area,7}");
                Console.WriteLine($"{Math.Round(l, 2),7} | {Math.Round(S, 2),7}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"An format exception was thrown: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }

        }
    }
}