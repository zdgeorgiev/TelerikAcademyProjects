using System;

class Program
{
    static void Main(string[] args)
    {
        DepositAccount myAccount = new DepositAccount(Customer.Individual, 0, 1);

        myAccount.Deposit(2000);

        Console.WriteLine(myAccount.Balance);
        Console.WriteLine(myAccount.CalcInterestAmount(10));

        myAccount.Withdraw(2000);

        Console.WriteLine(myAccount.Balance);

        Console.WriteLine(myAccount.CalcInterestAmount(10));
    }
}