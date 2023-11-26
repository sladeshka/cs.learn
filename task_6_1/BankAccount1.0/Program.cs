namespace BankAccount1._0
{
    class CreateAccount
    {
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account number   : ");
            long number = long.Parse(Console.ReadLine());

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(number, balance);

            return created;
        }

        static void Write(BankAccount bankAccount)
        {
            Console.WriteLine($"Account number is {bankAccount.getNumber()}");
            Console.WriteLine($"Account balance is {bankAccount.getBalance()}");
            Console.WriteLine($"Account type is {bankAccount.getType()}");
        }
    }

    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        public void Populate(long number, decimal balance)
        {
            accNo = number;
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
    }

    enum AccountType
    {
        Checking,
        Deposit
    }
}