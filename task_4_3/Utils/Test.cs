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
            int f;
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());
            bool ok = Utils.Factorial(x, out f);
            if(ok)
            {
                Console.WriteLine($"Factorial({x}) = {f}");
            } else {
                Console.WriteLine("Cannot compute this factorial");
            }
        }
    }
}
