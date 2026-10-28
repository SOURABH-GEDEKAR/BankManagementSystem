using System;
using System.Collections.Generic;
using System.Text;
using BankManagementSystem;

namespace BankManagementSystem
{
    internal class CurrentAccount : Account
    {

        public CurrentAccount():base()
        {

        }

        //Saving Account Constructor - here base()- call the parent comstructor
        public CurrentAccount(string name, int accountNo, double deposite) : base(name, accountNo, deposite)
        {
            Console.WriteLine("Current Account Created");

        }

        public  override void Deposite(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("The Amount "+  amount + " deposited Successfully");
        }

        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance = Balance - amount;
                Console.WriteLine("The Amount " + amount + " Withdraw Successfully");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");

            }
        }

    }
}
