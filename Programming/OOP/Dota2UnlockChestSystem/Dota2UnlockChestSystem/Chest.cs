using System;
using System.Collections.Generic;

public class Chest
{
    /// <summary>
    /// All chests have a Name, avaibleItems
    /// and RequiredKey for opening
    /// </summary>
    
    //propertie's set is protected because only the childs can change it
    public ReleasedItem Name { get; protected set; }
    public List<Item> allAvaibleItems { get; protected set; }
    public ReleasedItem RequiredKey { get; protected set; }

    public Chest(ReleasedItem chestName, ReleasedItem requiredkey)
    {
        this.Name = chestName;
        this.RequiredKey = requiredkey;
        this.allAvaibleItems = new List<Item>();
    }
}