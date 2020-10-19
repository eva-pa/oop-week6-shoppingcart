using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart.Models
{
   public class fruit
    {
        string name_fruit;
        double price;
        int quantity;

        public fruit(string name_fruit)
        {
            this.name_fruit = name_fruit;
           if(name_fruit=="Apple") { this.price = 0.6; }
            if (name_fruit == "Orange") { this.price = 0.25; }
            else { this.price = 0; }
            this.quantity = quantity;

        }
        public string NameFruit
        {  get { return this.name_fruit; } }
        public double Price
        {
            get { return this.price; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}
