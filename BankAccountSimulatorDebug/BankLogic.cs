using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

        public static decimal Withdraw(decimal account)
        {
            decimal output = 0;
            Console.Write("How much do you want to withdraw: ");
            string withdrawAmountText = Console.ReadLine();
            if(!decimal.TryParse(withdrawAmountText, out decimal  withdrawAmount))
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }

            if(withdrawAmount > account)
            {
                Console.WriteLine("You can't withdraw that amount!");
            }
            else
            {
               output = account - withdrawAmount;
                Console.WriteLine($"You withdrew {withdrawAmount}");
            }
              
            

            return output;
           
        }

        public static decimal Deposit(decimal account)
        {
            decimal output;
            Console.Write("How much do you want to deposit: ");
            string depositAmountText = Console.ReadLine();
            if (!decimal.TryParse(depositAmountText, out decimal depositAmount))
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }

            output = account + depositAmount;
            Console.WriteLine($"You deposited {depositAmount}");

            return output;
         
        }
    }
}
