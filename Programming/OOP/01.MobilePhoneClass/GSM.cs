using System;

namespace DefiningClassesPartI
{
    class GSM
    {
        public Display Display = new Display();
        public Battery Battery = new Battery();

        private string model;
        private decimal price;
        private string owner;
        private string manufacturer;

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

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics
//(model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
