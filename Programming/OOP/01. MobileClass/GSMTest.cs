using System;

class GSMTest
{
    static void Main()
    {
        try
        {
            //first GSM
            GSM gsm = new GSM(null, null);
            gsm.Model = "Samsung Galaxy S3";
            gsm.Manufacturer = "Samsumg";
            gsm.Price = 819.00M;

            gsm.Battery = new Battery(null, null);
            gsm.Battery.BatteryModel = "Durasel";
            gsm.Battery.HoursIdle = 1337;
            gsm.Battery.HoursTalk = 50;

            gsm.Display = new Display();
            gsm.Display.DisplaySize = 30;
            gsm.Display.NumberOfColors = 6000000;

            //second GSM
            GSM gsm1 = new GSM("Motorola", "MotorolaOOD");
            gsm1.Battery = new Battery(20, 40, "Durasel", BatteryType.NiCd); // set batteryType to NiCd

            //third GSM
            GSM gsm2 = new GSM("Nokia", "Nokia", "Chuck Norris");
            gsm2.Battery = new Battery(2, 40, "Durasel"); // by default batteryType is first in the enum

            //Console.WriteLine(GSM.iPhone4S); // information for iPhone4S from the static property 

            GSM[] gsmArray = new GSM[] { gsm, gsm1, gsm2, GSM.iPhone4S};

            foreach (GSM gsmInformation in gsmArray)
            {
                Console.WriteLine(gsmInformation);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
