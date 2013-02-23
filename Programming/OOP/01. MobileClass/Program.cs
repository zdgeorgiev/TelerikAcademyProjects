using System;

class Program
{
    static void Main()
    {
        try
        {
            GSM gsm = new GSM(null, null);
            gsm.Manufacturer = "Samsung Electronics";
            Console.WriteLine("Phone manufacturer - {0}", gsm.Manufacturer);
            gsm.Model = "Samsung Galaxy S3";
            Console.WriteLine("Gsm model - {0}", gsm.Model);
            gsm.Owner = "Unknown";
            Console.WriteLine("Gsm owner - {0}", gsm.Owner);
            gsm.Price = 819.00M;
            Console.WriteLine("Phone price - {0}", gsm.Price);
            Console.WriteLine();

            gsm.Battery = new Battery();
            gsm.Battery.BatteryModel = "Durasel";
            Console.WriteLine("Battery Model - {0}", gsm.Battery.BatteryModel);
            gsm.Battery.HoursIdle = 1337;
            Console.WriteLine("Idle hours - {0}", gsm.Battery.HoursIdle);
            gsm.Battery.HoursTalk = 69;
            Console.WriteLine("Talked hours - {0}", gsm.Battery.HoursTalk);
            Console.WriteLine();

            gsm.Display = new Display();
            gsm.Display.DisplaySize = 30;
            Console.WriteLine("Display - {0} inches", gsm.Display.DisplaySize);
            gsm.Display.NumberOfColors = 6000000;
            Console.WriteLine("Number of colors - {0}", gsm.Display.NumberOfColors);
            Console.WriteLine();

            GSM gsm1 = new GSM("Iphone4S", "Apple");
            gsm1.Battery = new Battery(20, 40, "Durasel", BatteryType.NiCd); // set batteryType to NiCd
            Console.WriteLine(gsm1.Battery.BatteryType);

            GSM gsm2 = new GSM("Nokia", "Nokia", "Chuck Norris");
            gsm2.Battery = new Battery(20, 40, "Durasel"); // by default batteryType is first in the enum
            //gsm2.Battery.HoursIdle = -1; // Calls exceptions
            Console.WriteLine(gsm2.Battery.BatteryType);
            Console.WriteLine();
            Console.WriteLine(gsm2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

    }
}
