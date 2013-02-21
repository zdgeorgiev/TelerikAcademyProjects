using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("The Company name is : ");
        string CompanyName = Console.ReadLine();
        Console.Write("The Company address is : ");
        string address = Console.ReadLine();
        Console.Write("The PhoneNumber is : ");
        string phoneNumber = Console.ReadLine();
        Console.Write("The Fax number is : ");
        string faxNumber = Console.ReadLine();
        Console.Write("The web site is : ");
        string webSite = Console.ReadLine();
        Console.Write("The manager is : ");
        string manager = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Manager first name : ");
        string name = Console.ReadLine();
        Console.Write("Manager last name : ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age : ");
        string age = Console.ReadLine();
        Console.Write("Manager phone number : ");
        string number = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("THE COMPANY INFORMATION");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Company name : {0}", CompanyName);
        Console.WriteLine("Company address : {0}", address);
        Console.WriteLine("Company phone number : {0}", phoneNumber);
        Console.WriteLine("Company fax number : {0}", faxNumber);
        Console.WriteLine("Company web site : {0}", webSite);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("MANAGER INFORMATION");
        Console.WriteLine("-------------------");
        Console.WriteLine("Manager first name : {0}", name);
        Console.WriteLine("Manager last name : {0}", lastName);
        Console.WriteLine("Manager age : {0}", age);
        Console.WriteLine("Manager phone number : {0}", number);
    }
}


//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number. Write a program that reads the information 
//about a company and its manager and prints them on the console.
