using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Polygon : Shape
    {
        #region Fields
        protected double[] Sides;
        protected Сoordinate[] Coordinates;
        #endregion

        #region Methods
        public abstract void SetArea();
        public void SerPerimeter()
        {
            this.Perimeter = Sides.Sum();
        }
        public dynamic GetSides()
        {
            if(Sides.Length == 3)
            {
                return (sideA: Sides[0], sideB: Sides[1], sideC: Sides[2]);
            }
            if (Sides.Length == 4)
            {
                return (sideA: Sides[0], sideB: Sides[1], sideC: Sides[2], sideD: Sides[3]);
            }
            return null;
        }
        public void Rotation(int alpha)
        {
            double angleRadian = alpha * Math.PI / 180;
            for (int point = 0; point < this.Coordinates.Length; point++)
            {
                Coordinates[point].x = (double)((Coordinates[point].x - 0) * Math.Cos(angleRadian) - (Coordinates[point].y - 0) * Math.Sin(angleRadian) + 0);
                Coordinates[point].y = (double)((Coordinates[point].x - 0) * Math.Sin(angleRadian) + (Coordinates[point].y - 0) * Math.Cos(angleRadian) + 0);
            }
        }
        public override string ToString()
        {
            string sidesToString = "";
            int sideN = 0;
            foreach (var side in Sides)
            {
                sidesToString += (SidesEnum)sideN + " = " + side.ToString() + "  ";
                sideN++;
            }

            string coordinatesToString = "";
            int coordinateN = 0;
            foreach (var coordinates in Coordinates)
            {
                coordinatesToString += $"Point {((Points)coordinateN)} = (x : {coordinates.x}, y : {coordinates.y}) and ";
                coordinateN++;
            }

            return base.ToString() + $"Sides: {sidesToString} \n Coordinates {coordinatesToString}\n";
        }
        #endregion
    }

    public enum SidesEnum
    {
        sideA, sideB, sideC, sideD
    }

    public enum Points
    {
        A, B, C, D
    }

    public struct Сoordinate
    {
        public double x;
        public double y;
        public Сoordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

}
