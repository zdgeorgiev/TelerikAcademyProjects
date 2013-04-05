using System;
using System.Collections.Generic;

/// <summary>
/// All chests have a Name, avaibleItems
/// and RequiredKey for opening
/// </summary>

public abstract class Chest : Item
{
    //properties set is protected because only the childs can change it
    public List<Item> allAvaibleItems { get; protected set; }
    public ReleasedItem RequiredKey { get; protected set; }

    public Chest(ReleasedItem chestName, ItemRarity itemRarity, ReleasedItem requiredkey) : base(chestName, itemRarity)
    {
        this.RequiredKey = requiredkey;
        this.allAvaibleItems = new List<Item>();
    }
}