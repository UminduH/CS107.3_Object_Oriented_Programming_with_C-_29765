using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    internal class Program
    {
        class BankAccount
        {
            public int AccountNumber;
            public double Balance;

            public void Deposit()
            {
                Console.WriteLine("\nEnter the amount to deposit: $");
                double depositAmount;

                while (!double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                {
                    Console.WriteLine("Invalid input. Enter a valid amount to deposit: $");
                }

                Balance += depositAmount;
                Console.WriteLine($"Deposit successful. New Balance: ${Balance}");
            }
        }

        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine("Enter your account number: ");

            while (!int.TryParse(Console.ReadLine(), out myAccount.AccountNumber))
            {
                Console.WriteLine("Please enter your valid account number: ");
            }

            myAccount.Balance = 1000;   // Initial Balance

            Console.WriteLine($"\nAccount Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: ${myAccount.Balance}");

            myAccount.Deposit();    // Calling the Deposit method

            Console.ReadLine();
        }
    }
}
