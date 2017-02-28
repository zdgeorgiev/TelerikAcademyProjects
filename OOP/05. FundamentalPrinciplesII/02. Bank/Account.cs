using System;

public abstract class Account : IDepositable
{
    public Customer Customer { get; set; }
    public decimal Balance { get; set; }
    private double interest;

    public Account(Customer customer, decimal balance = 0, double interest = 0)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.Interest = interest;
    }

    public double Interest
    {
        get { return this.interest; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid interest rate.");
            }

            this.interest = value;
        }
    }

    public virtual decimal CalcInterestAmount(int months)
    {
        return (decimal)this.Interest / 100 * months;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Invalid amount to deposit.");
        }

        this.Balance += amount;
    }
}