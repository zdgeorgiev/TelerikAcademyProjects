using System;
using System.Collections.Generic;

class GSM
{
    private Display display;
    private Battery battery;

    private string model;
    private decimal? price;
    private string owner;
    private string manufacturer;

    private List<Call> callHistory = new List<Call>();

    //Static field
    public static GSM iPhone4S = new GSM("iPhone4S", "China", "Pesho", 100);

    //Methods
    public override string ToString()
    {
        return string.Format("Model - {0}, Manufactorer - {1}, Owner - {2} Price - {3}",
            this.model, this.manufacturer, this.owner, this.price);
    }

    public void AddCall(DateTime dateAndTime, decimal dialedPhoneNumber, int duration)
    {
        Call call = new Call(dateAndTime, dialedPhoneNumber, duration);
        callHistory.Add(call);
    }

    public void RemoveCall(int number)
    {
        for (int i = 0; i < CallHistory.Count; i++)
        {
            if (CallHistory[i].DialedPhoneNumber == number)
            {
                CallHistory.RemoveAt(i);
                i--;
            }
        }
    }

    public void ClearHistory()
    {
        CallHistory.Clear();
    }

    public double TotalPriceOfCalls(double perMinute)
    {
        double timeTalked = 0;

        for (int i = 0; i < callHistory.Count; i++)
        {
            timeTalked += CallHistory[i].Duration;
        }
        double totalPrice = (timeTalked / 60) * perMinute;

        return totalPrice;
    }

    //Constructors
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
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.owner = owner;
        this.Price = price;
        this.Battery = battery;
        this.Display = display;
    }

    //Properties
    public List<Call> CallHistory
    {
        get { return this.callHistory;}
    }

    public GSM IPhone4S
    {
        get { return this.IPhone4S; }
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
            if (value == null || value.Length > 2)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException("Model length should be atleast 3 chars.");
            }
        }
    }

    public decimal? Price
    {
        get { return this.price; }
        set
        {
            if (value == null || value > 0)
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
            if (value == null  || value.Length > 2)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException("Owner length should be atleast 3 chars.");
            }
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value == null || value.Length > 2)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException("Manufacturer length should be atleast 3 chars.");
            }
        }
    }
}
