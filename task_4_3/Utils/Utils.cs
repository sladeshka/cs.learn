namespace Utils
{
    internal class Utils
    {
        public static bool Factorial(int n, out int answer)
        {
            int f = 1;
            bool ok = true;
            {
                try
                {
                    checked {
                        for (int k = 2; k <= n; ++k)
                        {
                            f *= k;
                        }
                    }
                }
                catch (Exception e)
                {
                    f = 0;
                    ok = false;
                }

            }
            answer = f;
            return ok;
        }
    }
}