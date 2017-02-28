using System;
using System.Collections.Generic;

namespace TeamEeyore.SpaceShip
{
    public abstract class Ship : IMoveble
    {
        protected readonly ShotLibrary shotLibrary = new ShotLibrary();
        public List<Shot> Shots = new List<Shot>();

        //Fields.
        private int x;
        private int y;
        private Weapon weapon;
        private int level;
        private string shipSymbol;

        //Constructor.
        public Ship(int x, int y, Weapon weapon = Weapon.Normal, int level = 0, string shipSymbol = "|=0=|")
        {
            this.X = x;
            this.Y = y;
            this.Weapon = weapon;
            this.Level = level;
            this.ShipSymbol = shipSymbol;
        }

        //Encapsulation.
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public Weapon Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        public string ShipSymbol
        {
            get
            {
                return this.shipSymbol;
            }
            set
            {
                this.shipSymbol = value;
            }
        }

        //Methods.
        public void Draw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.ShipSymbol);
        }

        public abstract void Move();
    }
}