using System;
using System.Collections.Generic;

class MarketingFirm
{
    static void Main(string[] args)
    {
        List<Employee> allEmployees = new List<Employee>()
        {
            new Employee("Pesho", "Stoqnov", 16, 5913, Gender.Male, 27569999),
            new Employee("Mariika", "Petrova", 16, 5521, Gender.Female, 27568888),
            new Employee("Stefan", "Ivanov", 16, 5071, Gender.Male, 27564444),
        };

        Console.WriteLine("-----------------------------------FIRM..OOD----------------------------------\n");

        foreach (Employee emp in allEmployees)
        {
            Console.WriteLine(emp);
        }
    }
}

//A marketing firm wants to keep record of its employees.
//Each record would have the following characteristics
//– first name, family name, age, gender (m or f), ID number,
//unique employee number (27560000 to 27569999).
//Declare the variables needed to keep the information
//for a single employee using appropriate data types and descriptive names.