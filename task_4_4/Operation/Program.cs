using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double sideA;
                double sideB; 
                double sideC;
                double area;
                Console.WriteLine("Enter triangle type (\"equilateral\" or \"not\")");
                string triangleType = Console.ReadLine();
                if (triangleType == "equilateral")
                {
                    Console.WriteLine("Please enter the triangle side value:");
                    double sideABC = double.Parse(Console.ReadLine());
                    sideA = sideB = sideC = sideABC;
                    area = Operation.calculateArea(sideA, sideB, sideC);
                }
                else if (triangleType == "not")
                {
                    Console.WriteLine("Please enter the triangle side a value:");
                    sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the triangle side b value:");
                    sideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the triangle side c value:");
                    sideC = double.Parse(Console.ReadLine());
                    area = Operation.calculateArea(sideA, sideB, sideC);
                }
                else
                {
                    throw new Exception("You specified the wrong triangle type");
                }
                Console.WriteLine($"The area of a triangle with sides a = {sideA} b = {sideB} and c = {sideC} is equal to {area}");  
            }
            catch (FormatException e)
            {
                Console.WriteLine($"An format exception was thrown: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    internal class Operation
    {
        public static double calculateArea(double sideA, double sideB, double sideC)
        {
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            if (Operation.checkIsTriangle(triangle))
            {
                return triangle.calculateArea();
            }
            else
            {
                throw new Exception("The side of a triangle cannot be zero");
            }  
        }
        // Unable to complete task, because "Any method declaration that uses the override, virtual, or abstract keyword cannot also use the static keyword."
        //public static override double calculateArea(double sideABC)
        //{
        //    ///
        //}

        private static bool checkIsTriangle(Triangle triangle)
        {
            return triangle.isTriangle();
        }
    }

    internal struct Triangle
    {
        public double sideA;
        public double sideB;
        public double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA; this.sideB = sideB; this.sideC = sideC;
        }
        public Triangle(double sideABC)
        {
            sideA = sideB = sideC = sideABC;
        }
        public double calculateArea()
        {
            double perimeter = sideA + sideB + sideC;
            double halfPerimeter = perimeter / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return area;
        }
        public bool isTriangle() 
        {
            return sideA > 0 && sideB > 0 && sideC > 0;
        }
    }
}
