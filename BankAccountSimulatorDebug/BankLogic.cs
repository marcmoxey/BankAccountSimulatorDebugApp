using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSimulatorDebug
{
    public static class BankLogic
    {
        public static decimal checkingAccountBalance = 2200;
        public static decimal savingsAccountBalance = 7500;

        public static decimal CheckBalance(decimal account)
        {
         
            Console.WriteLine($"Your account balance is {account}");
            return account;
        }

        public static decimal Withdraw(decimal account, decimal amount)
        {
            decimal output = account - amount;
            Console.WriteLine($"You withdrew {amount}. You have {output} left");

            return output;
        }
    }
}
