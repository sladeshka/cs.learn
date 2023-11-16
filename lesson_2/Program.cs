// See https://aka.ms/new-console-template for more information
using System;
namespace Lesson_2
{
    public struct Order
    {
        public int price;
        public double numberPostions;
    }

    enum Status
    {
        creacte,
        finish
    }

    class Program {
        static void Main(string[] args)
        {
            bool isOk = default(bool);
            int orderNumber = 15;
            Lesson_2.Order.price = 100;
            Lesson_2.Order.numberPostions = 1;
            short k1 = 0, k2 = 0;
            short kr = k1 + k2;
            dynamic dd = 0;
            object x1 = 9;
            var x = x1 + 1;
            Console.WriteLine(@$"
                Hello, World! 
                {isOk} 
                {orderNumber.GetType()}
                {Order.GetType()}
");
        }
    }
}


