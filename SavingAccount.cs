namespace Accounts;


public class SavingAccount: BankAccount
{
    public decimal InterestRate { get; set; }
    
}


public SavingAccount(string owner)
    public void AddMonthlyInterest()
    {
        Balance += Balance * InterestRate;

    }