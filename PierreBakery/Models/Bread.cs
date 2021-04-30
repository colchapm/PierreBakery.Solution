
namespace PierreBakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public Bread(int breadOrderQty)
    {
      Quantity = breadOrderQty;
    }
    public static int BreadOrder(int breadOrderQty)
    {
      return breadOrderQty * 5;
    }

    public static int SpecialOffer(int breadOrderQty)
    {
      int receivedQty = breadOrderQty;
      if (breadOrderQty>= 2)
      {
        return receivedQty + 1;
      }
      else 
      {
        return receivedQty;
      }
    }
  }
}