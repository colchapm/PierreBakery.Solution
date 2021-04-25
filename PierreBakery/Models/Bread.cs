
namespace PierreBakery.Models
{
  public class Bread
  {
    public static int BreadOrder(int breadOrderQty)
    {
      int orderAmount = breadOrderQty * 5; 
      return orderAmount;
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