namespace lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueC;
            do
            {
                int result = 1 & 2; //
                int result2 = (6 << 2) + 6; // 0110 << 1 = 0011000
                int a = 25;
                short b = (short)a;
                var result3 = 1 + 2 + "C";
                string result4 = 1 + 2 + "C";
                Console.WriteLine(result);
                Console.WriteLine(result2);
                Console.WriteLine(result3);
                Console.WriteLine(result4);

                double one = double.Parse(Console.ReadLine()); // overload + 4
                Console.WriteLine($"val {one} type {one.GetType()}");
                // compare
                double two = Convert.ToDouble(Console.ReadLine()); // overload + 17 OMG!!!
                Console.WriteLine($"val {two} type {two.GetType()}");

                object obj = 12.6;
                double convertObjToDouble = Convert.ToDouble(obj);
                Console.WriteLine(convertObjToDouble.GetType());


                Console.WriteLine();
                int three = 101;
                bool isTrue = three <= 200 == three >= 100;
                Console.WriteLine($"It is {isTrue}");

                Console.WriteLine("If you want to continue. Enter y");
                string presKey = Console.ReadLine();
                continueC = presKey.ToLower() == "y";
            } while (continueC);
            
        }
    }
}