using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client mainClient = new Client();
            Checking checking1 = new Checking();
            Saving saving1 = new Saving();

            int amount;
            int menuChoice = 0;
            int moreChoice = 0;


            while (menuChoice < 1 || menuChoice > 5)
            {
                while (menuChoice != 5)
                {

                    Console.WriteLine("Welcome to SHAM WOW Bank.");
                    Console.WriteLine("How can we you help today?");
                    Console.WriteLine("1.View Client Information");
                    Console.WriteLine("2.View Account Balance");
                    Console.WriteLine("3.Deposit Funds");
                    Console.WriteLine("4.Withdraw Funds");
                    Console.WriteLine("5.Exit");
                    

                    menuChoice = int.Parse(Console.ReadLine());

                    if (menuChoice == 1)
                    {
                        mainClient.ViewInfo();  // <-- printing out clients information 
                        break;
                    }


                    else if (menuChoice == 2)
                    {
                        while (moreChoice < 1 || moreChoice > 2)
                        {
                            Console.WriteLine("Which account would you like to access?");
                            Console.WriteLine("1.Checking Account");
                            Console.WriteLine("2.Saving Account");
                            moreChoice = int.Parse(Console.ReadLine());
                        }

                        if (moreChoice == 1)
                        {
                            checking1.ViewInfo();
                            continue;
                        }

                        else if (moreChoice == 2)
                        {
                            saving1.ViewInfo();
                            continue;
                        }

                    }
                    else if (menuChoice == 3)
                    {
                        Console.WriteLine("How much would you like to deposit?");
                        amount = int.Parse(Console.ReadLine());

                        while (moreChoice < 1 || moreChoice > 2)
                        {
                            Console.WriteLine("Where would you like to deposit?");
                            Console.WriteLine("1.Checking Account");
                            Console.WriteLine("2.Saving Account");
                            moreChoice = int.Parse(Console.ReadLine());

                            if (moreChoice == 1)
                            {
                                checking1.Deposit(amount);
                                checking1.ViewInfo();

                            }
                            else if (moreChoice == 2)
                            {
                                saving1.Deposit(amount);
                                saving1.ViewInfo();
                            }
                        }

                    }
                    else if (menuChoice == 4)
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        amount = int.Parse(Console.ReadLine());

                        while (moreChoice < 1 || moreChoice > 2)
                        {
                            Console.WriteLine("Where would you like to deposit?");
                            Console.WriteLine("1.Checking Account");
                            Console.WriteLine("2.Saving Account");

                            if (moreChoice == 1)
                            {
                                checking1.Withdraw(amount);
                                checking1.ViewInfo();

                            }
                            else if (moreChoice == 2)
                            {
                                saving1.Withdraw(amount);
                                saving1.ViewInfo();
                            }
                        }

                    }
                    else if (menuChoice == 5)
                    {
                        Environment.Exit(0);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for banking with SHAM WOW.");
                        
                    }
                    
                }
            }





            







        }
    }
}
