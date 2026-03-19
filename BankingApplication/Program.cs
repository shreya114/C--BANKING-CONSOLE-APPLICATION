// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

namespace BankingApplication
{
    public class Program
    {
        // Entry point for the application. Place executable statements here.
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE BANKING APPLICATION");
            Console.WriteLine("Enter your name:");
            string name = new string(Console.ReadLine());
            Console.WriteLine("Enter your initial deposit amount:");
            double balance = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice (1-4):");
                string choice = new string(Console.ReadLine());
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter deposit amount:");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine($"Deposited: {depositAmount:C}. New Balance: {balance:C}");
                        break;
                    case "2":
                        Console.WriteLine("Enter withdrawal amount:");
                        double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                        if (withdrawalAmount > balance)
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        else
                        {
                            balance -= withdrawalAmount;
                            Console.WriteLine($"Withdrew: {withdrawalAmount:C}. New Balance: {balance:C}");
                        }
                        break;
                    case "3":
                        Console.WriteLine($"Current Balance: {balance:C}");
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the Banking Application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

    }
}