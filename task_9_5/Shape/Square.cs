using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Square : Rectangle
    {
        #region Constructors
        public Square(double sides) : base(sides, sides) { }
        #endregion
    }
}
