namespace Shape
{
    public abstract class Shape
    {
        #region Fields
        protected double Area;
        protected double Perimeter;
        #endregion

        #region Methods
        public double GetArea()
        {
            return Area;
        }
        public double GetPerimeter()
        {
            return Perimeter;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType()}\nArea: {Area}\nPerimeter: {Perimeter} \n";
        }
        #endregion
    }
}