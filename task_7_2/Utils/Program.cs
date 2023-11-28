namespace Utils
{
    internal class Utils
    {
        public static void Revers(ref string s)
        {
            string SRev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                SRev += s[i];
            }
            s = SRev;
        }
    }
}