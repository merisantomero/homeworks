using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to enter what type of item they are purchasing, the quantity of the item, and the price for the item
            
            Console.WriteLine("What is the product name of the item you are purchasing?");
            //create a variable as a sequence of characters for the user's response
            string product = Console.ReadLine();
            
            Console.WriteLine($"How many {product}s do you want to buy?");
            //create a variable as a number for the user's response
            int quantity = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"What is the price for each {product}?");
            //create a variable as a real number for the user's response
            double price = Convert.ToDouble(Console.ReadLine());

            //create a variable for the sales tax rate as a real number
            double percent = 0.085;
            //create a variable to calculate the subtotal, the sales tax, sales total
            double subtotal = quantity * price;
            double salestax = subtotal * percent;
            double salestotal = subtotal + salestax;

            //output all three to the user as currency
            Console.WriteLine($"Your subtotal for your bill is {subtotal.ToString("C")}.");
            Console.WriteLine($"Your sales tax for your bill is {salestax.ToString("C")}.");
            Console.WriteLine($"Your total for your bill is {salestotal.ToString("C")}.");

            Console.ReadKey();
        }
    }
}
