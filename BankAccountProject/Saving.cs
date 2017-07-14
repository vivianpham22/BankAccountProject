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
        private int balance = 600900;



        // Properties

        public int Balance { get; set; }
         

        
        // Constructor
        public Saving()
        {
            // Default
        }
        public Saving (int balance)
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
            Console.WriteLine("You have {0} in your saving account", balance );
        }
    }
}
