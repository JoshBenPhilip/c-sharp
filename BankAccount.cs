
namespace Accounts;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public string Owner  { get; set; }
    public decimal Balance { get; set; }
    
    public BankAccount()
    {
        AccountNumber = "My Account";
        Owner = "DDD";
        Balance = decimal.MaxValue;
    }

    public BankAccount( string owner, decimal initialBalance)

    {
        Owner = owner;
        Balance = initialBalance;    
    }
}

