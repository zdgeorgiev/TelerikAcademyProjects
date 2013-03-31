using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class UserAccount
{
    public string AccountName { get; private set; }
    public string Name { get; private set; }
    public readonly List<Item> AllItems;

    //create userAccount
    public UserAccount()
        : this("TestAccount", "TestAccount")
    {
    }

    public UserAccount(string account, string name)
    {
        this.AccountName = account;
        this.Name = name;
        this.AllItems = new List<Item>();
    }

    //Add Item to your inventory
    public void AddItem(Item item)
    {
        this.AllItems.Add(item);
    }

    //Remove Item from your inventory
    public void RemoveItem(Item item)
    {
        this.AllItems.Remove(item);
    }

    //OpenChest
    public void OpenChest(Chest chest)
    {
        bool requiredKey = false;
        bool requiredChest = false;

        //Search for the key
        foreach (var item in AllItems)
        {
            if (item.ItemName == chest.RequiredKey)
            {
                requiredKey = true;
                break;
            }
        }
        //Search for the chest
        foreach (var item2 in AllItems)
        {
            if (item2.ItemName == chest.Name)
            {
                requiredChest = true;
            }
        }

        //If you have the chest and the key you can open it and receive the item
        if (requiredKey && requiredChest)
        {
            RecieveThePriceFromTheChest(chest);
        }
        else
        {
            Console.WriteLine("You dont have the required items.");
        }
    }

    private void RecieveThePriceFromTheChest(Chest chest)
    {
        Random random = new Random();

        //Simulate the original 5 seconds opening with ticking
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Opening chest  - " + chest.Name + " :");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();

        Console.Beep(1200, 150);
        for (int i = 5; i > 0; i--)
        {
            if (i > 0)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
                Console.Beep(1200, 150);
            }
        }
        Console.WriteLine();
        Console.Beep(1500, 150);

        var yourItem = random.Next(0, chest.allAvaibleItems.Count);

        for (int i = 0; i < chest.allAvaibleItems.Count; i++)
        {
            if (yourItem == i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Coungratulation You Recieve - " + chest.allAvaibleItems[i].ItemName + "!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                //Add recieved item to inventory
                this.AddItem(chest.allAvaibleItems[i]);
                //Remove the key and the chest from inventory
                AllItems.Remove(AllItems.Find(item => item.ItemName == chest.Name));
                AllItems.Remove(AllItems.Find(item => item.ItemName == chest.RequiredKey));
                break;
            }
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine("Account - " + this.AccountName + ", PersonalName - " + this.Name);
        result.AppendLine();
        //Show items from inventory in human readable format
        result.AppendLine("---------------INVENTORY---------------");
        var sortedInv = AllItems.OrderBy(item => item.ToString());

        if (AllItems.Count > 0)
        {
            foreach (var item in sortedInv)
            {
                result.AppendLine(item.ItemName + " - " + item.ItemRarity);
            }
        }
        else
        {
            result.AppendLine("There's no items in this inventory!");
        }

        result.AppendLine("---------------------------------------");
        result.AppendLine();

        return result.ToString();
    }
}
