using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    abstract class MainAccount
    {

        // Method

        // Abstract method of deposit shared by all accounts 
        public abstract void Deposit(double amount);
     

        // Abstract method of withdraw shared by all accounts 
        public abstract void Withdraw(double amount);


        // Abstract method of view info shared by all accounts 
        public abstract void ViewInfo();






    }
}
