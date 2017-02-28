using System;
using System.Collections.Generic;
using System.Text;

public class MobilePhone
{
    private PhoneModel model;
    private string manufacturer;
    private decimal? price;
    private Battery battery;
    private Display display;

    private static readonly MobilePhone iPhone4S =
        new MobilePhone(PhoneModel.IPhone4S, "Apple", new Display(1, 2));

    public readonly List<Call> allCalls;

    public static MobilePhone IPhone4S
    {
        get { return iPhone4S; }
    }

    public MobilePhone(PhoneModel model, string manufactorer, Display display)
        : this(model, manufactorer, null, null, display)
    {
    }

    public MobilePhone(PhoneModel model, string manufactorer, Battery battery, Display display)
        : this(model, manufactorer, null, battery, display)
    {
    }

    public MobilePhone(PhoneModel model, string manufacturer, decimal? price = null,
        Battery battery = null, Display display = null)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Battery = battery;
        this.Display = display;
        this.allCalls = new List<Call>();
    }

    public void AddCall(Call call)
    {
        this.allCalls.Add(call);
    }

    public void RemoveCall(Call call)
    {
        if (!this.allCalls.Contains(call))
        {
            throw new ArgumentException("Sorry you are trying to remove a call that doesnt exist.");
        }

        this.allCalls.Remove(call);
    }

    public void ClearHistory()
    {
        this.allCalls.Clear();
    }

    public decimal CalculatePriceFromCalls(decimal fixedPrice)
    {
        decimal totalPrice = 0;

        foreach (Call call in this.allCalls)
        {
            totalPrice += (call.Duration / 60) * fixedPrice;
        }

        return Math.Round(totalPrice, 2);
    }

    public PhoneModel Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Manufactorer cannot be null or empty.");
            }
            this.manufacturer = value;
        }
    }

    public decimal? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price for mobile phone cannot be less than 0.");
            }

            this.price = value;
        }
    }

    public Battery Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }

    public Display Display
    {
        get
        {
            return this.display;
        }
        set
        {
            this.display = value;
        }
    }

    public override string ToString()
    {
        List<string> allInformation = new List<string>();

        allInformation.Add("╔══════════════════════════════════════════════════════════╗");
        allInformation.Add(string.Format("                      Model - {0}", this.Model));
        allInformation.Add(string.Format("Manufactorer - {0}", this.Manufacturer));

        if (this.Price != null)
        {
            allInformation.Add(string.Format("Price - {0}$", this.Price));
        }

        if (this.Battery != null)
        {
            allInformation.Add("Battery - ");
            allInformation.Add(this.Battery.ToString());
        }

        if (this.Display != null)
        {
            allInformation.Add("Display - ");
            allInformation.Add(this.Display.ToString());
        }

        for (int i = 1; i < allInformation.Count; i++)
        {
            allInformation[i] = allInformation[i].Insert(0, "║");
            allInformation[i] = allInformation[i].PadRight(60).Insert(59, "║");
        }

        allInformation.Add("╚══════════════════════════════════════════════════════════╝");

        StringBuilder output = new StringBuilder();

        foreach (var line in allInformation)
        {
            output.AppendLine(line);
        }

        return output.ToString();
    }
}