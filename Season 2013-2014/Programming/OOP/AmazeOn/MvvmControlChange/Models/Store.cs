﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AmazeOn.Models
{
    public class Store
    {
        //Fields
        public User CurrentUser { get; set; }
        public Cart Cart { get; set; }    
        private static Store instance;
        private List<Item> itemsInStore;
        private List<User> users;

        //Constructors

        public static Store InitializeStore()
        {
            if (instance == null)
            {
                instance = new Store();
                instance.itemsInStore = new List<Item>();
                instance.users = new List<User>();
                instance.Cart = Cart.InitializeCart();
            }

            return instance;
        }

        private Store()
        {
        }

        //Properties
        public static Store Instance
        {
            get
            {
                return instance;
            }

            private set
            {
                if (instance == null)
                {
                    instance = new Store();
                    instance.itemsInStore = new List<Item>();
                    instance.users = new List<User>();
                    instance.Cart = Cart.InitializeCart();
                }
            }
        }

        public List<Item> ItemsInStore
        {
            get
            {
                return itemsInStore;
            }
            private set
            {
                this.itemsInStore = value;
            }
        }

        //Methods
        public static List<Item> FillUpStore()
        {
            List<Item> fullStore = new List<Item>();

            StreamReader reader = new StreamReader("../../Content/Store/Items/computers.txt");
            double price;
            Manufacturer manufacturer;
            OperationSystem operationSystem;
            Promotion promotion;
            int quantity;
            string model;
            string picture;
            string processor;
            string graphicCard;
            string[] utility;
            Computer computer;
            Laptop laptop;
            string display;
            string battery;
            GSM gsm;

            using (reader)
            {
                string result = reader.ReadLine();

                while (result != null)
                {
                    model = result;
                    price = double.Parse(reader.ReadLine());
                    quantity = int.Parse(reader.ReadLine());
                    picture = reader.ReadLine();
                    processor = reader.ReadLine();
                    graphicCard = reader.ReadLine();
                    manufacturer = (Manufacturer) Enum.Parse(typeof(Manufacturer), reader.ReadLine());
                    operationSystem = (OperationSystem) Enum.Parse(typeof(OperationSystem), reader.ReadLine());
                    result = reader.ReadLine();
                    utility = result.Split('*');
                    promotion = new Promotion(DateTime.Parse(utility[0]), DateTime.Parse(utility[1]), double.Parse(utility[2]));
                    computer = new Computer(price, manufacturer, operationSystem, promotion, quantity, model, picture, processor, graphicCard);
                    fullStore.Add(computer);

                    result = reader.ReadLine();
                }
            }

            reader = new StreamReader("../../Content/Store/Items/laptops.txt");

            using (reader)
            {
                string result = reader.ReadLine();

                while (result != null)
                {
                    model = result;
                    price = double.Parse(reader.ReadLine());
                    quantity = int.Parse(reader.ReadLine());
                    picture = reader.ReadLine();
                    processor = reader.ReadLine();
                    graphicCard = reader.ReadLine();
                    manufacturer = (Manufacturer)Enum.Parse(typeof(Manufacturer), reader.ReadLine());
                    operationSystem = (OperationSystem)Enum.Parse(typeof(OperationSystem), reader.ReadLine());
                    display = reader.ReadLine();
                    battery = reader.ReadLine();
                    result = reader.ReadLine();
                    utility = result.Split('*');
                    promotion = new Promotion(DateTime.Parse(utility[0]), DateTime.Parse(utility[1]), double.Parse(utility[2]));
                    laptop = new Laptop(price, manufacturer, operationSystem, promotion, quantity, model, picture, processor,
                        graphicCard, display, battery);
                    fullStore.Add(laptop);

                    result = reader.ReadLine();
                }
            }

            reader = new StreamReader("../../Content/Store/Items/GSMs.txt");

            using (reader)
            {
                string result = reader.ReadLine();

                while (result != null)
                {
                    model = result;
                    price = double.Parse(reader.ReadLine());
                    quantity = int.Parse(reader.ReadLine());
                    picture = reader.ReadLine();
                    processor = reader.ReadLine();
                    manufacturer = (Manufacturer)Enum.Parse(typeof(Manufacturer), reader.ReadLine());
                    operationSystem = (OperationSystem)Enum.Parse(typeof(OperationSystem), reader.ReadLine());
                    display = reader.ReadLine();
                    battery = reader.ReadLine();
                    result = reader.ReadLine();
                    utility = result.Split('*');
                    promotion = new Promotion(DateTime.Parse(utility[0]), DateTime.Parse(utility[1]), double.Parse(utility[2]));
                    gsm = new GSM(price, manufacturer, operationSystem, promotion, quantity, model, picture, processor, display, battery);
                    fullStore.Add(gsm);

                    result = reader.ReadLine();
                }
            }

            return fullStore;
        }

        public User FindUser(string username, string password)
        {
            this.FillUsers();

            var userExists = users.FirstOrDefault(u => u.Username == username);

            if (userExists == null)
            {
                throw new LoginException("This user is not registered");
            }

            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                throw new LoginException("Wrong password");
            }

            return user;
        }

        public User RegisterUser(string username,string password,string address)
        {
            if (username == null)
            {
                throw new RegisterException("The username can't be empty");
            }
            else if (username.Contains('+'))
            {
                throw new RegisterException("The username can't contain the symbol '+'");
            }
            else if (this.FindUserByUsername(username) != null)
            {
                throw new RegisterException("This username is already taken");
            }
            else if (password == null)
            {
                throw new RegisterException("The password can't be empty");
            }
            else if (password.Contains('+'))
            {
                throw new RegisterException("The password can't contain the symbol '+'");
            }
            else if (address == null)
            {
                throw new RegisterException("The address can't be empty");
            }
            else if (address.Contains('+'))
            {
                throw new RegisterException("The address can't contain the symbol '+'");
            }
            else
            {
                User userToRegister = new User(username, password, address, false);

                using (StreamWriter writer = new StreamWriter("../../Models/Users.txt", true))
                {
                    writer.WriteLine("{0}+{1}+{2}+{3}", userToRegister.Username,
                                userToRegister.Password, userToRegister.Address, false);
                }

                return userToRegister;
            }
        }


        public User FindUserByUsername(string username)
        {
            this.FillUsers();

            var user = users.FirstOrDefault(u => u.Username == username);

            return user;
        }

        private void FillUsers()
        {
            StreamReader reader = new StreamReader("../../Models/Users.txt");

            using (reader)
            {
                var serializedLine = reader.ReadLine();
                serializedLine = reader.ReadLine();

                while (serializedLine != null)
                {
                    var serializedUser = serializedLine.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);

                    if (serializedUser.Length != 4)
                    {
                        throw new ArgumentOutOfRangeException("The serialized data is invalid");
                    }

                    users.Add(new User(serializedUser[0], serializedUser[1], 
                        serializedUser[2], bool.Parse(serializedUser[3])));

                    serializedLine = reader.ReadLine();
                }
            }
        }
    }
}
