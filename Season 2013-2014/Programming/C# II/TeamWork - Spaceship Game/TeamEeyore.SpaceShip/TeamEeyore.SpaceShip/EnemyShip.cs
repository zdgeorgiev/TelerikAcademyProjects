using System;

namespace TeamEeyore.SpaceShip
{
    public class EnemyShip : Ship
    {
        private int counter = 0;
        public int Delay { get; set; }

        public EnemyShip(int x, int y, string shipSymbol, int delay) : base(0, 0, default(Weapon), 0, null)
        {
            this.X = x;
            this.Y = y;
            this.ShipSymbol = shipSymbol;
            this.Delay = delay;
        }

        public EnemyShip(int x, int y, Weapon weap, int lvl, string symbol)
            : base(0, 0, default(Weapon), 0, null)
        {
            this.X = x;
            this.Y = y;
            this.Weapon = weap;
            this.Level = lvl;
            this.ShipSymbol = symbol;
        }

        public override void Move()
        {
            int delay = this.Delay;

            if (this.Y >= Console.WindowHeight - 1)
            {
                this.Y = 2;
                this.X = new Random().Next(1, Console.WindowWidth - this.ShipSymbol.Length);
            }
            else
            {
                counter++;
                if (counter % delay == 0)
                {
                    this.Y++;
                }
            }
        }
    }
}