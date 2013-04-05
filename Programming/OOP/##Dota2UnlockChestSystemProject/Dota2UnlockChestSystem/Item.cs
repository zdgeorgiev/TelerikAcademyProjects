using System;

/// <summary>
/// Create item with ItemName and ItemRarity
/// </summary

public class Item
{
    public ReleasedItem ItemName { get; protected set; }
    public ItemRarity ItemRarity { get; protected set; }

    //Rarity will be common as default
    public Item(ReleasedItem itemName)
        : this(itemName, 0)
    {
    }

    public Item(ReleasedItem itemName, ItemRarity itemRarity)
    {
        this.ItemName = itemName;
        this.ItemRarity = itemRarity;
    }
}