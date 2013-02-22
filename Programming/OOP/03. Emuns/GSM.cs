using System;

class GSM
{
    public Display Display = new Display(null, null);
    public Battery Battery = new Battery(null, null, null);

    private string model;
    private decimal? price;
    private string owner;
    private string manufacturer;

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
        this.Battery = battery;
        this.Display = display;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public decimal? Price
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
