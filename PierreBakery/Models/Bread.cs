
namespace PierreBakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public Bread(int breadOrderQty)
    {
      Quantity = breadOrderQty;
    }
    public static int BreadOrder(int Quantity)
    {
      return Quantity * 5;
    }

    public static int SpecialOffer(int Quantity)
    {
      int receivedQty = Quantity;
      if (Quantity>= 2)
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