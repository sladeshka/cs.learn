namespace Shape
{
    internal class Triangle : Polygon
    {
        #region Constructors
        public Triangle(double sideABC) : this (sideABC, sideABC, sideABC) { }
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.Sides = new[] { sideA, sideB, sideC };
            SerPerimeter();
            SetArea();
        }
        #endregion

        #region Methods
        public bool isTriangle()
        {
            var sideA = Sides[0];
            var sideB = Sides[1];
            var sideC = Sides[2];
            bool hasThreeSides = Sides.Length == 3;
            bool isTriangle = ((sideA + sideB) > sideC) && ((sideA + sideC) > sideB) && ((sideB +sideC) > sideA);
            return hasThreeSides && isTriangle;
        }
        public bool Equals(Triangle other)
        {
            return Sides[0] == other.Sides[0] && Sides[1] == other.Sides[1] && Sides[2] == other.Sides[2];
        }

        public override void SetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            this.Area = Math.Sqrt(halfPerimeter * (halfPerimeter - Sides[0]) * (halfPerimeter - Sides[1]) * (halfPerimeter - Sides[2]));
        }
        #endregion
    }
}
