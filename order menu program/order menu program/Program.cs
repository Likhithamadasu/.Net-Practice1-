using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_menu_program
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                // Initialize a dictionary to store menu items and their prices
                Dictionary<int, string> menu = new Dictionary<int, string>()
        {
            { 1, "Coffee" },
            { 2, "Grilled Sandwich" },
            { 3, "French Fries" },
            { 4, "Noodles" },
            { 5, "Pizza" }
        };


                Dictionary<string, int> order = new Dictionary<string, int>();
                string moreItems = "Y";


                while (moreItems.ToUpper() == "Y")
                {
                    Console.WriteLine("Select the item from the menu you want to order:");
                    foreach (var item in menu)
                    {
                        Console.WriteLine($"{item.Key}. {item.Value}");
                    }

                    int selectedItem;
                    if (int.TryParse(Console.ReadLine(), out selectedItem) && menu.ContainsKey(selectedItem))
                    {
                        Console.WriteLine($"You selected {menu[selectedItem]}");
                        Console.Write("Quantity: ");
                        int quantity;
                        if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                        {
                            // Add item to order
                            if (order.ContainsKey(menu[selectedItem]))
                            {
                                order[menu[selectedItem]] += quantity;
                            }
                            else
                            {
                                order.Add(menu[selectedItem], quantity);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. Please enter a valid item number.");
                    }

                    Console.Write("Do you want to add more items? (Y/N): ");
                    moreItems = Console.ReadLine().ToUpper();
                }

                // Display order summary
                Console.WriteLine("\nItems selected by you:");
                foreach (var item in order)
                {
                    Console.WriteLine($"- {item.Value} {item.Key}");
                }
                Console.WriteLine($"Total Items: {order.Count}");

                Console.ReadLine(); // To prevent the console from closing immediately
            }
    }

}


   

   
