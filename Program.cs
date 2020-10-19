using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter your name");
            string person_name = Console.ReadLine();
            shoppingcart client = new shoppingcart();
            Console.ReadKey();
        }
    }
}
