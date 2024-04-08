using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    public abstract class BankAccount
    {
        protected double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

        public void DisplayBalance()
        {
            Console.WriteLine($"Current balance: {balance:C}");
        }
    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(double initialBalance) : base(initialBalance) { }

        public override void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposit of {amount:C} to Savings Account successful. New Balance: {balance:C}");
        }

        public override void Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal of {amount:C} from Savings Account successful. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds in Savings Account.");
            }
        }
    }

    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(double initialBalance) : base(initialBalance) { }

        public override void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposit of {amount:C} to Current Account successful. New Balance: {balance:C}");
        }

        public override void Withdraw(double amount)
        {
            if (balance - amount >= -1000) // Overdraft limit
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal of {amount:C} from Current Account successful. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeds overdraft limit in Current Account.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANK ACCOUNT MANAGEMENT SYSTEM");

            // Account Type
            Console.WriteLine("\nChoose the Account Type: ");
            Console.WriteLine("1. Savings Account\n2. Current Account");

            int accountType;
            while (!int.TryParse(Console.ReadLine(), out accountType) || accountType < 1 || accountType > 2)
            {
                Console.WriteLine("Invalid input. Please enter a valid choice (1-2): ");
            }

            // Transaction Type
            Console.WriteLine("\nChoose the Transaction type :");
            Console.WriteLine("1. Check Balance\n2. Deposit Money\n3. Withdraw Money");

            int transactionType;
            while (!int.TryParse(Console.ReadLine(), out transactionType) || transactionType < 1 || transactionType > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid choice (1-3): ");
            }

            // Transaction (name)
            string transaction = "";
            if (transactionType == 2)
            {
                transaction = "Deposit";
            }
            else if (transactionType == 3)
            {
                transaction = "Withdraw";
            }

            // Amount to deposit/withdraw
            double amount = 0;
            if (transactionType != 1)
            {
                Console.WriteLine($"\nEnter Amount to {transaction}: ");
                while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
                {
                    Console.WriteLine($"Invalid input. Please enter a valid amount to {transaction.ToLower()}: ");
                }
            }

            // Create accounts
            if (accountType == 1)
            {
                SavingsAccount savingsAccount = new SavingsAccount(1000);

                if (transactionType == 1)
                {
                    savingsAccount.DisplayBalance();
                }
                else if (transactionType == 2)
                {
                    savingsAccount.Deposit(amount);
                }
                else
                {
                    savingsAccount.Withdraw(amount);
                }
            }
            else
            {
                CurrentAccount currentAccount = new CurrentAccount(2000);

                if (transactionType == 1)
                {
                    currentAccount.DisplayBalance();
                }
                else if (transactionType == 2)
                {
                    currentAccount.Deposit(amount);
                }
                else
                {
                    currentAccount.Withdraw(amount);
                }
            }

            Console.ReadLine();
        }
    }
}
