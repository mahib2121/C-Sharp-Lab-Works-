using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShoppingCart
{
    
    private string cartId;
    private double totalAmount;

   
    public ShoppingCart(string id)
    {
        cartId = id;
        totalAmount = 0.0;
    }

    public string CartId
    {
        get { return cartId; }
    }

    public double TotalAmount
    {
        get { return totalAmount; }
    }

    public void AddItem(double price)
    {
        if (price > 0)
        {
            totalAmount += price;
            Console.WriteLine($"Added item worth {price:C}. Total: {totalAmount:C}");
        }
        else
        {
            Console.WriteLine("Invalid item price. Must be positive.");
        }
    }

    
    public void RemoveItem(double price)
    {
        if (price <= 0)
        {
            Console.WriteLine("Invalid item price. Must be positive.");
            return;
        }

        if (price > totalAmount)
        {
            Console.WriteLine($"Cannot remove item worth {price:C}. Not enough total in cart.");
        }
        else
        {
            totalAmount -= price;
            Console.WriteLine($"Removed item worth {price:C}. Total: {totalAmount:C}");
        }
    }

    
    public void DisplayTotal()
    {
        Console.WriteLine($"Current total amount: {totalAmount:C}");
    }
}



class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart("CART123");

        Console.WriteLine("Cart ID: " + cart.CartId);

        cart.AddItem(50.75);
        cart.AddItem(20.25);
        cart.RemoveItem(10.00);
        cart.RemoveItem(100.00); // remove 
        cart.DisplayTotal();

        Console.WriteLine("Final Total: " + cart.TotalAmount);
    }
}
