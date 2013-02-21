using System;
using System.Linq;

namespace DefiningClassesPartI
{
    class MobilePhoneClass
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM();
            gsm.Manufacturer = "Telerik Academy";
            Console.WriteLine("Phone manufacturer - {0}", gsm.Manufacturer);
            gsm.Model = "Samsung Galaxy S3";
            Console.WriteLine("Gsm model - {0}", gsm.Model);
            gsm.Owner = "Zdravko";
            Console.WriteLine("Gsm owner - {0}", gsm.Owner);
            gsm.Price = 819.00M;
            Console.WriteLine("Phone price - {0}", gsm.Price);
            gsm.Battery.BatteryModel = "Durasel";
            Console.WriteLine("Battery model - {0}", gsm.Battery.BatteryModel);
            gsm.Battery.HoursIdle = 1337;
            Console.WriteLine("Idle hours - {0}", gsm.Battery.HoursIdle);
            gsm.Battery.HoursTalk = 69;
            Console.WriteLine("Talked hours - {0}", gsm.Battery.HoursTalk);
            gsm.Display.DisplaySize = 30;
            Console.WriteLine("Display - {0}", gsm.Display.DisplaySize);
            gsm.Display.NumberOfColors = 6000000;
            Console.WriteLine("Number of colors - {0}", gsm.Display.NumberOfColors);
        }
    }
}
