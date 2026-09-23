public class BankAccount
{
    public string AccountNumber {get; init;}
    public string OwnerName{get; set; }
    public decimal Balance{ get; private set;}


    public BankAccount(string accountnumber, string ownername, decimal initialBalance = 0)
    {
        AccountNumber = accountnumber;
        OwnerName = ownername;
        Balance = initialBalance;

    }

    public void Deposit(decimal amount)
    {
        if(amount>0){ 
            Balance =+ amount;
        }
    }
    public bool TryWithdraw(decimal amount, out decimal newBalance)
    {
        if(amount>0 && amount <= Balance)
        {
            Balance =- amount;
            newBalance = Balance;
            return true;
        }
        else
        {
            newBalance = Balance;
            return false;
        }
    }
}