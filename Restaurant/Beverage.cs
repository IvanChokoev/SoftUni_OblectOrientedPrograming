using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public virtual double Milliliers { get; set; }
        public Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliliers = milliliters;
        }

    }
}