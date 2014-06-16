﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AmazeOn.Models
{
    public class Laptop : Item
    {
        public string GraphicCard { get; set; }
        public string Display { get; set; }
        public string Battery { get; set; }

        //Methods.
        public override void AddToLog(string laptopStorageFile)
        {
            StringBuilder result = new StringBuilder();
            StreamWriter writer = new StreamWriter(laptopStorageFile, true);

            using (writer)
            {
                writer.WriteLine(this.Model);
                writer.WriteLine(this.Price);
                writer.WriteLine(this.Quantity);
                writer.WriteLine(this.Picture);
                writer.WriteLine(this.Processor);
                writer.WriteLine(this.GraphicCard);
                writer.WriteLine(this.Manufacturer);
                writer.WriteLine(this.OperationSystem);
                writer.WriteLine(this.Display);
                writer.WriteLine(this.Battery);
                writer.WriteLine("{0}*{1}*{2}", this.Promotion.DateStart, this.Promotion.DateEnd, this.Promotion.PromoPrice);
            }
        }

        public Laptop(double price, Manufacturer manufacturer, OperationSystem operationSystem, Promotion promotion, int quantity, string model,
    string picture, string processor, string graphicCard, string display, string battery)
        {
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.OperationSystem = operationSystem;
            this.Promotion = promotion;
            this.Quantity = quantity;
            this.Model = model;
            this.Picture = picture;
            this.Processor = processor;
            this.GraphicCard = graphicCard;
            this.Display = display;
            this.Battery = battery;
        }
    }
}
