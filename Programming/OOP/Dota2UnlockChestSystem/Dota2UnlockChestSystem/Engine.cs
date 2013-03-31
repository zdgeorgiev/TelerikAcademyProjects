using System;
using System.Collections.Generic;
using System.Linq;

class Engine
{
    protected ItemLibrary itemLibrary = new ItemLibrary();
    protected List<UserAccount> AllUsers;
    protected List<ReleasedItem> AllItems;

    public Engine()
    {
        this.AllUsers = new List<UserAccount>();
        //Add all ReleasedItems to the engine list
        this.AllItems = Enum.GetValues(typeof(ReleasedItem)).Cast<ReleasedItem>().ToList();
    }
    public Dictionary<string, Item> dictionary = new Dictionary<string, Item>();

    public void InitializeItem(string key)
    {
        #region KEYS
        //TreasureKey
        dictionary.Add("treasure key", new Item(ReleasedItem.Treasure_Key, ItemRarity.Common));

        //TreasureKey of the cursed wood
        dictionary.Add("treasure key of the cursed wood", new Item(ReleasedItem.Treasure_Key_of_the_Cursed_Wood, ItemRarity.Rare));
        dictionary.Add("tkcursedwood", new Item(ReleasedItem.Treasure_Key_of_the_Cursed_Wood, ItemRarity.Rare));

        //TreasureKey of the sharper divine
        //dictionary.Add("treasure key of the shaper divine", new Item(ReleasedItem.Treasure_Key, ItemRarity.Common));
        # endregion

        #region Chests
        dictionary.Add("treasure of the cursed wood", new Item(ReleasedItem.Treasure_of_the_Cursed_Wood, ItemRarity.Common));
        dictionary.Add("treasure of the sharped devine", new Item(ReleasedItem.Treasure_Key_of_the_Shaper_Divine, ItemRarity.Common));
        #endregion

        #region CursedWoodChestItems
        dictionary.Add("spottin googles", new Item(ReleasedItem.Spottin_Goggles, ItemRarity.Rare));
        dictionary.Add("fishy_frillhawk", new Item(ReleasedItem.Fishy_Frillhawk, ItemRarity.Rare));
        dictionary.Add("ambinderath jaw", new Item(ReleasedItem.Ambinderath_Jaw, ItemRarity.Rare));
        dictionary.Add("radiant crystal haul", new Item(ReleasedItem.Radiant_Crystal_Haul, ItemRarity.Rare));
        dictionary.Add("battle banned of the masked", new Item(ReleasedItem.Battle_Banner_of_the_Masked, ItemRarity.Rare));
        dictionary.Add("wraps of the seasoned veteran", new Item(ReleasedItem.Wraps_of_the_Seasoned_Veteran, ItemRarity.Rare));
        dictionary.Add("the instagib osp", new Item(ReleasedItem.The_Instagib_OSP, ItemRarity.Mythical));
        dictionary.Add("ormr the lunar dragon", new Item(ReleasedItem.Ormr_the_Lunar_Dragon, ItemRarity.Mythical));
        dictionary.Add("fearless badger", new Item(ReleasedItem.Fearless_Badger, ItemRarity.Mythical));
        dictionary.Add("stumpy the nature attendant", new Item(ReleasedItem.Stumpy_the_Nature_Attendant, ItemRarity.Mythical));
        dictionary.Add("trusty mountain yak", new Item(ReleasedItem.Trusty_Mountain_Yak, ItemRarity.Mythical));
        dictionary.Add("enduring war dog", new Item(ReleasedItem.Enduring_War_Dog, ItemRarity.Mythical));
        dictionary.Add("mighty boar", new Item(ReleasedItem.Mighty_Boar, ItemRarity.Mythical));
        dictionary.Add("morok_the mechanical mediary", new Item(ReleasedItem.Morok_the_Mechanical_Mediary, ItemRarity.Mythical));
        dictionary.Add("tickled tegu", new Item(ReleasedItem.Tickled_Tegu, ItemRarity.Mythical));
        dictionary.Add("prismatic drake", new Item(ReleasedItem.Prismatic_Drake, ItemRarity.Mythical));
        dictionary.Add("bessy the batmeleon", new Item(ReleasedItem.Bessy_the_Batmeleon, ItemRarity.Legendary));
        dictionary.Add("skip the delivery frog", new Item(ReleasedItem.Skip_the_Delivery_Frog, ItemRarity.Legendary));
        dictionary.Add("speed demon", new Item(ReleasedItem.Speed_Demon, ItemRarity.Legendary));
        dictionary.Add("baby roshan", new Item(ReleasedItem.Baby_Roshan, ItemRarity.Legendary));
        dictionary.Add("naVi weaselcrow", new Item(ReleasedItem.NaVi_Weaselcrow, ItemRarity.Legendary));
        dictionary.Add("cluckles the brave", new Item(ReleasedItem.Cluckles_the_Brave, ItemRarity.Legendary));
        #endregion

        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
        //dictionary.Add("treasure key", );
    }

    public void AddAccount(UserAccount obj)
    {
        this.AllUsers.Add(obj);
    }

    public void ExecuteCommand(string commandInput, UserAccount myAccount)
    {
        char[] separators = new char[] { ' ' };

        //Remove empty spaces and split the words
        string[] command = commandInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        if (command != null)
        {
            if (command[0].ToLower() == "add" && command[1].ToLower() == "item")
            {
                //Item item = (Item)Enum.Parse(typeof(ReleasedItem), command[2]);
                //myAccount.AddItem(item);
                myAccount.AddItem(itemLibrary.dictionary[command[2]]);

                //myAccount.AddItem(itemLibrary.InitializeItem(command[2]);
            }
            else if (command[0].ToLower() == "open" && command[1].ToLower() == "chest")
            {
                //myAccount.OpenChest(itemLibrary.dictionary[command[2]]);
            }
            else if (command[0].ToLower() == "show" && command[1].ToLower() == "inventory")
            {
                Console.WriteLine(myAccount);
            }
        }
    }
}
