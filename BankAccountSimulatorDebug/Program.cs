
using BankAccountSimulatorDebug;

/*
 * 
 * Create a simple bank account simulator that allows users to deposit, withdraw, and check their
 * balance. Use breakpoints to debug the account logic.
 * 
 * 
 * Add methods to deposit, withdraw, and check the balance.
 * Set breakpoints to inspect the balance after each transaction.
 * Debug edge cases, such as withdrawing more money than the account balance.
 * 
 */
decimal checkingBal = BankLogic.checkingAccountBalance;
decimal savingsBal = BankLogic.savingsAccountBalance;

Console.WriteLine("\nBank Account");
Console.WriteLine($"Checking:\t${checkingBal}");
Console.WriteLine($"Savings:\t${savingsBal}");
Console.WriteLine();

string userChoice;



do
{
    Console.WriteLine("1. Checking");
    Console.WriteLine("2. Savings");
    Console.WriteLine("3. Exit");
    Console.Write("What account do you want to use: ");
    userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            do
            {
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Check account balance");
                Console.WriteLine("4. Exit");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        BankLogic.Deposit(checkingBal);
                        break;
                    case "2":
                        BankLogic.Withdraw(checkingBal);
                        break;
                    case "3":
                        BankLogic.CheckBalance(checkingBal);
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            } while (userChoice != "4");
            break; 
        case "2":
            do
            {
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Check account balance");
                Console.WriteLine("4. Exit");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        BankLogic.Deposit(savingsBal);
                        break;
                    case "2":
                        BankLogic.Withdraw(savingsBal);
                        break;
                    case "3":
                        BankLogic.CheckBalance(savingsBal);
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            } while (userChoice != "4");
            break; // Add break here as well
        case "3":
            break;
        default:
            break;
    }
} while (userChoice != "3");

