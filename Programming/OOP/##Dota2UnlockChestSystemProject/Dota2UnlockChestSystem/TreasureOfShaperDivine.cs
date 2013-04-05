using System;
using System.Collections.Generic;

public class TreasureOfShaperDivine : Chest
{
    public TreasureOfShaperDivine()
        : base(ReleasedItem.Treasure_of_the_Shaper_Divine, ItemRarity.Rare, ReleasedItem.Treasure_Key_of_the_Shaper_Divine)
    {
        this.allAvaibleItems = new List<Item>()
        {
            //global:ItemRarity calls the real enum, not the itemRarity property from the item
            new Item(ReleasedItem.Crystalline_Sickles, global::ItemRarity.Rare),
            new Item(ReleasedItem.Ring_of_the_Storm, global::ItemRarity.Rare),
            new Item(ReleasedItem.Cercus_of_Whirling_Death, global::ItemRarity.Rare),
            new Item(ReleasedItem.Encore, global::ItemRarity.Rare),
            new Item(ReleasedItem.Whirling_Mind_Slicer, global::ItemRarity.Rare),
            new Item(ReleasedItem.Molten_Fracture, global::ItemRarity.Rare),
            new Item(ReleasedItem.Ring_Spear_of_Soul_Diffusion, global::ItemRarity.Rare),
            new Item(ReleasedItem.Ancient_Crasher, global::ItemRarity.Rare),
            new Item(ReleasedItem.Ancient_Crescent, global::ItemRarity.Rare),
            new Item(ReleasedItem.The_Horned_Mother, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Feral_the_Werebat, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Wings_of_the_Ruby_Web, global::ItemRarity.Legendary)
        };
    }
}