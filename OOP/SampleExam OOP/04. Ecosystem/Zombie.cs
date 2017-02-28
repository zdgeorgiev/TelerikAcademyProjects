using AcademyEcosystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecosystem
{
    public class Zombie : Animal
    {
        public Zombie(string name, Point location)
            : base(name, location, 0)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            this.IsAlive = true;
            return 10;
        }
    }
}