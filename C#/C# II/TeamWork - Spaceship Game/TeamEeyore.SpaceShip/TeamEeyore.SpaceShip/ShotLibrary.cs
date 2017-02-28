using System;
using System.Collections.Generic;

namespace TeamEeyore.SpaceShip
{
    public class ShotLibrary
    {
        public Dictionary<Weapon, string> Library = new Dictionary<Weapon, string>();

        public ShotLibrary()
        {
            this.InitializeItems();
        }

        private void InitializeItems()
        {
            this.Library.Add(Weapon.Normal, "!");
            this.Library.Add(Weapon.Tripple, ". . .");
        }
    }
}