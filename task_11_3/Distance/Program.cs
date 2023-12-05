namespace Distance
{
    public class Distance
    {
        #region Fields        
        public int feet = 0;
        public double inch = 0;
        #endregion

        #region Constructor
        public Distance(int feet, double inch)
        {
            this.feet += feet + (int)((this.inch + inch) / 12);
            this.inch = (this.inch + inch) % 12;
        }
        public static Distance operator +(Distance first, Distance second)
        {
            return new Distance(first.feet + second.feet, first.inch + second.inch);
        }
        public static Distance operator -(Distance first, Distance second)
        {
            return new Distance(first.feet - second.feet, first.inch - second.inch);
        }
        public static bool operator ==(Distance first, Distance second)
        {
            return (first.inch + first.feet * 12) == (second.inch + second.feet * 12);
        }
        public static bool operator !=(Distance first, Distance second)
        {
            return (first.inch + first.feet * 12) != (second.inch + second.feet * 12);
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{feet}' - {inch}\"\n";
        }
        #endregion
    }
    internal class Program
    {
        #region Method
        static void Main(string[] args)
        {

            try
            {
                var distances = createDistance(2);
                Console.Write($"first distance {distances[0]}\n");
                Console.Write($"second distance {distances[1]}\n");
                Distance sumDistance = distances[0] + distances[1];
                Console.WriteLine(sumDistance);
                Distance diffDistance = distances[0] - distances[1];
                Console.WriteLine(diffDistance);
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

        public static Distance[] createDistance(int quantity)
        {
            int step = 0;
            int lastStep = quantity;
            var distances = new Distance[quantity];
            do
            {
                Console.Write("Enter inch:");
                double inch = double.Parse(Console.ReadLine());
                Console.Write("Enter feet:");
                int feet = int.Parse(Console.ReadLine());
                Console.WriteLine("and");
                distances[step] = new Distance(feet, inch);
                step++;
            } while (step != lastStep);
            return distances;
        }
        #endregion
    }
}