using System;

class Company
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone number: ");
        decimal companyPhoneNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Company fax number: ");
        decimal companyFaxNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Company web site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone number: ");
        decimal managerPhone = decimal.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("COMPANY INFORMATION");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Company address: {0}", companyAddress);
        Console.WriteLine("Company phone number: {0}", companyPhoneNumber);
        Console.WriteLine("Company fax number: {0}", companyFaxNumber);
        Console.WriteLine("Company web site: {0}", companyWebSite);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("MANAGER INFORMATION");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Manager first name: {0}", managerFirstName);
        Console.WriteLine("Manager last name: {0}", managerLastName);
        Console.WriteLine("Manager age: {0}", managerAge);
        Console.WriteLine("Manager phone number: {0}", managerPhone);
    }
}

//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and 
//its manager and prints them on the console.