namespace BankAccount
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
    }

    enum AccountType
    {
        Checking,
        Deposit
    }
}