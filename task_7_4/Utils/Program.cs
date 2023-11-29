namespace Utils
{
    internal class Utils
    {
        public static bool IsItFormattable(object obj)
        {
            if (obj is IFormattable) return true;
            return false;
        }
    }
    internal class Test
    {
        static void Main(string[] args)
        {
            int x = 0;
            ulong y = 0;
            string z = "x";
            Console.WriteLine(Utils.IsItFormattable(x));
            Console.WriteLine(Utils.IsItFormattable(y));
            Console.WriteLine(Utils.IsItFormattable(z));
        }
    }
}