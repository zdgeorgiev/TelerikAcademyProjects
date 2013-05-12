using System;
using System.Collections.Generic;

/// <summary>
/// Dictionary that keep the string Key that presents the selected item
/// </summary>

public class ItemLibrary
{
    public Dictionary<string, Item> dictionary = new Dictionary<string, Item>();

    public ItemLibrary()
    {
        this.InitializeItem(dictionary.ToString());
    }

    public void InitializeItem(string key)
    {
        #region KEYS
        //TreasureKey
        dictionary.Add("treasure_key", new Item(ReleasedItem.Treasure_Key, ItemRarity.Common));

        //TreasureKey of the cursed wood
        dictionary.Add("treasure_key_of_the_cursed_wood", new Item(ReleasedItem.Treasure_Key_of_the_Cursed_Wood, ItemRarity.Rare));
        dictionary.Add("tkcursedwood", new Item(ReleasedItem.Treasure_Key_of_the_Cursed_Wood, ItemRarity.Rare));

        //TreasureKey of the shaper devine
        dictionary.Add("treasure_key_of_the_shaper_devine", new Item(ReleasedItem.Treasure_Key_of_the_Shaper_Divine, ItemRarity.Rare));
        dictionary.Add("tkshaperdevine", new Item(ReleasedItem.Treasure_Key_of_the_Shaper_Divine, ItemRarity.Rare));
        # endregion

        #region Chests
        dictionary.Add("treasure_of_the_cursed_wood", new TreasureOfCursedWood());
        dictionary.Add("treasure_of_the_shaper_devine", new TreasureOfShaperDivine());
        #endregion
    }
}