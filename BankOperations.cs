using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    public interface BankOperations
    {

        void DisplayBalance();
        void Deposite(double amount);
        void Withdraw(double amount);

    }
}
