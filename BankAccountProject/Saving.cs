using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Saving : MainAccount
    {
        int amount;

        // Field 
        private double balance = 600900d;



        // Properties

        public double Balance { get; set; }



        // Constructor
        public Saving()
        {
            // Default
        }
        public Saving(double balance)
        {
            this.balance = balance;
        }



        // Method 
        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
        }

        //public void InsufficientFunds()
        //{
        //    if (amount > minBalance)
        //    {
        //        Console.WriteLine("Insufficient Funds in the account.");
        //    }
        //}

        public override void ViewInfo()
        {
            Console.WriteLine("You have {0} in your saving account", balance);
        }
    }
}