﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AmazeOn.Models
{
    public static class UserFactory
    {
        //Fields.
        public const string UserContainer = "../../Models/Users.txt";

        //Constructors.
        public static User NewCurrentUser(string username, string password)
        {
            if (username == null && password == null)
            {
                return new GuestUser();
            }
            else if (username.Equals(Admin.USERNAME) && password.Equals(Admin.PASSWORD))
            {
                return new Admin();
            }
            else if (UserFactory.IsRegistered(username, password))
            {
                return new NormalUser(username, password, UserFactory.GetUserAdress(username, password));
            }
            else
            {
                throw new ArgumentException("The username or password are invalid!");
            }
        }

        //Methods.
        private static bool IsRegistered(string usernameToCheck, string passwordToCheck)
        {
            bool isRegistered = false;

            using (StreamReader reader = new StreamReader(UserFactory.UserContainer))
            {
                string line = reader.ReadLine();
                //Skip the first line
                line = reader.ReadLine();

                while (line != null)
                {
                    string[] rawElements = line.Split('+');
                    string currentUserName = rawElements[0];
                    string currentPassword = rawElements[1];

                    if (usernameToCheck == currentUserName &&
                        passwordToCheck == currentPassword)
                    {
                        isRegistered = true;
                        break;
                    }

                    line = reader.ReadLine();
                }
            }

            return isRegistered;
        }

        private static string GetUserAdress(string username, string password)
        {
            string result = null;
            StreamReader reader = new StreamReader(UserFactory.UserContainer);

            using (reader)
            {
                string line = reader.ReadLine();
                //Skip the first line
                line = reader.ReadLine();

                while (line != null)
                {
                    //Pesho 123456
                    string[] rawElements = line.Split('+');
                    string currentUserName = rawElements[0];
                    string currentPassword = rawElements[1];
                    result = rawElements[2];

                    if (username == currentUserName &&
                        password == currentPassword)
                    {
                        return result;
                    }

                    line = reader.ReadLine();
                }

                //Throw an exception if no match has been found.
                throw new ArgumentException("This username does not exists");
            }
        }

        public static void Register(string username, string password, string adress)
        {
            if (UserFactory.UserExists(username))
            {
                throw new ArgumentException("This user is already registered");
            }
            if (username.Length <= 4 || username.Length >= 51)
            {
                throw new ArgumentException("The username must be between 5 and 50 symbols");
            }
            if (password.Length <= 4 || password.Length >= 51)
            {
                throw new ArgumentException("The password must be between 5 and 50 symbols");
            }
            if (username.Contains('+') || password.Contains('+'))
            {
                throw new ArgumentException("The username or password contains forbidden '+' sign");
            }

            StreamWriter writer = new StreamWriter(UserFactory.UserContainer, true);

            using (writer)
            {
                writer.WriteLine("{0}+{1}+{2}", username, password, adress);
            }
        }

        private static bool UserExists(string usernameToCheck)
        {
            bool result = false;
            StreamReader reader = new StreamReader(UserFactory.UserContainer);

            using (reader)
            {
                string line = reader.ReadLine();
                line = reader.ReadLine();

                while (line != null)
                {
                    //Pesho 123456
                    string[] rawElements = line.Split('+');
                    string currentUserName = rawElements[0];

                    if (usernameToCheck == currentUserName)
                    {
                        result = true;
                        break;
                    }

                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}
