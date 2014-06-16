using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AmazeOn.Models
{
    public class NormalUser : User
    {
        //Fields.

        //Properties.
        public Cart MyCart { get; set; }
        public string Adress { get; set; }

        //Methods.

        //Constructors.
        public NormalUser(string userName, string password, string adress)
            : base(userName, password, true)
        {
            this.Adress = adress;
        }
    }
}