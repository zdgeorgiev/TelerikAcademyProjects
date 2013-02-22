using System;

class Program
{
    static void Main()
    {
        BatteryType bType = BatteryType.NiMH;
        Console.WriteLine(bType);

        Console.WriteLine((int)bType);
        Console.WriteLine(bType++);
        Console.WriteLine(bType);

        bType = (BatteryType)Enum.Parse(typeof(BatteryType), "LiIon"); //search for batteryType
        Console.WriteLine(bType);

        GSM gsm = new GSM("Iphone4S", "Apple");
       
    }
}
