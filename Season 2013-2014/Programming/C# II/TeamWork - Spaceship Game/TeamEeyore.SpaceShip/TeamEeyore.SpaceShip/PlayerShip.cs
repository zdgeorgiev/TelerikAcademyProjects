using System;

namespace TeamEeyore.SpaceShip
{
    public class PlayerShip : Ship
    {
        public PlayerShip(int x, int y, string shipSymbol)
            : base(0, 0, default(Weapon), 0, null)
        {
            this.X = x;
            this.Y = y;
            this.ShipSymbol = shipSymbol;
        }

        public PlayerShip(int x, int y, Weapon weapon, int level, string shipSymbol)
            : base(x, y, weapon, level, shipSymbol)
        {
        }

        public override void Move()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (this.X > 1)
                    {
                        this.X--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (this.X < Console.WindowWidth - (this.ShipSymbol.Length + 1))
                    {
                        this.X++;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.F)
                {
                    this.Shots.Add(new Shot(this.X + 2, this.Y - 2, this.shotLibrary.Library[this.Weapon]));
                }
                else if (keyInfo.Key == ConsoleKey.D1)
                {
                    this.Weapon = Weapon.Normal;
                }
                else if (keyInfo.Key == ConsoleKey.D2 && this.Level >= 5)
                {
                    this.Weapon = Weapon.Tripple;
                }
            }

            UpdateCoords();
        }

        private void UpdateCoords()
        {
            foreach (Shot s in Shots)
            {
                s.Draw();

                if (s.Y == 1)
                {
                    Shots.Remove(s);
                    break;
                }
            }
        }
    }
}