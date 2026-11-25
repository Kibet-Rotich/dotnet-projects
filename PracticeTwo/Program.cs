// =========================================================================
// EXECUTION AREA (This runs when you start the program)
// =========================================================================

// 1. USING A STATIC METHOD
// Notice we do NOT use the 'new' keyword. We just call the class name directly.
double exchangeRate = CurrencyConverter.ConvertKES_to_USD(5000);
Console.WriteLine($"5000 KES is {exchangeRate} USD");

Console.WriteLine("-------------------------");

// 2. CREATING CHILD OBJECTS
// We cannot type 'new BankAccount()' because it is Abstract. 
// We must create the specific child classes.
SavingsAccount mySavings = new SavingsAccount("Alice", 1000);
CheckingAccount myChecking = new CheckingAccount("Bob", 500);

// Both accounts INHERITED the PrintBalance method from the parent! We didn't write it twice.
mySavings.PrintBalance();
myChecking.PrintBalance();

Console.WriteLine("-------------------------");

// Both accounts have their own unique way of processing the end of the month
mySavings.ProcessEndOfMonth();
myChecking.ProcessEndOfMonth();

