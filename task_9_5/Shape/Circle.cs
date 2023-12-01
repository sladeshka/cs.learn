using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Shape
    {
        #region Fields
        double Radius;
        #endregion

        #region Constructors
        public Circle(double radius) {
            this.Radius = radius;
            SerPerimeter();
            SetArea();
        }
        #endregion

        #region Methods
        public void SetArea()
        {
            this.Area = Math.PI * Math.Pow(this.Radius, 2);
        }
        public void SerPerimeter()
        {
            this.Perimeter = 2 * Math.PI * this.Radius;
        }
        public override string ToString()
        {
            return base.ToString() + $"Radius: {Radius} \n";
        }
        #endregion
    }
}
