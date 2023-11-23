using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            int y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine($"The greater of the two {greater}");
        }
    }
}
