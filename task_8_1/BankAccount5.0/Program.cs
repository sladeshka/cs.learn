namespace BankAccount5._0
{
    class Test {
        static void Main()
        {
            BankAccount[] bankAccount = {
                new(),
                new(AccountType.Deposit),
                new(100),
                new(AccountType.Deposit, 500)
            };
            foreach (var bank in bankAccount)
            {
                Console.WriteLine(bank);
            }
        }
    }

    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;

        public BankAccount()
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = 0;
        }

        public BankAccount(AccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }

        public BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = aBal;
        }

        public BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
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

        public void TransferFrom(BankAccount bankAccount, decimal amount)
        {
            if (bankAccount.Withdraw(amount))
            {
                this.Deposit(amount);
            }
        }
        public override string ToString()
        {
            return $"{getType()} {getNumber()} {getBalance()}";
        }
    }

    enum AccountType
    {
        Checking,
        Deposit
    }
}