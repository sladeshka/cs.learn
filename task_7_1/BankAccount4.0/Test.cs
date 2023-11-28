using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount4._0
{
    internal class Test
    {
        static void Main()
        {
            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.Populate(100);
            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Populate(100);
            Console.WriteLine("Before transfer");
            Console.WriteLine($"{bankAccount1.getType()} {bankAccount1.getNumber()} {bankAccount1.getBalance()}");
            Console.WriteLine($"{bankAccount2.getType()} {bankAccount2.getNumber()} {bankAccount2.getBalance()}");
            bankAccount1.TransferFrom(bankAccount2, 10);
            Console.WriteLine("After transfer");
            Console.WriteLine($"{bankAccount1.getType()} {bankAccount1.getNumber()} {bankAccount1.getBalance()}");
            Console.WriteLine($"{bankAccount2.getType()} {bankAccount2.getNumber()} {bankAccount2.getBalance()}");
        }
    }
}
