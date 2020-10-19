using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart.Models
{
    public class shoppingcart
    {
        double total_cost = 0;
        string name_client;
        List<fruit> cart;
        public shoppingcart(string name_client)
        {
            this.total_cost = total_cost;
            this.name_client = name_client;
        }
        public double TotalCost
        {
            get { return this.total_cost; }
            set { this.total_cost = value; }
        }
        public string NameClient
        {
            get { return this.name_client; }
            set { name_client = value; }
        }
        public void AddFruitToCart()
        {
            while (Convert.ToInt32(Console.ReadLine()) != 3)
            {
                Console.WriteLine("Product to scan :");
            Console.WriteLine("Type 1 for apples :");
                Console.WriteLine("Type 2 for oranges");
                Console.WriteLine("Type 3 when you're done shopping");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    string a_fruit = "apple";
                        Console.WriteLine("Choose the quantity");
                        int quantity1 = Convert.ToInt32(Console.ReadLine());

                break;
                    case 2:
                    string b_fruit = "orange";
                        Console.WriteLine("Choose the quantity");
                        int quantity2 = Convert.ToInt32(Console.ReadLine());
                        break;
            }
            }
        }
    }
}
