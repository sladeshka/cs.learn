using System.Security.Principal;

namespace StructType
{
    public enum AccountType { 
        Checking, 
        Deposit 
    }
    public struct BankAccount
    {
        // refactoring
        public BankAccount(long accNo, decimal accBal, AccountType accType) {
            this.accNo = accNo;
            this.accBal = accBal;
            this.accType = accType;

        }
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            //BankAccount goldAccount;
            //goldAccount.accNo  = 123;
            //goldAccount.accBal = 3200.00m;
            //goldAccount.accType = AccountType.Checking;
            //refactoring
            //BankAccount goldAccount = new BankAccount(accountNumber, 3200.00m, AccountType.Checking); 
            try
            {
                Console.Write("Enter account number: ");
                long accountNumber = long.Parse(Console.ReadLine());
                BankAccount goldAccount = new BankAccount(accountNumber, 3200.00m, AccountType.Checking);
                Console.Write($"Acct Number {goldAccount.accNo}\nAcct Type {goldAccount.accType}\nAcct Balance {goldAccount.accBal}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"An format exception was thrown: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }

        }
    }
}