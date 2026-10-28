using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{

    public abstract class Account : BankOperations
    {
        public string HolderName { get; set; } = "";
        public int AccountNo{ get; set; }
        public double Balance { get; set; }

        public void DisplayBalance()
        {
            Console.WriteLine("Name: " + HolderName);
            Console.WriteLine("Accountno: " + AccountNo);
            Console.WriteLine("Balance: " + Balance);
        }

        public abstract void Deposite(double amount);
        public abstract void Withdraw(double amount);


    }
}
