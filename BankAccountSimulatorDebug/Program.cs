
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
decimal checkingsBal = BankLogic.checkingAccountBalance;

Console.WriteLine("\nBank Account");
Console.WriteLine($"Checkings: ${checkingsBal}");


