using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinate
{
    interface IPrintable
    {
        void Print();
    }
    internal class Utils
    {
        public static void Display(object obj)
        {
            IPrintable ip = (obj as IPrintable);
            if (ip != null)
            {
                ip.Print();
            } 
            else
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }

    class Coordinate : IPrintable
    {
        private double x;
        private double y;

        public Coordinate()
        {
            x = 0.0;
            y = 0.0;
        }

        public void Print()
        {
            Console.WriteLine($"({x},{y})");
        }
    }
}
