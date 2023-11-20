namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            double y;
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());

            double x = x1;
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("{0:0.00}\t{1:0.00}", x, y);
                x += 0.01;
            }
            while (x <= x2);

            // 2
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                // ternary with discards
                // https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/functional/discards#a-standalone-discard
                _ = a > b ? a -= b : b -= a;
            }
            int nod = a;
            Console.WriteLine("nod = " + nod);
        }
    }
}