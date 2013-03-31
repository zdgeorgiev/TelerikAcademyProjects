using System;
using System.Collections.Generic;

public class TreasureOfCursedWood : Chest
{   
    public TreasureOfCursedWood() : base(ReleasedItem.Treasure_of_the_Cursed_Wood, ReleasedItem.Treasure_Key_of_the_Cursed_Wood)
    {
        this.allAvaibleItems = new List<Item>()
        {
            new Item(ReleasedItem.Spottin_Goggles, ItemRarity.Rare),
            new Item(ReleasedItem.Fishy_Frillhawk, ItemRarity.Rare),
            new Item(ReleasedItem.Ambinderath_Jaw, ItemRarity.Rare),
            new Item(ReleasedItem.Radiant_Crystal_Haul, ItemRarity.Rare),
            new Item(ReleasedItem.Battle_Banner_of_the_Masked, ItemRarity.Rare),
            new Item(ReleasedItem.Wraps_of_the_Seasoned_Veteran, ItemRarity.Rare),
            new Item(ReleasedItem.The_Instagib_OSP, ItemRarity.Mythical),
            new Item(ReleasedItem.Ormr_the_Lunar_Dragon, ItemRarity.Mythical),
            new Item(ReleasedItem.Fearless_Badger, ItemRarity.Mythical),
            new Item(ReleasedItem.Stumpy_the_Nature_Attendant, ItemRarity.Mythical),
            new Item(ReleasedItem.Trusty_Mountain_Yak, ItemRarity.Mythical),
            new Item(ReleasedItem.Enduring_War_Dog, ItemRarity.Mythical),
            new Item(ReleasedItem.Mighty_Boar, ItemRarity.Mythical),
            new Item(ReleasedItem.Morok_the_Mechanical_Mediary, ItemRarity.Mythical),
            new Item(ReleasedItem.Tickled_Tegu, ItemRarity.Mythical),
            new Item(ReleasedItem.Prismatic_Drake, ItemRarity.Mythical),
            new Item(ReleasedItem.Bessy_the_Batmeleon, ItemRarity.Legendary),
            new Item(ReleasedItem.Skip_the_Delivery_Frog, ItemRarity.Legendary),
            new Item(ReleasedItem.Speed_Demon, ItemRarity.Legendary),
            new Item(ReleasedItem.Baby_Roshan, ItemRarity.Legendary),
            new Item(ReleasedItem.NaVi_Weaselcrow, ItemRarity.Legendary),
            new Item(ReleasedItem.Cluckles_the_Brave, ItemRarity.Legendary),

            //TODO : Exceedingly Rare Special Items
        };
    }
}
