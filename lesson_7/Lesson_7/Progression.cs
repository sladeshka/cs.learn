using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{ 
    abstract class Progression
    {
        
        public abstract void GetElement(int k);
        public void Proo() { }
    }
    class ArProg:Progression
    {
        double a1;
        double d;
        double result;
        public ArProg(double a1, double d)
        {
            this.a1 = a1;
            this.d = d;
        }
        public override void GetElement(int k)
        {
            double a = a1 + (k-1)*d;
            Console.WriteLine(k + "-й элемент арифм. прогр.=" + a);
        }

        public double GetElement2(int k)
        {
            return a1 + (k - 1) * d;
        }

        public double GetElement3(int k) => a1 + (k - 1) * d;

        public void GetElement4(int k)
        {
            this.result = a1 + (k - 1) * d;
        }

        public override string ToString()
        {
            return "$Искомый элемент = " + this.result;
        }
    }
    class GeomProg : Progression
    {
        double b;
        double q;
        public GeomProg(double b, double q)
        {
            this.b = b;
            this.q = q;
        }
        public override void GetElement(int k)
        {
            b = b * Math.Pow(q, (k - 1));
            Console.WriteLine(k + "-й элемент геом. прогр.=" + b);
        }

    }
}
