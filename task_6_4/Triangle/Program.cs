using System.Reflection.Metadata;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Triangle triangle = CreateTriangle();
                if (triangle.GetType() == typeof(Triangle))
                {
                    Console.WriteLine($"Triangle perimeter = {triangle.Perimeter}");
                    Console.WriteLine($"Area of a triangle = {triangle.Area}");
                    // without sides variable
                    // commented because the sides are calculated three times
                    // Console.WriteLine($"Long sides of a triangle a = {triangle.GetSides().sideA} b = {triangle.GetSides().sideB} and c = {triangle.GetSides().sideC}");
                    // with sides variable
                    var sides = triangle.GetSides();
                    Console.WriteLine($"Long sides of a triangle a = {sides.sideA} b = {sides.sideB} and c = {sides.sideC}");
                }
                // I don't understand what is needed. "Conduct an authorized installation check to see if a triangle exists with side length data.".
                // but maybe
                Console.WriteLine("Are there triangles with side length information?");
                Triangle triangle2 = CreateTriangle();
                if(triangle2.GetType() == typeof(Triangle))
                {
                    bool exists = triangle.Equals(triangle2);
                    Console.WriteLine($"Triangle {(exists ? "exists" : "not exists")}");
                }

        }

        static Triangle? CreateTriangle()
        {
            try
            {
                Console.WriteLine("Please enter the triangle side a value:");
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the triangle side b value:");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the triangle side c value:");
                double sideC = double.Parse(Console.ReadLine());
                return new Triangle(sideA, sideB, sideC);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"An format exception was thrown: {e.Message}");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }

    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double Perimeter
        {
            get { return sideA + sideB + sideC; }
        }

        public double Area
        {
            get
            {
                double halfPerimeter = Perimeter / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA; this.sideB = sideB; this.sideC = sideC;
        }
        
        public Triangle(double sideABC)
        {
            sideA = sideB = sideC = sideABC;
        }

        public (double sideA, double sideB, double sideC) GetSides()
        {
            return (sideA, sideB, sideC);
        }
        
        public bool isTriangle()
        {
            return sideA > 0 && sideB > 0 && sideC > 0;
        }

        public bool Equals(Triangle other)
        {
            return this.sideA == other.sideA && this.sideB == other.sideB && this.sideC == other.sideC;
        }
    }
}