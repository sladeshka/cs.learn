using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tr_Point
{
    struct Point
    {
        /*
         Цель структур - хранение значений данных.
         Для них не может быть объявлен базовый тип
         неявно наследуются от System.ValueType
         От типа struct не могут быть унаследованы другие типы struct (неявно запечатаны)
         */
        public double x;
        public double y;

        public Point(double xd, double yd)
        {
            x = xd;
            y = yd;
        }

        // public Point (double xd, double yd)=> (x, y) = (xd, yd);

        public void Mov(double x, double y) // removed body and this not worked
        {
            // здесь может быть сложная логика перемещения
            //x += xx;
            //y += yy;
        }

        public override string ToString()
        {
            return $"x{x} y {y}";
        }
    }

    class Circle
    {
        Point oCenter;
        double rd;


        double area;
        public double Area // свойство
        {
            get
            {
                return area = Math.PI * rd * rd; 
            }
        }

        public Circle (Point pa, double rd)
        {
            oCenter = pa;
            this.rd = rd;
         
        }

        public double getArea() // метод
        {
            return Math.PI * rd * rd;
        }

        public void Mov(double xx, double yy)
        {
            oCenter.Mov(xx, yy);
        }

        public override string ToString()
        {
            return String.Format("Окружность в центре {0}:{1}, радиусом {2}", oCenter.x, oCenter.y, rd);
        }
   }
}
