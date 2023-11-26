using System;

namespace BankAccount3._0
{
    class CreateAccount
    {
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts);
            Write(berts);
            TestWithdraw(berts);
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds);
            Write(freds);
            TestWithdraw(freds);
            Write(freds);
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            //Console.Write("Enter the account number   : ");
            //long number = BankAccount.NextNumber();

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(balance);

            return created;
        }

        static void Write(BankAccount bankAccount)
        {
            Console.WriteLine($"Account number is {bankAccount.getNumber()}");
            Console.WriteLine($"Account balance is {bankAccount.getBalance()}");
            Console.WriteLine($"Account type is {bankAccount.getType()}");
        }

        public static void TestDeposit(BankAccount bankAccount)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            bankAccount.Deposit(amount);
        }

        public static void TestWithdraw(BankAccount bankAccount)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            bankAccount.Withdraw(amount);
        }
    }

    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }

        public long getNumber()
        {
            return accNo;
        }

        public decimal getBalance()
        {
            return accBal;
        }

        public string getType()
        {
            return accType.ToString();
        }

        private static long NextNumber()
        {
            return nextAccNo++;
        }

        public decimal? Deposit(decimal amount)
        {
            try
            {
                if (amount >= 0)
                {
                    accBal += amount;
                    return accBal;
                }
                else
                {
                    throw new Exception("The deposit cannot be negative");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool Withdraw(decimal amount)
        {
            try
            {
                bool sufficientFunds = checkFunds(amount);
                if (sufficientFunds)
                {
                    accBal -= amount;
                    return sufficientFunds;
                } 
                else
                {
                    throw new Exception("Insufficient funds.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        private bool checkFunds(decimal amount)
        {
            return accBal >= amount;
        }
    }

    enum AccountType
    {
        Checking,
        Deposit
    }
}