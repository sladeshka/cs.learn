namespace Divider
{
    internal class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer");
                string temp = Console.ReadLine();
                var i = Int32.Parse(temp);

                Console.WriteLine("Please enter the second integer");
                temp = Console.ReadLine();
                var j = Int32.Parse(temp);

                double k = i / j;
                Console.WriteLine($"{k} Result dividing first {i} and second {j} value");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"An format exception was thrown: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }

        }
    }
}