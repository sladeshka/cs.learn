using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            Circle circle = new(5.00);
            Console.WriteLine(circle);
            //Triangle triangle = new(5.00);
            //Console.WriteLine(triangle);
            Rectangle square = new(5.00);
            Console.WriteLine(square);
            square.Rotation(360);
            Console.WriteLine(square);
            square.Rotation(15);
            Console.WriteLine(square);
            Rectangle rectangle = new(5.00, 2.00);
            Console.WriteLine(rectangle);
            rectangle.Rotation(360);
            Console.WriteLine(rectangle);
        }
    }
}
