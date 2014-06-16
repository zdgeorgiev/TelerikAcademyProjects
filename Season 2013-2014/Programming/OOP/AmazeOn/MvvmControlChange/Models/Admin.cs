using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazeOn.Models
{
    public class Admin : User
    {
        //Fields. 
        public const string USERNAME = "admin";
        public const string PASSWORD = "qwerty";

        //Properties.
        public Log Log { get; set; }

        //Methods.

        //Constructors
        public Admin()
        {
            this.Log = new Log();
        }
    }
}