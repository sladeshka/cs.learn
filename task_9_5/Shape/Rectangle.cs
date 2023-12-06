using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle : Polygon
    {
        #region Constructors
        public Rectangle(double sides) : this(sides, sides)
        {
        }
        public Rectangle(double sideAB, double sideBC)
        {
            this.Sides = new[] { sideAB, sideBC, sideAB, sideBC };
            Coordinates = new[] {
                new Сoordinate(-(sideAB/2), (sideBC/2)),
                new Сoordinate((sideAB / 2), (sideBC / 2)),
                new Сoordinate((sideAB / 2), -(sideBC / 2)),
                new Сoordinate(-(sideAB / 2), -(sideBC / 2))
            };
            SerPerimeter();
            SetArea();
        }
        #endregion

        #region Methods
        public override void SetArea()
        {
            this.Area = this.Sides[0] * this.Sides[1];
        }
        #endregion
    }
}
