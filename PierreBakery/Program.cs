using System;
using PierreBakery.Models;

namespace PierreBakery
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      System.Threading.Thread.Sleep(2000);
      Console.WriteLine("Each loaf of bread costs $5 and each pastry is $2 each.");
      System.Threading.Thread.Sleep(1000);
      Console.WriteLine("Our current specials are: Buy 2 Or More Loaves of Bread, Get One Free & Buy 3 Pastries for $5");
      System.Threading.Thread.Sleep(2000);
      Console.WriteLine("How many loaves of bread would you like?");
      string stringBreadOrder = Console.ReadLine();
      int breadOrderQty = int.Parse(stringBreadOrder);
      Console.WriteLine("How many pastries can I get you?");
      string stringPastryOrder = Console.ReadLine();
      int pastryOrderQty = int.Parse(stringPastryOrder);
      
      int breadOrder = Bread.SpecialOffer(breadOrderQty);
      int orderTotal = Bread.BreadOrder(breadOrderQty) + Pastry.PastryOrder(pastryOrderQty);

      System.Threading.Thread.Sleep(2000);
      Console.WriteLine($"Your order results in {breadOrder} loaves of bread and {pastryOrderQty} pastries. Your total comes out to ${orderTotal}.");

    }
  }
}