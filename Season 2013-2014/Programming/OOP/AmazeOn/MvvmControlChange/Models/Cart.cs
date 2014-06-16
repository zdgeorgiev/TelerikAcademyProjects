using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AmazeOn.Models
{
    //Must be constructed as Singleton - there should be only one inicialized Card.
    public class Cart
    {
        //Fields
        private static Cart instance;
        private List<Item> itemsInCart;


        public Cart Instance
        {
            get
            {
                return instance;
            }
            private set
            {
                if (instance == null)
                {
                    instance = new Cart();
                    instance.itemsInCart = new List<Item>();
                }
            }
        }

        private Cart()
        {
        }

        public List<Item> ItemsInCart
        {
            get
            {
                return itemsInCart;
            }
            private set
            {
                this.itemsInCart = value;
            }
        }

        //Methods
        public static Cart InitializeCart()
        {
            if (instance == null)
            {
                instance = new Cart();
                instance.itemsInCart = new List<Item>();
            }

            return instance;
        }

        public void EmptyCart()
        {
            this.itemsInCart = new List<Item>();
        }

        public void AddToCart(Item item)
        {
            this.itemsInCart.Add(item);
        }

        public void RemoveItem(Item itemsToRemove)
        {
            List<Item> newList = new List<Item>();
            bool isRemoved = false;
            
            foreach (var item in this.itemsInCart)
            {
                if (itemsToRemove == item && !isRemoved)
                {
                    isRemoved = true;
                    continue;
                }
                else
                {
                    newList.Add(item);
                }
            }

            this.itemsInCart = newList;
        }
    }
}
