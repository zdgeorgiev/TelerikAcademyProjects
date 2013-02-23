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
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model name cannot be empty.");
            }
            else if (value.Length < 2)
            {
                throw new ArgumentException("Model name is too short! It should be at least 2 letters.");
            }
            else if (value.Length > 50)
            {
                throw new ArgumentException("Model name is too long! It should be less than 50 letters.");
            }
            this.model = value;
        }
    }

    public decimal? Price
    {
        get { return this.price; }
        set
        {
            if (value < 0 || value == null)
            {
                throw new ArgumentException("Prize cannot be smaller than 0.");
            }
            this.price = value;
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Owner name cannot be empty.");
            }
            else if (value.Length < 2)
            {
                throw new ArgumentException("Owner name is too short! It should be at least 2 letters.");
            }
            else if (value.Length > 50)
            {
                throw new ArgumentException("Owner name is too long! It should be less than 50 letters.");
            }
            this.owner = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Manufacturer name cannot be empty.");
            }
            else if (value.Length < 2)
            {
                throw new ArgumentException("Manufacturer name is too short! It should be at least 2 letters.");
            }
            else if (value.Length > 50)
            {
                throw new ArgumentException("Manufacturer name is too long! It should be less than 50 letters.");
            }
            this.manufacturer = value;
        }
    }
}
