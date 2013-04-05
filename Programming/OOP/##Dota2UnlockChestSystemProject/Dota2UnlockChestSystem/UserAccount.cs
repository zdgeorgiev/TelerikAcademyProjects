using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class UserAccount
{
    private const int LUCKY_NUMBER = 66;
    public string AccountName { get; private set; }
    public string Name { get; private set; }
    public readonly List<Item> AllItems;
    Random randomNumberForItem = new Random();

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
    public void OpenChest(Item item)
    {
        Chest chest = item as Chest;

        bool requiredKey = false;
        bool requiredChest = false;

        //Search for the key
        foreach (var item1 in AllItems)
        {
            if (item1.ItemName == chest.RequiredKey)
            {
                requiredKey = true;
                break;
            }
        }
        //Search for the chest
        foreach (var item2 in AllItems)
        {
            if (item2.ItemName == chest.ItemName)
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
        //Simulate the original 5 seconds opening with ticking
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Opening chest  - " + chest.ItemName + " :");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();

        Console.Beep(1200, 150);
        for (int i = 5; i > 0; i--)
        {
            if (i > 0)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
                Console.Beep(1200, 100);
            }
        }
        Console.WriteLine();
        Console.Beep(1500, 150);

        //If you are lucky for that 1% chance for unusual
        if (randomNumberForItem.Next(0, 101) == LUCKY_NUMBER)
        {
            this.AddItem(new Item(ReleasedItem.Golden_Baby_Roshan, ItemRarity.Immortal));
            AllItems.Remove(AllItems.Find(item => item.ItemName == chest.ItemName));
            AllItems.Remove(AllItems.Find(item => item.ItemName == chest.RequiredKey));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Congratulation You Recieve - Golden Baby Roshan!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        else
        {
            var yourItem = randomNumberForItem.Next(0, chest.allAvaibleItems.Count);

            for (int i = 0; i < chest.allAvaibleItems.Count; i++)
            {
                if (yourItem == i)
                {
                    //Add recieved item to inventory
                    this.AddItem(chest.allAvaibleItems[i]);
                    //Remove the key and the chest from inventory
                    AllItems.Remove(AllItems.Find(item => item.ItemName == chest.ItemName));
                    AllItems.Remove(AllItems.Find(item => item.ItemName == chest.RequiredKey));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Coungratulation You Recieve - " + chest.allAvaibleItems[i].ItemName + "!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    break;
                }
            }
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine();
        result.AppendLine("Account - " + this.AccountName + ", PersonalName - " + this.Name);
        result.AppendLine();
        //Show items from inventory in human readable format
        result.AppendLine("---------------INVENTORY---------------");
        var sortedInv = AllItems.OrderBy(item => item.ItemName);

        if (AllItems.Count > 0)
        {
            foreach (var item in sortedInv)
            {
                result.AppendLine(item.ItemName + " - " + item.ItemRarity);
            }
        }
        else
        {
            result.AppendLine("There's no items in your inventory!");
        }

        result.AppendLine("---------------------------------------");

        return result.ToString();
    }
}
