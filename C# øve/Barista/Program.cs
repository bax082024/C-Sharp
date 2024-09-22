using System;
using System.Collections.Generic;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet the user and ask for their name
            Console.WriteLine("Hello, Welcome to Mr. Blues bakery");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Nice to meet you: " + name);

            // Ask if the user wants to order from the menu
            Console.WriteLine("Would you like to order from our menu?");
            Console.WriteLine("Type yes or no");
            string order = Console.ReadLine();

            if (order.ToLower() == "no")
            {
                Console.WriteLine("Order Cancelled");
                return;
            }

            // Display the menu
            Menu menu = new Menu();
            List<string> menuItems = menu.GetMenuItems();
            Menu.Price prices = new Menu.Price();

            Console.WriteLine("Menu:");
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }

            // Initialize total price to 0
            int totalPrice = 0;

            // Ask the user for the quantity of each item they want to order
            foreach (var item in menuItems)
            {
                // Extract the item name (removing the price and number prefix)
                string itemName = item.Split(':')[0].Trim().Split('.')[1].Trim();

                // Ask how many the user wants to order
                Console.WriteLine($"How many {itemName} would you like to order?");
                int quantity;
                
                // Ensure the input is a valid number
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                // Calculate the total price for this item
                int itemPrice = prices.GetPrice(itemName.ToLower());
                if (itemPrice != -1)
                {
                    totalPrice += itemPrice * quantity;
                }
                else
                {
                    Console.WriteLine($"Sorry, we don't have {itemName}.");
                }
            }

            // Display the total price for the order
            Console.WriteLine($"Your total order price is: {totalPrice} bitcoin.");
        }
    }

    // Menu class to return the list of items and handle item prices
    public class Menu
    {
        // Method to return the menu list
        public List<string> GetMenuItems()
        {
            List<string> menu = new List<string>
            {
                "1. Svart kaffe : 2 bitcoin",
                "2. Milkshake : 3 bitcoin",
                "3. Is : 10 bitcoin",
                "4. Skillingsbolle : 1 bitcoin",
                "5. Chips : 1 bitcoin"
            };
            return menu;
        }

        // Price class to store and retrieve item prices
        public class Price
        {
            // Prices for each item
            public int SvartKaffe { get; set; } = 2;
            public int Milkshake { get; set; } = 3;
            public int Is { get; set; } = 10;
            public int Skillingsbolle { get; set; } = 1;
            public int Chips { get; set; } = 1;

            // Method to get the price of an item by name
            public int GetPrice(string itemName)
            {
                switch (itemName.ToLower())
                {
                    case "svart kaffe":
                        return SvartKaffe;
                    case "milkshake":
                        return Milkshake;
                    case "is":
                        return Is;
                    case "skillingsbolle":
                        return Skillingsbolle;
                    case "chips":
                        return Chips;
                    default:
                        return -1;  // Invalid item
                }
            }
        }
    }
}
