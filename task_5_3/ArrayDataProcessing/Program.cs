namespace ArrayDataProcessing
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
            int totalSum = 0;
            int totalCount = 0;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            (int i, int j) minIndex = (1 , 2);
            (int i, int j) maxIndex = (1, 2);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if(result[i, j] < min)
                    {
                        min = result[i, j];
                        minIndex.i = i;
                        minIndex.j = j;
                    }
                    if (result[i, j] > max)
                    {
                        max = result[i, j];
                        maxIndex.i = i;
                        maxIndex.j = j;
                    }
                    totalSum += result[i, j];
                    totalCount ++;
                }
            }
            var average = totalSum / totalCount;
            Console.WriteLine($"Sum of all matrix elements {totalSum}"); // a
            Console.WriteLine($"Average value of the array {average}"); // b
            Console.WriteLine($"Sum of negative and positive value of the array {totalSum}"); // c
            Console.WriteLine($"Minimum value index [{minIndex.i},{minIndex.j}]"); // e
            Console.WriteLine($"Maximum value index [{maxIndex.i},{maxIndex.j}]"); // e
        }
    }
}