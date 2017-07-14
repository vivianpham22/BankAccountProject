using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        // Fields 
        private string userName = "Marty McFly";
        protected string userSocial = "XXX-XX-XXX";
        private int userAccountNumber = 12121212;
        


        // Properties
        public string UserName
        {
            get { return this.userName; }
        }
        public string UserSocial
        {
            get { return this.userSocial; }
        }  
        public int UserAccountNumber
        {
            get { return this.userAccountNumber; }
            
        }



        // Constructor 
        public Client()
        {
            // This is my default 
        }

        public Client(string userName, string userSocial, int userAccountNumber)
        {
            this.userName = UserName;
            this.userSocial = userSocial;
            this.userAccountNumber = userAccountNumber;

        }

        // Method
        public void ViewInfo()
        {
           
            Console.WriteLine("Welcome back " + userName);
            Console.WriteLine("Account number: " + userAccountNumber);
            Console.WriteLine(userSocial);
        }


        
    }
}
