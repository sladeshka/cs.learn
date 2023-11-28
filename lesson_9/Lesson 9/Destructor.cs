using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Объекты этого класса регистрируют деятельность конструктора
    // при создании объекта и деструктора при его уничтожении.
    public class MemElem
    {
        public static long AllElem = 0;
        long N = 0;
        public MemElem(long key)
        {
            AllElem++;
            N = key;
            Console.WriteLine("{0} element was created. {1} in memory!", N, AllElem);
        }
        // Объявление деструктора.
        ~MemElem()
        {
            AllElem--;
            Console.WriteLine("{0} was destroyed by GC. {1} in memory!", N, AllElem);
        }
    }
}
