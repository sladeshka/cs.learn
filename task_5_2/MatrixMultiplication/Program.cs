namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main()
        {
            int[,] a = Input();
            int[,] b = Input();
            int[,] result = Multiply(a, b);
            Output(result);
        }

        private static int[,] Input()
        {
            int[,] a = new int[2, 2];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        private static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] += a[i, 0] * b[0, j] + a[i, 1] * b[1, j];
                }
            }
            return result;
        }

        private static void Output(int[,] result)
        {
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for(int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j]} ");
                }
                
            }
        }
    }
}