using ConsoleApplication11;
using PersonClass;
using Tr_Point;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArProg ar1 = new ArProg(2, 4); // type cat be set to "Progression"
            Progression ge1 = new GeomProg(2, 4);
            ar1.GetElement(5);
            double x = ar1.GetElement2(5);
            Console.WriteLine(5 + "-й элемент арифм. прогр.=" + x);
            double y = ar1.GetElement3(5);
            Console.WriteLine(5 + "-й элемент арифм. прогр.=" + y);
            ar1.GetElement4(5);
            Console.WriteLine(ar1.ToString());
            ge1.GetElement(3);
            Console.ReadKey();

            Point point = new Point(0.0, 0.0);
            point.Mov(5.0, 5.0);
            Console.WriteLine(point);


            // I don’t understand where the override needs to be applied, does it make sense? If everything can be done through new.
            // Person class I change the override of the new one in the public new string ToString() method
            // I expect some error when working with the object type, but no.
            Person person = new Person("Name", "lastname");
            Console.WriteLine(person.ToString());
            Object person2 = new Person("Name", "lastname");
            Console.WriteLine(person2.ToString());
            // At the same time, new has an obvious advantage (there are no overload chains)

            Base derivedAsBase = new Derived();

            derivedAsBase.First();  // Derived.First(), выведет "First from Derived"                
            derivedAsBase.Second(); // Base.Second(), выведет "Second from Base"

            Console.ReadLine();


        }
    }

    class Base
    {
        public virtual void First()
        {
            Console.WriteLine("First from Base");
        }

        public virtual void Second()
        {
            Console.WriteLine("Second from Base");
        }
    }

    class Derived : Base
    {
        public override void First()
        {
            Console.WriteLine("First from Derived");
        }

        public new void Second()
        {
            Console.WriteLine("Second from Derived");
        }
    }
}