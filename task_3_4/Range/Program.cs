namespace Range
{
    public class Target
    {
        //private List<string> Hits = new List<string>();
        private int[] Points;
        private int ammo;
        public bool hasAmmo()
        {
            return ammo != 0;
        }
        public Target(int ammo)
        {
            this.ammo = ammo;
            this.Points = new int[ammo + 1];
        }
        public Target(){}
        public void Shot(int x, int y){
            //this.Hits.Add($"{x}, {y}");
            switch(Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2)))
            {
                case < 1.0:
                    this.Points[this.ammo] = 10; break;
                case < 2.0:
                    this.Points[this.ammo] = 5; break;
                case < 3.0:
                    this.Points[this.ammo] = 1; break;
                default:
                    this.Points[this.ammo] = 0; break;
            }
            this.ammo--;
        }
        public int GetPoints() {
            return Points.Sum();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            try
            {
                Console.Write("Enter Ammo:");
                int ammo = int.Parse(Console.ReadLine());
                Target target = new Target(ammo);
                if(ammo == 0)
                {
                    throw new ApplicationException("Zero ammo selected");
                }
                do
                {
                    Console.Write("Enter x:");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter y:");
                    int y = int.Parse(Console.ReadLine());
                    target.Shot(x, y);
                } while (target.hasAmmo());
                Console.WriteLine($"Points {target.GetPoints()}");
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
                goto start;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong, start over");
                goto start;
            }
            
        }
    }
}