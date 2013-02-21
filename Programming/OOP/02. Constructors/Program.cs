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
            Console.WriteLine(gsm.Manufacturer);
            Console.WriteLine(gsm.Price);
            Display display = new Display();
            Console.WriteLine(display.DisplaySize);
            
        }
    }
}
