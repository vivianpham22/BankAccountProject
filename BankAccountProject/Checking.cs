using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject

{
    class Checking : MainAccount
    {

        // Field 
        private double balance = 10000d;


        // Properties
        public double Balance { get; }


        // Constructor
        public Checking()
        {
            // Default
        }
        public Checking(double balance)
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
        public override void ViewInfo()
        {
            Console.WriteLine("You have {0} in your checking account.", balance);
        }



    }

}