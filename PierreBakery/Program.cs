using System;
using PierreBakery.Models;

namespace PierreBakery
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. We bake good things.");
      Console.WriteLine("Each loaf of bread costs $5 and each pastry is $2.");
      Console.WriteLine("Our current specials are: Buy 2 Or More Loaves of Bread, Get One Free & Buy 3 Pastries for $5");
      Console.WriteLine("How many loaves of bread would you like?");
      string stringBreadOrder = Console.ReadLine();
      int breadOrderQty = int.Parse(stringBreadOrder);
      Console.WriteLine("How many pastries can I get you?");
      string stringPastryOrder = Console.ReadLine();
      int pastryOrderQty = int.Parse(stringPastryOrder);
    
      int breadOrder = Bread.SpecialOffer(breadOrderQty);
      double orderTotal = Bread.BreadOrder(breadOrderQty) + Pastry.PastryOrder(pastryOrderQty);

      System.Threading.Thread.Sleep(1000);
      Console.WriteLine($"Your order results in {breadOrder} loaves of bread and {pastryOrderQty} pastries. Your total comes out to ${orderTotal}.");

      Console.WriteLine("Is there anything else I can get you today? [type 'y' for yes, 'n' for no]");
      string endAnswer = Console.ReadLine();
      if (endAnswer == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Come see the good things we bake again soon.");
      }

    }
  }
}