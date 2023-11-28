using System;

namespace BankAccount4._0
{
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

        public void TransferFrom(BankAccount bankAccount, decimal amount)
        {
            if (bankAccount.Withdraw(amount))
            {
                this.Deposit(amount);
            }
        }
    }

    enum AccountType
    {
        Checking,
        Deposit
    }
}