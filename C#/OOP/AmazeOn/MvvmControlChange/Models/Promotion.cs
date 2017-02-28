using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazeOn.Models
{
    public class Promotion
    {
        //Properties
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public double PromoPrice { get; set; }

        //Constructors
        public Promotion(DateTime dateStart, DateTime dateEnd, double promoPrice)
        {
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.PromoPrice = promoPrice;
        }
    }
}
