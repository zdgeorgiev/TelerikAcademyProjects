using System;

namespace AmazeOn.Models
{
    public class User
    {
        //Properties
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Address { get; private set; }
        public bool IsAdmin { get; private set; }

        //Constructors
        public User(string username, string password, string address, bool isAdmin)
        {
            this.Username = username;
            this.Password = password;
            this.Address = address;
            this.IsAdmin = isAdmin;
        }
    }
}