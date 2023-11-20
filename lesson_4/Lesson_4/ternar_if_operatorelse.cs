using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
// https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/conditional-operator	
    class Program
    {
	    static void Main(string[] args)
        {
            var rand = new Random();
            var condition = rand.NextDouble() > 0.5;

            int? x = condition ? 12 : null;
            // || int x = condition ? 12 : 0;
            Console.WriteLine(x);
        }

    }
}
