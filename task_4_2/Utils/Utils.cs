namespace Utils
{
    public class Utils
    {
        public static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
    }
}