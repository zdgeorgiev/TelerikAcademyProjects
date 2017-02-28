using System;

public class Worker : Human
{
    private decimal weekSalary;
    private int workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid week salary.");
            }

            this.weekSalary = value;
        }
    }

    public int WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentException("Invalid working hours per day.");
            }

            this.workHoursPerDay = value;
        }
    }

    public decimal MoneyPerHour()
    {
        decimal amount = 0;

        amount = Math.Round((this.WeekSalary / 5) / this.WorkHoursPerDay, 2);

        return amount;
    }

    public override string ToString()
    {
        return base.ToString() + string.Format(", WeekSalary - {0}, WorkingHoursPerDay - {1}"
            , this.WeekSalary, this.WorkHoursPerDay);
    }
}