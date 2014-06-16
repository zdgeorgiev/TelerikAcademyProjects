using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazeOn.Models
{
    //Must be constructed as Singleton.
    public class Log
    {
        List<ILogable> events;

        //Methods
        void AddToLog(ILogable something)
        {
            throw new NotImplementedException();
        }
    }
}
