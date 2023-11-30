using System.Reflection.Metadata;

namespace Triangle
{
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