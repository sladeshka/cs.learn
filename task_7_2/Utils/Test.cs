using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Test
    {
        static void Main()
        {
            Console.WriteLine("Enter string to reverse:");
            string message = Console.ReadLine();
            Utils.Revers(ref message);
            Console.WriteLine(message);
        }
    }
}
