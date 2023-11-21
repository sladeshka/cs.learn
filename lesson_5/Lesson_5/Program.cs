using System;

namespace Lesson_5
{
    //internal class Program
    //{
    //    public static int Nod(int n) {  
    //        return n; 
    //    }
    //    static void Func(int x)
    //    {
    //        x += 10;	// изменили значение параметра 
    //        Console.WriteLine("In Func: " + x);
    //    }
    //    static void Main()
    //    {
    //        int a = 10;
    //        Console.WriteLine("In Main: " + a);
    //        Func(a);
    //        Console.WriteLine("In Main: " + a);
    //    }

    //}

    class LoopProgram
    {
        static void Main()
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

            //1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Nod(ref a, ref b);
            Console.WriteLine("nod = " + a);
            //2
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int z;
            NodWithOur(c, d, out z);
            Console.WriteLine("z = " + z);
            
            Console.WriteLine(isInt("123"));
            Console.WriteLine(labdaFunction("a"));
            Console.WriteLine(showLocalFunction(1));
            Console.WriteLine(paramsFunction(1, 2, 3, 4, 5, 6, 7));
            optionalFunction(posVal1: 3, namedVar3: 3);
        }

        private static void Nod(ref int a, ref int b)
        {
            while (a != b)
            {
                _ = a > b ? a -= b : b -= a;
            }
        }

        private static void NodWithOur(int a, int b, out int XZ) // z
        {
            while (a != b)
            {
                _ = a > b ? a -= b : b -= a;
            }
            XZ = a;
        }

        static bool isInt(string s)
        {
            int temp;
            return int.TryParse(s, out temp);
        }

        static bool labdaFunction(string s) => int.TryParse(s, out _);

        public static int showLocalFunction(int x)
        {
            int localFunction(int x) { return x; };
            return localFunction(x);
        }

        private static int privateFunction(int x)
        {
            return x;
        }

        public static int argumentReadOnlyFunction(in int x)
        {
            // x = 3; // error
            return x;
        }

        public static int? paramsFunction(params int[] x) // null or indefinite length {1, 2, 3, 4, 5, 6, 7} 
        {
            if (x.Length == 0)
            {
                return null;
            } 
            else
            {
                return 1;
            }
        }

        public static void optionalFunction(int posVal1, int posVal2 = 2, int namedVar3 = 3)
        {

        }

        static void arrayDeclaration()
        {
            int[] empty; // empty link. Memory not allocated.
            int[] array = new int[100];
            int[] array2 = new int[] {1, 2};
            int[] array3 = { 1, 2, 3, 4, 5 };
            int[] array4 = new int[1] { 1 };

        }
    }
}