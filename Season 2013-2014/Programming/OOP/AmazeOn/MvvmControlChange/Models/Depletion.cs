﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazeOn.Models
{
    public class Depletion : Event, ILogable
    {
        //Fields
        Item depletedItem;

        public void AddToLog(string storageFile)
        {
            throw new NotImplementedException();
        }
    }
}
