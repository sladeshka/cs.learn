namespace СonvertorDistanceToNonMetricSystems
{
    public struct Distance
    {
        public Distance(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public int feet = 0;
        public int inch = 0;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int step = 0;
                int lastStep = 2;
                Distance distance = new Distance(0, 0);
                do {
                    Console.Write("Enter inch:");
                    int inch = int.Parse(Console.ReadLine());
                    Console.Write("Enter feet:");
                    int feet = int.Parse(Console.ReadLine());
                    distance.feet += feet + (distance.inch + inch) / 12;
                    distance.inch = (distance.inch + inch) % 12;
                    Console.WriteLine("and");
                    step++; 
                } while (step != lastStep);

                Console.Write($"{distance.feet}' - {distance.inch}\"");
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