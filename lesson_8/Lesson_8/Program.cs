using EmployeeApp;

namespace Lesson_8
{
    internal class Program
    {
        class Counter
        {
            //private int counter;
            //public void SetCounter(int counter)
            //{
            //    this.counter = counter;
            //}

            //public int GetCounter()
            //{
            //    return counter;
            //}
            public Counter()
            {
                
            }

            public Counter(int count) 
            {
                this.count = count;
            }
            private int count;
            public int counter { get => count; private set => count = value; }
            public void updateCount() {
                count++;
            }
        }
        static void Main(string[] args)
        {
            // Counter counter = new Counter();
            Counter counter = new(); // short // + 1 override
            Console.WriteLine(counter.counter);
            counter.updateCount();
            Console.WriteLine(counter.counter);
            Counter counter2 = new(0); // + 1 override


            Test<int> test = new Test<int>(new int[] { 1, 2, 4, 5, 6 });
            Test<string> test2 = new Test<string>(new string[] { "13433", "342454", "21432" });

            Console.WriteLine(test);
            Console.WriteLine(test2);

            //object[] obj = { 2, 2.2f, "2.2"};
            //int x = obg[0]; error
            //int x = (int)obj[0];
            //int y = (int)obj[2];
            //Console.WriteLine(obj.ToString());
        }
    }
    class Test<T>
    {
        T[] data;

        public Test()
        {
        }
        public Test(T[] data)
        {
            this.data = data;
        }
    }
}