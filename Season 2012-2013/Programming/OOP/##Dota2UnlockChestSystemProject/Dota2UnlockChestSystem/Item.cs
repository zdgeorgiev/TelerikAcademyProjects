using System;

/// <summary>
/// Create item with ItemName and ItemRarity
/// </summary

public class Item
{
    public ReleasedItem ItemName { get; protected set; }
    public ItemRarity ItemRarity { get; protected set; }

    public Item(ReleasedItem itemName, ItemRarity itemRarity)
    {
        this.ItemName = itemName;
        this.ItemRarity = itemRarity;
    }
}