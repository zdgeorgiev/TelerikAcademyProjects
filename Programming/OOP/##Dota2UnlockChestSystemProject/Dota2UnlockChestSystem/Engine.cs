using System;
using System.Collections.Generic;
using System.Linq;

class Engine
{
    protected ItemLibrary itemLibrary = new ItemLibrary();
    protected UserAccount User = new UserAccount();

    public Engine()
    {
        this.User = new UserAccount();
    }

    public virtual void ExecuteCommand(string commandInput, UserAccount myAccount)
    {
        char[] separators = new char[] { ' ' };

        //Remove empty spaces and split the words
        string[] command = commandInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        if (command != null)
        {
            if (command[0].ToLower() == "add" && command[1].ToLower() == "item")
            {
                try
                {
                    myAccount.AddItem(itemLibrary.dictionary[command[2].ToLower()]);
                    Console.WriteLine("Item successfully added in your inventory!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid item!");
                }
            }
            else if (command[0].ToLower() == "open" && command[1].ToLower() == "chest")
            {
                try
                {
                    myAccount.OpenChest(itemLibrary.dictionary[command[2].ToLower()]);
                }
                catch (Exception)
                {
                    Console.WriteLine("You dont have the required items.");
                }
            }
            else if (command[0].ToLower() == "show" && command[1].ToLower() == "inventory")
            {
                Console.WriteLine(myAccount);
            }
            else if (command[0].ToLower() == "clear")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid Command!");
            }
        }
    }
}