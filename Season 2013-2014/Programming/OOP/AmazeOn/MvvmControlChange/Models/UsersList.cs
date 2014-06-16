﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazeOn.Models
{
    public class UsersList
    {
        private List<User> Users { get; set; }

        public UsersList()
        {
            this.Users = new List<User>();
        }

        public void AddTodo(string userName, string password, string address, bool isAdmin)
        {
            var user = new User(userName, password, address, isAdmin);
            this.Users.Add(user);
        }

        public static UsersList Deserialize(string serializedData)
        {
            var serializedUsers = serializedData.Split(new string[] { "+", Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            if (serializedUsers.Length % 3 != 0)
            {
                throw new ArgumentOutOfRangeException("The serialized data is invalid");
            }

            var usersList = new UsersList();

            for (var i = 0; i < serializedUsers.Length; i += 4)
            {
                usersList.AddTodo(serializedUsers[i], serializedUsers[i + 1],
                                  serializedUsers[i + 2], bool.Parse(serializedUsers[i + 3]));
            }

            return usersList;
        }
    }
}