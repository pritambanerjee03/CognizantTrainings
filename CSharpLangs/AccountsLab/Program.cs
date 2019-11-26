using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLab
{
    public class Accounts
    {
        private double balance = 0;
        private int accountNumber = 0;
        private string accountHolderName;
        private string accountType;

        public Accounts(double balance, int accountNumber, string accountHolderName, string accountType)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.accountType = accountType;
        }

        public void credit(double amount)
        {
            this.balance += amount;
        }

        public void debit(double amount)
        {
            this.balance -= amount;
        }

        public void showData()
        {
            Console.WriteLine($"Account Number: {this.accountNumber}");
            Console.WriteLine($"Account Holder's Name: {this.accountHolderName}");
            Console.WriteLine($"Account Type: {this.accountType}");
            Console.WriteLine($"Account Balance: {this.balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double balance = 150000;
            int accountNumber = 1234;
            string accountHolderName = "Param Singh";
            string accountType = "Savings";

            Accounts account1 = new Accounts(balance, accountNumber, accountHolderName, accountType);
            account1.showData();
            Console.WriteLine("Lets credit");
            account1.credit(500);
            account1.showData();
            Console.WriteLine("Lets debit");
            account1.debit(500);
            account1.showData();
                
        }
    }
}
