using System;

namespace TeamEeyore.SpaceShip
{
    public class Shot
    {
        private int x;
        private int y;
        private string shotSymbol;

        public Shot(int x, int y, string shotSymbol)
        {
            this.X = x;
            this.Y = y;

            this.ShotSymbol = shotSymbol;
        }

        public string ShotSymbol
        {
            get
            {
                return this.shotSymbol;
            }
            set
            {
                this.shotSymbol = value;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(ShotSymbol);

            this.UpgradeCoordinates();
        }

        private void UpgradeCoordinates()
        {
            if (this.Y >= 0)
            {
                this.Y--;
            }
        }
    }
}