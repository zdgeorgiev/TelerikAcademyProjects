using System;

public class LoanAccount : Account
{
    public LoanAccount(Customer customer, decimal balance, double interest)
        : base(customer, balance, interest)
    {
    }

    public override decimal CalcInterestAmount(int months)
    {
        Customer currentCustomer = this.Customer;

        if (currentCustomer == Customer.Individual && months <= 3)
        {
            return 0;
        }
        else if (currentCustomer == Customer.Company && months <= 2)
        {
            return 0;
        }
        else
        {
            if (currentCustomer == Customer.Company)
            {
                return base.CalcInterestAmount(months - 2);
            }
            else
            {
                return base.CalcInterestAmount(months - 3);
            }
        }
    }
}