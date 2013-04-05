using System;

/// <summary>
/// This program simulate the unlocking system in dota2 in console
/// aplication.If you have chest and key who can open the chest
/// you can open the chest and receive one random item depeneds
/// on the items that chest contains.
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        UserAccount myAccount = new UserAccount();
        
        myAccount.AddItem(new Item(ReleasedItem.Treasure_Key_of_the_Cursed_Wood));
        myAccount.AddItem(new Item(ReleasedItem.Treasure_of_the_Cursed_Wood));

        Engine e = new Engine();

        string input = Console.ReadLine();

        while (input != "exit")
        {
            e.ExecuteCommand(input, myAccount);
            input = Console.ReadLine();
        }
    }
}

