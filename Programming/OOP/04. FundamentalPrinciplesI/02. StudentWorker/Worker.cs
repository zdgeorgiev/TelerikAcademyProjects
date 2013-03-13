using System;
using System.Collections.Generic;
using System.Linq;

public class Worker : Human
{
    public decimal WeekSalary { get; set; }
    public double WorkHoursPerDay { get; set; }

    public Worker(string firstName, string lastName, decimal weekSalary = 0, double workHoursPerDay = 0.0)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal MoneyPerHour()
    {
        return Math.Round(this.WeekSalary / ((decimal)this.WorkHoursPerDay * 5), 2);
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2}", base.FirstName, base.LastName, this.MoneyPerHour());
    }
}