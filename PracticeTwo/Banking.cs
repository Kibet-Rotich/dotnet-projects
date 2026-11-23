// =========================================================================
// CLASS DEFINITIONS (Put these at the bottom of the file)
// =========================================================================

// -------------------------------------------------------------------------
// STATIC CLASS
// A static class can only hold static methods. You cannot create objects from it.
// -------------------------------------------------------------------------
public class CurrencyConverter
{
    // A static method: Belongs to the class, not to an object.
    public static double ConvertKES_to_USD(double kenyanShillings)
    {
        return kenyanShillings / 130.5; // Example exchange rate
    }
}

// -------------------------------------------------------------------------
// ABSTRACT PARENT CLASS
// -------------------------------------------------------------------------
public abstract class BankAccount
{
    // These properties will be inherited by all children
    public string AccountHolderName;
    public double Balance;

    // The Parent Constructor
    public BankAccount(string name, double startingBalance)
    {
        AccountHolderName = name;
        Balance = startingBalance;
    }

    // A normal method that all children will inherit exactly as written
    public void PrintBalance()
    {
        Console.WriteLine($"{AccountHolderName}'s balance is {Balance} KES.");
    }

    // An ABSTRACT method. 
    // This forces every child class to create a method called 'ProcessEndOfMonth', 
    // but the parent leaves it completely blank because every child handles it differently.
    public abstract void ProcessEndOfMonth();
}

// -------------------------------------------------------------------------
// CHILD CLASS 1: Savings Account
// The colon (:) means "SavingsAccount inherits from BankAccount"
// -------------------------------------------------------------------------
public class SavingsAccount : BankAccount
{
    // The child constructor must pass the setup data up to the parent using 'base'
    public SavingsAccount(string name, double startingBalance) 
        : base(name, startingBalance)
    {
    }

    // We use the 'override' keyword to fill in the blank abstract method from the parent
    public override void ProcessEndOfMonth()
    {
        // Savings accounts get free money (interest) at the end of the month!
        Balance = Balance + 50; 
        Console.WriteLine($"Added 50 KES interest to {AccountHolderName}'s Savings. New Balance: {Balance}");
    }
}

// -------------------------------------------------------------------------
// CHILD CLASS 2: Checking Account
// -------------------------------------------------------------------------
public class CheckingAccount : BankAccount
{
    public CheckingAccount(string name, double startingBalance) 
        : base(name, startingBalance)
    {
    }

    public override void ProcessEndOfMonth()
    {
        // Checking accounts get charged a monthly maintenance fee!
        Balance = Balance - 15; 
        Console.WriteLine($"Deducted 15 KES fee from {AccountHolderName}'s Checking. New Balance: {Balance}");
    }
}