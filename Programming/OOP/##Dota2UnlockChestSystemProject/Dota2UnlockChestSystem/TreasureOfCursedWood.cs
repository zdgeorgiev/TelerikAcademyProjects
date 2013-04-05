using System;
using System.Collections.Generic;

public class TreasureOfCursedWood : Chest
{   
    public TreasureOfCursedWood()
        : base(ReleasedItem.Treasure_of_the_Cursed_Wood, ItemRarity.Common, ReleasedItem.Treasure_Key_of_the_Cursed_Wood)
    {
        this.allAvaibleItems = new List<Item>()
        {
            new Item(ReleasedItem.Spottin_Goggles, global::ItemRarity.Rare),
            new Item(ReleasedItem.Fishy_Frillhawk, global::ItemRarity.Rare),
            new Item(ReleasedItem.Ambinderath_Jaw, global::ItemRarity.Rare),
            new Item(ReleasedItem.Scepter_of_the_Grand_Magus, global::ItemRarity.Rare),
            new Item(ReleasedItem.Radiant_Crystal_Haul, global::ItemRarity.Rare),
            new Item(ReleasedItem.Battle_Banner_of_the_Masked, global::ItemRarity.Rare),
            new Item(ReleasedItem.Wraps_of_the_Seasoned_Veteran, global::ItemRarity.Rare),
            new Item(ReleasedItem.The_Instagib_OSP, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Ormr_the_Lunar_Dragon, global::ItemRarity.Mythical),
            new Item(ReleasedItem.Bessy_the_Batmeleon, global::ItemRarity.Legendary),

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
            new Item(ReleasedItem.Cluckles_the_Brave, global::ItemRarity.Legendary),
        };
    }
}