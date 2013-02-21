using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("Iphone4S", "Apple");
            Console.WriteLine(gsm.Model);
            Console.WriteLine(gsm.Manufacturer);
            Console.WriteLine(gsm.Price);
            Console.WriteLine();
            Battery bat = new Battery(50,6);
            Console.WriteLine(bat.HoursIdle);
            Console.WriteLine(bat.HoursTalk);
            GSM newPhone = new GSM("Nokia", "Apple", "Zdravko", 800M, null, null);
            Console.WriteLine(newPhone.Battery);
        }
    }
}
