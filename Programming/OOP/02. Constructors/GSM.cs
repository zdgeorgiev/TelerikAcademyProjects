﻿using System;

namespace Constructors
{
    class GSM
    {
        public Display Display = new Display();
        public Battery Battery = new Battery();

        private string model;
        private decimal price;
        private string owner;
        private string manufacturer;

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = null;
            this.price = 0.0M;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
    }
}
