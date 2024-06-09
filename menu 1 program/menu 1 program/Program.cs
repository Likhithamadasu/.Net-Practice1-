using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_1_program
{
    internal class Program
    {
       

            static void Main()
            {
                int coffeeQuantity = 0;
                int GrilledSandwichQuantity = 0;
                int FrenchFriesQuantity = 0;
                int NoodlesQuantity = 0;
                int pizzaQuantity = 0;
                double totalBill = 0;

                while (true)
                {
                    Console.WriteLine("Select the item from the menu you want to order:");
                    Console.WriteLine("1. Coffee");
                    Console.WriteLine("2. Grilled Sandwich");
                    Console.WriteLine("3. French Fries");
                    Console.WriteLine("4. Noodles");
                    Console.WriteLine("5. Pizza");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("You selected Coffee. Quantity: ");
                            coffeeQuantity += Convert.ToInt32(Console.ReadLine());
                            totalBill += coffeeQuantity * 40;
                            break;
                        case 2:
                            Console.Write("You selected Grilled Sandwich. Quantity: ");
                            GrilledSandwichQuantity += Convert.ToInt32(Console.ReadLine());
                            totalBill += GrilledSandwichQuantity * 80;
                            break;
                        case 3:
                            Console.Write("You selected French Fries. Quantity: ");
                            FrenchFriesQuantity += Convert.ToInt32(Console.ReadLine());
                            totalBill += FrenchFriesQuantity * 60;
                            break;
                        case 4:
                            Console.Write("You selected Noodles. Quantity: ");
                            NoodlesQuantity += Convert.ToInt32(Console.ReadLine());
                            totalBill += NoodlesQuantity * 50;
                            break;
                        case 5:
                            Console.Write("You selected Pizza. Quantity: ");
                            pizzaQuantity += Convert.ToInt32(Console.ReadLine());
                            totalBill += pizzaQuantity * 120;
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Please select a valid option.");
                            break;

                    }

                    Console.Write("Do you want to add more items? (Y/N): ");
                    char addMore = Convert.ToChar(Console.ReadLine());
                    if (addMore != 'Y' && addMore != 'y')
                        break;
                }

                Console.WriteLine($"Total Items: {coffeeQuantity} Coffee, {GrilledSandwichQuantity} GrillChicken, {FrenchFriesQuantity} FrenchFries, {NoodlesQuantity} Noodles, {pizzaQuantity} Pizza");
                Console.WriteLine("Thank you for your order!");

                double cgst = totalBill * 0.05;
                double sgst = totalBill * 0.18;
                double totalAmount = totalBill + cgst + sgst;

                Console.WriteLine("\nTotal Items:");
                Console.WriteLine($"1. Coffee: {coffeeQuantity} * 40 Rs = {coffeeQuantity * 40} Rs");
                Console.WriteLine("2. Grilled Sandwich: 80 Rs");
                Console.WriteLine("3. French Fries: 60 Rs");
                Console.WriteLine("4. Noodles: 50 Rs");
                Console.WriteLine($"5. Pizza: {pizzaQuantity} * 120 Rs = {pizzaQuantity * 120} Rs");

                Console.WriteLine("\nTotal Bill: " + totalBill);
                Console.WriteLine("CGST 5%: " + cgst);
                Console.WriteLine("SGST 18%: " + sgst);
                Console.WriteLine("Total Amount to Pay: " + totalAmount);
            }


    }

}
    

