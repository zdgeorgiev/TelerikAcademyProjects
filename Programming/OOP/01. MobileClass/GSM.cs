using System;

class GSM
{
    private Display display;
    private Battery battery;

    private string model;
    private decimal? price;
    private string owner;
    private string manufacturer;

    public override string ToString()
    {
        return string.Format("Model - {0}, Manufactorer - {1}, Owner - {2} Price - {3}",
            this.model, this.manufacturer, this.owner, this.price);
    }

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, string owner, decimal? price)
        : this(model, manufacturer, owner, price, null, null)
    {
    }

    public GSM(string model, string manufacturer, string owner)
        : this(model, manufacturer, owner, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, string owner, decimal? price, Display display, Battery battery)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.owner = owner;
        this.price = price;
        this.battery = battery;
        this.display = display;
    }

    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public Display Display
    {
        get { return this.display; }
        set { this.display = value; }
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if ((value.Length > 2 && value.Length <= 50) || value == null)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException("Model length should be from 3 to 50 chars.");
            }
        }
    }

    public decimal? Price
    {
        get { return this.price; }
        set
        {
            if (value > 0)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("Price should be higher than 0.");
            }
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set
        {
            if ((value.Length > 2 && value.Length <= 50) || value == null)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException("Owner length should be from 3 to 50 chars.");
            }
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if ((value.Length > 2 && value.Length <= 50) || value == null)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException("Manufacturer length should be from 3 to 50 chars.");
            }
        }
    }
}
