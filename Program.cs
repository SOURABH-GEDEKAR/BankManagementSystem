
using BankManagementSystem;
using System;
namespace BankManagemantSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            SavingAccount A = new SavingAccount();


            A.HolderName = "sourabh";
            A.AccountNo = 89751;
            A.Deposite(500);
            A.Withdraw(200);

            A.DisplayBalance();

        }
    }
}
