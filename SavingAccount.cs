using System;
using System.Collections.Generic;
using System.Text;
using BankManagementSystem;

namespace BankManagementSystem
{
    internal class SavingAccount : Account
    {
  

        public override void Deposite(double amount )
        {
           Balance = Balance + amount;
            Console.WriteLine("The Amount "+  amount + " deposited Successfully");
        }

        public override void Withdraw(double amount)
        {
            if(Balance >=amount)
            {
                Balance=Balance - amount;
                Console.WriteLine("The Amount " + amount + " Withdraw Successfully");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");

            }
        }

    }
}
