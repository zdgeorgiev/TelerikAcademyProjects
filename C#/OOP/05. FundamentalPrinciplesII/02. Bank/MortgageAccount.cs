using System;

public class MortgageAccount : Account
{
    public MortgageAccount(Customer customer, decimal balance, double interest)
        : base(customer, balance, interest)
    {
    }

    public override decimal CalcInterestAmount(int months)
    {
        Customer currentCustomer = this.Customer;

        if (currentCustomer == Customer.Company && months <= 12)
        {
            return base.CalcInterestAmount(months / 2);
        }
        else if (currentCustomer == Customer.Individual && months <= 6)
        {
            return 0;
        }
        else
        {
            if (currentCustomer == Customer.Company)
            {
                return base.CalcInterestAmount(months - 12) + (((decimal)this.Interest / 100 / 2) * 12);
            }
            else
            {
                return base.CalcInterestAmount(months - 6);
            }
        }
    }
}