using System;

public class DepositAccount : Account, IWithdrawable
{
    public DepositAccount(Customer customer, decimal balance, double interest)
        : base(customer, balance, interest)
    {
    }

    public override decimal CalcInterestAmount(int months)
    {
        if (this.Balance >= 0 & this.Balance < 1000)
        {
            return 0;
        }
        else
        {
            return base.CalcInterestAmount(months);
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Invalid amount to withdraw.");
        }

        this.Balance -= amount;
    }
}