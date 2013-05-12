using System;
using System.Collections.Generic;

public class TreasureOfShaperDivine : Chest
{
    public TreasureOfShaperDivine()
        : base(ReleasedItem.Treasure_of_the_Shaper_Divine, ItemRarity.Common, ReleasedItem.Treasure_Key_of_the_Shaper_Divine)
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

        this.allAvaibleCouriers = new List<Item>()
        {            
            new Item(ReleasedItem.Fearless_Badger, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Stumpy_the_Nature_Attendant, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Trusty_Mountain_Yak, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Enduring_War_Dog, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Mighty_Boar, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Morok_the_Mechanical_Mediary, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Skip_the_Delivery_Frog, global::ItemRarity.Legendary),
            new Item(ReleasedItem.Speed_Demon, global::ItemRarity.Legendary),
            new Item(ReleasedItem.Tickled_Tegu, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Baby_Roshan, global::ItemRarity.Legendary),
            new Item(ReleasedItem.Prismatic_Drake, global::ItemRarity.Mythical),
            new Item(ReleasedItem.NaVi_Weaselcrow, global::ItemRarity.Legendary),
            new Item(ReleasedItem.Cluckles_the_Brave, global::ItemRarity.Legendary)
        };
    }
}