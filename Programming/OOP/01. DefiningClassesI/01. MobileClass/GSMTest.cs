using System;

class GSMTest
{
    static void Main()
    {
        try
        {
            //first GSM
            GSM gsm = new GSM("Samsung Galaxy S3", "Samsumg", null, 819);
            gsm.Battery = new Battery(1337, 50, "Durasel");
            gsm.Display = new Display(30, 6000000);

            //second GSM
            GSM gsm1 = new GSM("Motorola", "MotorolaOOD");
            gsm1.Battery = new Battery(20, 40, "Durasel", BatteryType.NiCd); // set batteryType to NiCd

            //third GSM
            GSM gsm2 = new GSM("Nokia", "Nokia", "Chuck Norris");
            gsm2.Battery = new Battery(2, 40, "Durasel"); // by default batteryType is 0, so its the first in the enum

            //Console.WriteLine(GSM.iPhone4S); // information for iPhone4S from the static property 

            GSM[] gsmArray = new GSM[] { gsm, gsm1, gsm2, GSM.iPhone4S};

            foreach (GSM gsmInformation in gsmArray)
            {
                Console.WriteLine(gsmInformation);
            }
            Console.WriteLine();

            //add call to first gsm
            gsm.AddCall(DateTime.Now, 35986225995, 30);
            gsm.AddCall(DateTime.Now.AddHours(3), 35969224751, 70);
            gsm.AddCall(DateTime.Now.AddDays(5).AddHours(10), 35987236594, 160);

            //print the calls
            foreach (Call callInformation in gsm.CallHistory)
            {
                Console.WriteLine(callInformation); // print the call info with override method in Call class
            }
            Console.WriteLine();

            //calc the sum
            Console.WriteLine("Total price of talking - {0} euros", Math.Round((gsm.TotalPriceOfCalls(0.37)), 2));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
