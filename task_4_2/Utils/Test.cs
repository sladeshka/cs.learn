using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Test
    {
        public static void Main()
        {
            int x = 12;
            int y = 21;
            Console.WriteLine($"before swap x = {x} and y = {y}");
            Utils.Swap(ref x, ref y);
            Console.WriteLine($"after swap x = {x} and y = {y}");
        }
    }
}
