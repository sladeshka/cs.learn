using ConsoleApplication1;
using System;
using System.Xml.Linq;
using WordCount;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public Employee(string name, int id, double pay) : this(name, 20, id, pay) { } // Delegating constructor
            //public Employee(string name, int age, int id, double pay)
            //{
            //    Name = name;
            //    ID = id;
            //    Age = age;
            //    Pay = pay;
            //}
            WordCountDispose.Test();
            Console.WriteLine("Test");
            Console.ReadLine();
            MemElem mem;
            long N = 0;
            for (; ; )
            {
                Console.WriteLine("_______________");
                Console.Write("x for terminate >> ");
                string s = Console.ReadLine();
                if (s.Equals("x")) break;
                else N += 1;
                for (int i = 0; i < 50; i++)
                {
                    mem = new MemElem(N + i);
                }
            }
        }
    }
}