using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AmazeOn.Models
{
    public class CurrentUser
    {
        //Fields.
        private static User instance;

        //Properties
        public User Instance
        {
            get
            {
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        //Methods
        public static void SetCurrentUser(string username, string password)
        {
            if (instance == null)
            {
                instance = new GuestUser();
            }
            else
            {
                instance = UserFactory.NewCurrentUser(username, password);
            }
        }

        private void AddToLog()
        {
            if (this.Instance is NormalUser)
            {
                NormalUser user = (NormalUser) this.Instance;
                StringBuilder result = new StringBuilder();
                StreamWriter writer = new StreamWriter("../../log.txt", true);

                using (writer)
                {
                    foreach (var item in user.MyCart.ItemsInCart)
                    {
                        writer.WriteLine("{0}:{1}:{2} {3}.{4}.{5}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                        writer.WriteLine(user.UserName);
                        writer.WriteLine(item.Quantity);
                        writer.WriteLine(item.Model);
                    }
                }
            }
        }

        //Constructor.
        private CurrentUser()
        {
        }
    }
}
