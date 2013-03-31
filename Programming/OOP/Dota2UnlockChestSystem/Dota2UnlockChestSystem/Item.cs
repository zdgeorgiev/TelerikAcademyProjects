using System;

public class Item
{
    /// <summary>
    /// Create item with ItemName and ItemRarity
    /// </summary


    public ReleasedItem ItemName { get; private set; }
    public ItemRarity ItemRarity { get; private set; }

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