namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Inside Main, before calling the method, the first element is: {0}; \n\t\t\t\t the last element is: {1}",
                                    arr[0], arr[arr.Length - 1]);

            PassingRefByRef.Change(ref arr);
            Console.WriteLine("Inside Main, after calling the method, the first element is: {0}; \n\t\t\t\t the last element is: {1}",
                                    arr[0], arr[arr.Length - 1]);

            int[] my_massiv;
            MassParFefOut.enter(out my_massiv);
            MassParFefOut.process(my_massiv);

            MassParFefOut.output(my_massiv);
            foreach (int i in my_massiv)
                Console.WriteLine("m{0} ", i);


            MassParFefOut.output(ref my_massiv);

            foreach (int i in my_massiv)
                Console.WriteLine("m{0} ", i);


            IndexRange.Run(args);

            object[] array = { "q", 1, 2.2m, new int[12] };
            foreach (object i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(array.ToString());
        }
    }
}