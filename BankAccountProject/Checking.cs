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
        private int balance = 10000;


        // Properties
        public int Balance { get; set; }


        // Constructor
        public Checking()
        {
            // Default
        }
        public Checking(int balance)
        {
            this.balance = balance;

        }



        // Method
        public override void Deposit(int amount)
        {
            balance += amount;
        }

        public override void Withdraw(int amount)
        {
            balance -= amount;
           
        }
        public override void ViewInfo()
        {
            Console.WriteLine("You have {0} in your checking account.", balance);
        }


        
    }
   
}
