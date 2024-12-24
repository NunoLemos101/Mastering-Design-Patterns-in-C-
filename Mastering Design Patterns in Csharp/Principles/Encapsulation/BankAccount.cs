namespace Mastering_Design_Patterns_in_Csharp.Principles.Encapsulation;


public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal balance)
    {
        _balance = balance;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }

        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
        {
            throw new ArgumentException("Withdraw amount must be less or equal than the balance");
        }

        _balance -= amount;
    }
}