namespace СonvertorDistanceToNonMetricSystems
{
    public struct NonMetricSystems
    {
        public NonMetricSystems(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;  
        }
        public int feet;
        public int inch;
    }

    internal class Distance
    {
        public static NonMetricSystems calculate(int inch) {
            return new NonMetricSystems(inch / 12, inch % 12);    
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.Write("Enter inch for convert: ");
                int inch = int.Parse(Console.ReadLine());
                NonMetricSystems distance = Distance.calculate(inch);
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