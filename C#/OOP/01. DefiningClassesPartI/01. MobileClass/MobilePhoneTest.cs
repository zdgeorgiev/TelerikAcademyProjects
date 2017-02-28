using System;
using System.Collections.Generic;
using System.Linq;

public class GSMTest
{
    static void Main(string[] args)
    {
        List<MobilePhone> allPhones = new List<MobilePhone>()
        {
            new MobilePhone(PhoneModel.Samsung, "Samsung Electronics", 2500,
                new Battery(BatteryModel.LiIon, 25000, 5000), new Display(600,2000000))
        };

        allPhones.Add(MobilePhone.IPhone4S);

        foreach (var mobilePhone in allPhones)
        {
            Console.WriteLine(mobilePhone);
        }

        MobilePhone phone = MobilePhone.IPhone4S;

        phone.AddCall(new Call(DateTime.Now, "0888123354", 4342));
        phone.AddCall(new Call(DateTime.Now.AddHours(3), "0888128764", 4341242));
        phone.AddCall(new Call(DateTime.Now.AddDays(5), "0888187354", 435));

        Console.WriteLine(phone.CalculatePriceFromCalls(0.37M));

        phone.RemoveCall(phone.allCalls.OrderByDescending(call => call.Duration).FirstOrDefault());

        Console.WriteLine(phone.CalculatePriceFromCalls(0.37M));

        foreach (Call call in phone.allCalls)
        {
            Console.WriteLine(call);
        }

        phone.ClearHistory();

        foreach (Call call in phone.allCalls)
        {
            Console.WriteLine(call);
        }
    }
}