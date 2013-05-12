using System;

public class Employee
{
    public Gender Gender { get; set; }
    private string firstName;
    private string familyName;
    private byte age;
    private int idNumber;
    private uint uniqueEmployeeNumber;

    public Employee(string firstName, string familyName, byte age, int idNumber, Gender gender, uint uniqueEmployeeNumber)
    {
        this.FirstName = firstName;
        this.FamilyName = familyName;
        this.Age = age;
        this.IDNumber = idNumber;
        this.Gender = gender;
        this.UniqueEmployeeNumber = uniqueEmployeeNumber;
    }

    public override string ToString()
    {
        return string.Format("Name - {0} {1}, Age - {2}, ID - {3}, Gender - {4}, UEN - {5}",
            this.firstName, this.familyName, this.Age, this.idNumber, this.Gender, this.UniqueEmployeeNumber);
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.Length < 2 || value.Length > 20)
            {
                throw new ArgumentException("Sorry, but firstName should be 2-20 chars long.");
            }

            this.firstName = value;
        }
    }

    public string FamilyName
    {
        get { return this.familyName; }
        set
        {
            if (value.Length < 2 || value.Length > 20)
            {
                throw new ArgumentException("Sorry, but familyName should be 2-20 chars long.");
            }

            this.familyName = value;
        }
    }

    public byte Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 130)
            {
                throw new ArgumentException("Sorry, but your age should be in range [0...130].");
            }

            this.age = value;
        }
    }

    public int IDNumber
    {
        get { return this.idNumber; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Sorry invalid ID number.");
            }

            this.idNumber = value;
        }
    }

    public uint UniqueEmployeeNumber
    {
        get { return this.uniqueEmployeeNumber; }
        set
        {
            if (value < 27560000 || value > 27569999)
            {
                throw new ArgumentException("Sorry but uniqueEmployeeNumber should be in range [27560000...27569999].");
            }

            this.uniqueEmployeeNumber = value;
        }
    }
}